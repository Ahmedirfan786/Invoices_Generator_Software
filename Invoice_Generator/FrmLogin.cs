using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Invoice_Generator
{
    public partial class FrmLogin : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public FrmLogin()
        {
            InitializeComponent();
        }



        private void LoginBtn_Click(object sender, EventArgs e)
        {
            int AdminId = 0;

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT AdminId FROM Admins WHERE Username=@uname AND Password=@pass";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@uname", TxtUserName.Text);
                cmd.Parameters.AddWithValue("@pass", TxtPassword.Text);

                con.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    AdminId = Convert.ToInt32(result);

                    MessageBox.Show("Login Successful");

                    FrmMain frmMain = new FrmMain(AdminId);
                    frmMain.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                }
            }
        }
    }
}
