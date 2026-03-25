using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Invoice_Generator
{
    public partial class FrmTrackInvoices : Form
    {
        string cs = System.Configuration.ConfigurationManager
                     .ConnectionStrings["dbcs"].ConnectionString;

        // This will hold currently loaded data
        DataTable currentInvoicesTable = new DataTable();

        public FrmTrackInvoices()
        {
            InitializeComponent();
        }

        private void FrmTrackInvoices_Load(object sender, EventArgs e)
        {
            TxtInvoiceId.Hide();
            TxtInvoiceNumber.Hide();
            PrintInvoiceBtn.Hide();

            LoadAllInvoices();
        }

        // ===============================
        // LOAD ALL INVOICES
        // ===============================
        private void LoadAllInvoices()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT * FROM Invoices";

                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    currentInvoicesTable = new DataTable();
                    da.Fill(currentInvoicesTable);

                    InvoicesGridView.DataSource = currentInvoicesTable;
                }
            }
        }

        // ===============================
        // DATE FILTER BUTTON
        // ===============================
        private void DateFilterInvoicesBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                DateTime fromDate = FromDateDTPicker.Value.Date;
                DateTime toDate = ToDateDTPicker.Value.Date.AddDays(1);

                string query = @"SELECT * FROM Invoices
                                 WHERE InvoiceDateTime >= @FromDate
                                 AND InvoiceDateTime < @ToDate";

                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@FromDate", fromDate);
                    da.SelectCommand.Parameters.AddWithValue("@ToDate", toDate);

                    currentInvoicesTable = new DataTable();
                    da.Fill(currentInvoicesTable);

                    InvoicesGridView.DataSource = currentInvoicesTable;
                }
            }

            ApplySearchFilter(); // Apply search if text already exists
        }

        // ===============================
        // SEARCH TEXTBOX (INDEPENDENT)
        // ===============================
        private void TxtSearchInvoice_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }

        // ===============================
        // APPLY SEARCH ON CURRENT DATA
        // ===============================
        private void ApplySearchFilter()
        {
            if (currentInvoicesTable == null) return;

            DataView dv = currentInvoicesTable.DefaultView;

            if (string.IsNullOrWhiteSpace(TxtSearchInvoice.Text))
            {
                dv.RowFilter = "";
            }
            else
            {
                string search = TxtSearchInvoice.Text.Trim().Replace("'", "''");

                dv.RowFilter = $"InvoiceNumber LIKE '%{search}%' " +
                               $"OR CustomerName LIKE '%{search}%'";
            }

            InvoicesGridView.DataSource = dv;
        }

        // ===============================
        // ROW CLICK
        // ===============================
        private void InvoicesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (InvoicesGridView.CurrentRow != null)
            {
                TxtInvoiceId.Text = InvoicesGridView.CurrentRow.Cells[0].Value.ToString();
                TxtInvoiceNumber.Text = InvoicesGridView.CurrentRow.Cells[1].Value.ToString();

                TxtInvoiceId.Show();
                TxtInvoiceNumber.Show();
                PrintInvoiceBtn.Show();

                LoadInvoiceItems();
            }
        }

        // ===============================
        // LOAD INVOICE ITEMS
        // ===============================
        private void LoadInvoiceItems()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT * FROM InvoiceItems WHERE InvId = @InvId";

                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@InvId",
                        int.Parse(TxtInvoiceId.Text));

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    InvoiceItemsGridView.DataSource = dt;
                }
            }
        }

        // ===============================
        // PRINT
        // ===============================
        private void PrintInvoiceBtn_Click(object sender, EventArgs e)
        {
            int invoiceId = int.Parse(TxtInvoiceId.Text);
            FrmInvoice frmInvoice = new FrmInvoice(invoiceId);
            frmInvoice.ShowDialog();
        }
    }
}