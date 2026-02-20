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

namespace FINAL_PROJECT
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != String.Empty && txtPassword.Text != String.Empty)
            {
                SqlConnection con = new SqlConnection("Data Source=VICTUS\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True;Encrypt=False"); 
                string Username = txtUsername.Text;
                string Password = txtPassword.Text;
                con.Open();
                String query = "Select * From Login_Table";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {

                    if (reader.GetValue(0).ToString() == Username && reader.GetValue(1).ToString() == Password)
                    {
                        count++;
                        MessageBox.Show("Login Successful", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        StudentRegister frm = new StudentRegister();
                        this.Hide();
                        frm.Show();
                    }

                }
                con.Close();
                if (count == 0) { MessageBox.Show("Invalid Login Credentials, Please Check Username and Password and try again", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error); };
            }
            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            {
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();  
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Are you sure, Do you really want to exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
            
        }
        
    }
}
