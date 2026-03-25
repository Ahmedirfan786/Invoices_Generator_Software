using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_Generator
{
    public partial class FrmManageProfile : Form
    {
        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        int AdminId;
        public FrmManageProfile(int adminId)
        {
            InitializeComponent();
            AdminId = adminId;
        }

        private void FrmManageProfile_Load(object sender, EventArgs e)
        {
            LoadAdminDetails();
        }

        public void LoadAdminDetails() 
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "Select UserName, Password From Admins Where AdminId = @adminid";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(query,con))
                {
                    cmd.Parameters.AddWithValue("@adminid", AdminId);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        dr.Read();
                        TxtUserName.Text = dr["UserName"].ToString();
                        TxtPassword.Text = dr["Password"].ToString();
                    }
                }
                con.Close();
            }
        }

        private void UpdateProfileBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TxtUserName.Text) || String.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                MessageBox.Show("Please Fill the Required Fields !");
            }
            else 
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    string query = "Update Admins Set UserName = @uname, Password = @pass Where AdminId = @adminid";

                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("uname", TxtUserName.Text);
                        cmd.Parameters.AddWithValue("pass", TxtPassword.Text);
                        cmd.Parameters.AddWithValue("adminid", AdminId);

                        int check = cmd.ExecuteNonQuery();

                        if (check > 0)
                        {
                            MessageBox.Show("Profile Updated Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Failed To Update Profile");
                        }
                    }

                    con.Close();
                }
            }
        }
    }
}
