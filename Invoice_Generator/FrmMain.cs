using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_Generator
{
    public partial class FrmMain : Form
    {

        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        int AdminId;
        public FrmMain(int adminId)
        {
            InitializeComponent();
            AdminId = adminId;

            // Attach KeyPress and TextChanged events to both textboxes
            TxtItemPrice.KeyPress += TxtDecimal_KeyPress;
            TxtItemQty.KeyPress += TxtDecimal_KeyPress;

            TxtItemPrice.TextChanged += TxtDecimal_TextChanged;
            TxtItemQty.TextChanged += TxtDecimal_TextChanged;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LblAdminId.Text = AdminId.ToString();
            TxtTotalPrice.Text = "0.00";
            TxtItemId.Hide();
            UpdateBtn.Hide();
            DeleteBtn.Hide();
            CancelBtn.Hide();

            TxtInvoiceNumber.Text = GenerateInvoiceNumber();
            CalculateTotalPrice();


            // Clear any existing columns first
            ItemsDataGridView.Columns.Clear();

            // Add columns with proper names and types
            ItemsDataGridView.Columns.Add("ItemNo", "Item No");
            ItemsDataGridView.Columns.Add("Name", "Name");
            ItemsDataGridView.Columns.Add("Price", "Price");
            ItemsDataGridView.Columns.Add("Qty", "Qty");
            ItemsDataGridView.Columns.Add("Unit", "Unit");
            ItemsDataGridView.Columns.Add("SubTotal", "Sub Total");

            // Optional: make columns readonly if you want
            ItemsDataGridView.Columns["SubTotal"].ReadOnly = true;

            LoadAdminDetails();
            LoadShopDetails();
        }

        private void LoadAdminDetails()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT UserName FROM Admins WHERE AdminId = @adminid";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@adminid", AdminId);

                    con.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            LblAdminUsername.Text = dr["UserName"].ToString();
                        }
                    }
                }
            }
        }

        private void LoadShopDetails() 
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "Select * from Shop Where ShopId = 1";

                con.Open();
                using (SqlCommand cmd = new SqlCommand(query,con))
                {

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            LblShopTitle.Text = dr["Name"].ToString();
                            LblShopAddress.Text = dr["Address"].ToString();
                            LblShopPhone1.Text = dr["Phone1"].ToString();
                            LblShopPhone2.Text = dr["Phone2"].ToString();
                            LblShopCurrency.Text = dr["Currency"].ToString();

                            if (dr["Image"] != DBNull.Value)
                            {
                                try
                                {
                                    byte[] imgBytes = dr["Image"] as byte[];

                                    if (imgBytes != null && imgBytes.Length > 0)
                                    {
                                        using (MemoryStream ms = new MemoryStream(imgBytes))
                                        {
                                            ShopLogo.Image = Image.FromStream(ms);
                                        }
                                    }
                                }
                                catch
                                {
                                    ShopLogo.Image = null;
                                }
                            }
                        }
                    }

                }

                con.Close();
                
            }
        }

        // Generate Invoice Number Method
        private string GenerateInvoiceNumber()
        {
            // Generate 3 random uppercase letters
            var letters = new char[3];
            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                letters[i] = (char)rnd.Next('A', 'Z' + 1);
            }

            // Generate 8 random digits
            string digits = "";
            for (int i = 0; i < 8; i++)
            {
                digits += rnd.Next(0, 10).ToString();
            }

            // Combine parts
            return new string(letters) + "-" + digits;
        }

        // Get Total Price Method Sum of All SubTotal Of Every Item
        public void CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (DataGridViewRow row in ItemsDataGridView.Rows)
            {
                if (row.Cells[5].Value != null)
                {
                    if (decimal.TryParse(row.Cells[5].Value.ToString(), out decimal subTotal))
                    {
                        totalPrice += subTotal;
                    }
                }
            }

            // If you have a textbox or label for total:
            TxtTotalPrice.Text = totalPrice.ToString("0.00");
        }

        // Decimal Format Method for Item and Qty Textbox (1)
        private void TxtDecimal_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (decimal.TryParse(txt.Text, out decimal value))
            {
                int dotIndex = txt.Text.IndexOf('.');
                if (dotIndex >= 0 && txt.Text.Length - dotIndex - 1 > 2)
                {
                    txt.Text = value.ToString("0.00"); // truncate to 2 decimals
                    txt.SelectionStart = txt.Text.Length; // move cursor to end
                }
            }
            else if (!string.IsNullOrEmpty(txt.Text))
            {
                txt.Text = "0.00";
                txt.SelectionStart = txt.Text.Length;
            }
        }

        // Decimal Format Method for Item and Qty Textbox (2)
        private void TxtDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Allow control keys like Backspace
            if (char.IsControl(e.KeyChar))
                return;

            // Allow digits
            if (char.IsDigit(e.KeyChar))
            {
                // Check if there is a decimal point
                int dotIndex = txt.Text.IndexOf('.');
                if (dotIndex >= 0)
                {
                    // Allow max 2 digits after decimal
                    if (txt.SelectionStart > dotIndex && txt.Text.Length - dotIndex > 2)
                    {
                        e.Handled = true;
                    }
                }
                return;
            }

            // Allow one decimal point
            if (e.KeyChar == '.' && !txt.Text.Contains("."))
                return;

            // Block everything else
            e.Handled = true;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Validate input first (optional but recommended)
            if (string.IsNullOrWhiteSpace(TxtItemName.Text) ||
                string.IsNullOrWhiteSpace(TxtItemPrice.Text) ||
                string.IsNullOrWhiteSpace(TxtItemQty.Text) ||
                OptionItemUnit.SelectedItem == null)
            {
                MessageBox.Show("Please fill all item fields and select a unit.");
                return;
            }

            // Parse price and quantity safely
            if (!decimal.TryParse(TxtItemPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid price format.");
                return;
            }

            if (!decimal.TryParse(TxtItemQty.Text, out decimal qty))
            {
                MessageBox.Show("Invalid quantity format.");
                return;
            }

            // Calculate subtotal
            decimal subtotal = price * qty;

            // Determine the next Item No (row count + 1)
            int itemNo = ItemsDataGridView.Rows.Count + 1;

            // Add a new row
            ItemsDataGridView.Rows.Add(
                itemNo,
                TxtItemName.Text.Trim(),
                price.ToString("0.00"),   // format price with 2 decimals
                qty,
                OptionItemUnit.SelectedItem.ToString(),
                subtotal.ToString("0.00")
            );

            CalculateTotalPrice();

            // Optional: clear inputs after adding
            TxtItemName.Clear();
            TxtItemPrice.Clear();
            TxtItemQty.Clear();
            OptionItemUnit.SelectedIndex = -1;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            TxtItemId.Text = "";
            TxtItemName.Clear();
            TxtItemPrice.Clear();
            TxtItemQty.Clear();
            OptionItemUnit.SelectedIndex = -1;

            AddBtn.Show();
            UpdateBtn.Hide();
            DeleteBtn.Hide();
            CancelBtn.Hide();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtItemId.Text))
            {
                MessageBox.Show("No item selected to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtItemName.Text) ||
                string.IsNullOrWhiteSpace(TxtItemPrice.Text) ||
                string.IsNullOrWhiteSpace(TxtItemQty.Text) ||
                OptionItemUnit.SelectedItem == null)
            {
                MessageBox.Show("Please fill all item fields and select a unit.");
                return;
            }

            if (!decimal.TryParse(TxtItemPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid price format.");
                return;
            }

            if (!decimal.TryParse(TxtItemQty.Text, out decimal qty))
            {
                MessageBox.Show("Invalid quantity format.");
                return;
            }

            decimal subtotal = price * qty;
            int itemId = Convert.ToInt32(TxtItemId.Text);

            foreach (DataGridViewRow row in ItemsDataGridView.Rows)
            {
                if (row.Cells[0].Value != null &&
                    Convert.ToInt32(row.Cells[0].Value) == itemId)
                {
                    row.Cells[1].Value = TxtItemName.Text.Trim();
                    row.Cells[2].Value = price.ToString("0.00");
                    row.Cells[3].Value = qty;
                    row.Cells[4].Value = OptionItemUnit.SelectedItem.ToString();
                    row.Cells[5].Value = subtotal.ToString("0.00");
                    break;
                }
            }


            CalculateTotalPrice(); 

            // Reset UI
            TxtItemId.Text = "";
            TxtItemName.Clear();
            TxtItemPrice.Clear();
            TxtItemQty.Clear();
            OptionItemUnit.SelectedIndex = -1;

            AddBtn.Show();
            UpdateBtn.Hide();
            DeleteBtn.Hide();
            CancelBtn.Hide();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtItemId.Text))
            {
                MessageBox.Show("No item selected to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this item?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            int itemId = Convert.ToInt32(TxtItemId.Text);

            foreach (DataGridViewRow row in ItemsDataGridView.Rows)
            {
                if (row.Cells[0].Value != null &&
                    Convert.ToInt32(row.Cells[0].Value) == itemId)
                {
                    ItemsDataGridView.Rows.Remove(row);
                    break;
                }
            }

            for (int i = 0; i < ItemsDataGridView.Rows.Count; i++)
            {
                ItemsDataGridView.Rows[i].Cells[0].Value = i + 1;
            }


            CalculateTotalPrice(); 

            TxtItemId.Text = "";
            TxtItemName.Clear();
            TxtItemPrice.Clear();
            TxtItemQty.Clear();
            OptionItemUnit.SelectedIndex = -1;

            AddBtn.Show();
            UpdateBtn.Hide();
            DeleteBtn.Hide();
            CancelBtn.Hide();
        }

        private void ItemsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtItemId.Text = ItemsDataGridView.CurrentRow.Cells[0].Value.ToString();
            TxtItemName.Text = ItemsDataGridView.CurrentRow.Cells[1].Value.ToString();
            TxtItemPrice.Text = ItemsDataGridView.CurrentRow.Cells[2].Value.ToString();
            TxtItemQty.Text = ItemsDataGridView.CurrentRow.Cells[3].Value.ToString();
            OptionItemUnit.Text = ItemsDataGridView.CurrentRow.Cells[4].Value.ToString();

            AddBtn.Hide();
            UpdateBtn.Show();
            DeleteBtn.Show();
            CancelBtn.Show();

        }

        // Save Invoice Btn Save Only
        private void SaveInvoiceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int invoiceId = SaveInvoice();

                if (invoiceId > 0)
                {
                    MessageBox.Show("Invoice Saved Successfully!");
                    RefreshForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        // Save + Print Invoice Btn Both
        private void SaveAndPrintInvoiceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int invoiceId = SaveInvoice();

                if (invoiceId > 0)
                {
                    MessageBox.Show("Invoice Saved Successfully!");

                    // Open report and pass InvoiceId
                    FrmInvoice frmInvoice = new FrmInvoice(invoiceId);
                    frmInvoice.ShowDialog();

                    // After closing report, refresh main form
                    RefreshForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        // Save Invoice Method Which saves data in Invoices Table and Invoice_Items Table
        private int SaveInvoice()
        {
            if (ItemsDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Add at least one item.");
                return 0;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string invoiceQuery = @"INSERT INTO Invoices 
                    (InvoiceNumber, CustomerName, TotalPrice, InvoiceDateTime)
                    VALUES 
                    (@InvoiceNumber, @CustomerName, @TotalPrice, @InvoiceDateTime);
                    SELECT SCOPE_IDENTITY();";

                    SqlCommand invoiceCmd = new SqlCommand(invoiceQuery, con, transaction);

                    invoiceCmd.Parameters.AddWithValue("@InvoiceNumber", TxtInvoiceNumber.Text);
                    invoiceCmd.Parameters.AddWithValue("@CustomerName", TxtCustomerName.Text);
                    invoiceCmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDecimal(TxtTotalPrice.Text));
                    invoiceCmd.Parameters.AddWithValue("@InvoiceDateTime", DateTime.Now);

                    int invoiceId = Convert.ToInt32(invoiceCmd.ExecuteScalar());

                    foreach (DataGridViewRow row in ItemsDataGridView.Rows)
                    {
                        if (row.Cells[1].Value == null) continue;

                        string itemQuery = @"INSERT INTO InvoiceItems
                        (InvId, Name, Price, Qty, Unit)
                        VALUES
                        (@InvId, @Name, @Price, @Qty, @Unit)";

                        SqlCommand itemCmd = new SqlCommand(itemQuery, con, transaction);

                        itemCmd.Parameters.AddWithValue("@InvId", invoiceId);
                        itemCmd.Parameters.AddWithValue("@Name", row.Cells["Name"].Value.ToString());
                        itemCmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(row.Cells["Price"].Value));
                        itemCmd.Parameters.AddWithValue("@Qty", Convert.ToDecimal(row.Cells["Qty"].Value));
                        itemCmd.Parameters.AddWithValue("@Unit", row.Cells["Unit"].Value.ToString());

                        itemCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    return invoiceId; // 🔥 RETURN ID
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        // Refresh Form Method After Save Data in Database Tables
        private void RefreshForm()
        {
            TxtInvoiceNumber.Text = GenerateInvoiceNumber();
            TxtCustomerName.Clear();
            TxtTotalPrice.Text = "0.00";

            ItemsDataGridView.Rows.Clear();

            TxtItemId.Text = "";
            TxtItemName.Clear();
            TxtItemPrice.Clear();
            TxtItemQty.Clear();
            OptionItemUnit.SelectedIndex = -1;

            AddBtn.Show();
            UpdateBtn.Hide();
            DeleteBtn.Hide();
            CancelBtn.Hide();
        }

        private void TrackInvoicesBtn_Click(object sender, EventArgs e)
        {
            FrmTrackInvoices frmTrackInvoices = new FrmTrackInvoices();
            frmTrackInvoices.ShowDialog();
        }

        private void ManageProfileBtn_Click(object sender, EventArgs e)
        {
            FrmManageProfile frmManageProfile = new FrmManageProfile(AdminId);
            frmManageProfile.ShowDialog();
            LoadAdminDetails();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Show the login form again
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();

                // Close this main form
                this.Close();
            }
        }

        private void ManageShopBtn_Click(object sender, EventArgs e)
        {
            FrmManageShop frmManageShop = new FrmManageShop();
            frmManageShop.ShowDialog();

            LoadShopDetails();
        }
    }
}
