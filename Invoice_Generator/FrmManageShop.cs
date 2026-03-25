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
    public partial class FrmManageShop : Form
    {
        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        bool imageChanged = false;
        public FrmManageShop()
        {
            InitializeComponent();
        }

        private void FrmManageShop_Load(object sender, EventArgs e)
        {
            GroupBox.Hide();
            LoadShopDetails();
        }

        private void LoadShopDetails()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "Select * from Shop Where ShopId = 1";

                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
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

                            // Put data in update form group fields also
                            TxtShopName.Text = dr["Name"].ToString();
                            TxtShopAddress.Text = dr["Address"].ToString();
                            TxtShopPhone1.Text = dr["Phone1"].ToString();
                            TxtShopPhone2.Text = dr["Phone2"].ToString();
                            TxtShopCurrency.Text = dr["Currency"].ToString();

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
                                            SelectShopImage.Image = Image.FromStream(ms);
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

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            GroupBox.Show();
        }

        private void BrowsePictureBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Shop Image";
            ofd.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.bmp;*.gif)|*.png;*.jpg;*.jpeg;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            { 
                SelectShopImage.Image = new Bitmap(ofd.FileName);
                SelectShopImage.SizeMode = PictureBoxSizeMode.StretchImage;

                imageChanged = true;
            }
        }

        public byte[] UpdateImg()
        {
            MemoryStream ms = new MemoryStream();
            SelectShopImage.Image.Save(ms, SelectShopImage.Image.RawFormat);

            // return ms.GetBuffer();
            return ms.ToArray();
        }

        private void UpdateShopDetailsBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                string query;

                if (imageChanged)
                {
                    query = "Update Shop set Name=@name, Address=@address, Phone1=@phone1, Phone2=@phone2, Image=@img, Currency=@currency where ShopId=@shid";
                }
                else
                {
                    query = "Update Shop set Name=@name, Address=@address, Phone1=@phone1, Phone2=@phone2, Currency=@currency where ShopId=@shid";
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", TxtShopName.Text);
                    cmd.Parameters.AddWithValue("@address", TxtShopAddress.Text);
                    cmd.Parameters.AddWithValue("@phone1", TxtShopPhone1.Text);
                    cmd.Parameters.AddWithValue("@phone2", TxtShopPhone2.Text);
                    cmd.Parameters.AddWithValue("@currency", TxtShopCurrency.Text);
                    cmd.Parameters.AddWithValue("@shid", 1);

                    if (imageChanged)
                    {
                        cmd.Parameters.AddWithValue("@img", UpdateImg());
                    }

                    int check = cmd.ExecuteNonQuery();

                    if (check > 0)
                    {
                        MessageBox.Show("Shop Details Updated Successfully!");
                        LoadShopDetails();
                        imageChanged = false;
                    }
                    else
                    {
                        MessageBox.Show("Failed To Update Shop Details");
                    }
                }
            }
        }
    }
}
