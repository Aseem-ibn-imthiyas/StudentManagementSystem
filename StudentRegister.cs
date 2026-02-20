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
    public partial class StudentRegister : Form
    {
        public StudentRegister()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=VICTUS\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True;Encrypt=False");

        private void linklblexit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void linklbllogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to Logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                this.Close();  
                Login form1 = new Login();
                form1.Show();
            }
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string query = "INSERT INTO Registration (firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, ParentcontactNo) " +
                               "VALUES (@firstName, @lastName, @dob, @gender, @address, @email, @mobilePhone, @homePhone, @parentName, @nic, @contactNo)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@firstName", txtfirstname.Text);
                cmd.Parameters.AddWithValue("@lastName", txtlastname.Text);
                cmd.Parameters.AddWithValue("@dob", dtpdateofbirth.Value);
                cmd.Parameters.AddWithValue("@gender", radiobtnmale.Checked ? "Male" : "Female");
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@mobilePhone", txtmobileno.Text);
                cmd.Parameters.AddWithValue("@homePhone", txthomephone.Text);
                cmd.Parameters.AddWithValue("@parentName", txtparentname.Text);
                cmd.Parameters.AddWithValue("@nic", txtnic.Text);
                cmd.Parameters.AddWithValue("@contactNo", txtcontactnumparent.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Added Successfully", "Register Student",MessageBoxButtons.OK,MessageBoxIcon.Information);

                
                LoadRegNoData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();

                string query = "UPDATE Registration SET FirstName = @firstName, LastName = @lastName, DateOfBirth = @dob, Gender = @gender, " +
                               "Address = @address, Email = @email, MobilePhone = @mobilePhone, HomePhone = @homePhone, " +
                               "ParentName = @parentName, Nic = @nic, ParentContactNo = @contactNo WHERE RegNo = @regNo";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@firstName", txtfirstname.Text);
                cmd.Parameters.AddWithValue("@lastName", txtlastname.Text);
                cmd.Parameters.AddWithValue("@dob", dtpdateofbirth.Value);
                cmd.Parameters.AddWithValue("@gender", radiobtnmale.Checked ? "Male" : "Female");
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@mobilePhone", txtmobileno.Text);
                cmd.Parameters.AddWithValue("@homePhone", txthomephone.Text);
                cmd.Parameters.AddWithValue("@parentName", txtparentname.Text);
                cmd.Parameters.AddWithValue("@nic", txtnic.Text);
                cmd.Parameters.AddWithValue("@contactNo", txtcontactnumparent.Text);
                cmd.Parameters.AddWithValue("@regNo", int.Parse(cmbboxregno.SelectedItem.ToString()));

                int rowsAffected = cmd.ExecuteNonQuery();
                MessageBox.Show(rowsAffected > 0 ? "Record Updated Successfully" : "No record found with the given Registration Number.","Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);



                LoadRegNoData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure, Do you really want to delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result != DialogResult.Yes)
                {
                    return;
                }

                string regNo = cmbboxregno.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(regNo))
                {
                    MessageBox.Show("Please select a registration number to delete.");
                    return;
                }

                string query = "DELETE FROM Registration WHERE regNo = @regNo";
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@regNo", regNo);
                int rowsAffected = cmd.ExecuteNonQuery();

                MessageBox.Show(rowsAffected > 0 ? "Record Deleted successfully" : "No record found for the selected registration number.","Delete Student",MessageBoxButtons.OK,MessageBoxIcon.Information);

                
                LoadRegNoData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cmbboxregno.Text = string.Empty;
            txtfirstname.Clear();
            txtlastname.Clear();
            txtaddress.Clear();
            txtemail.Clear();
            txtmobileno.Clear();
            txthomephone.Clear();
            txtparentname.Clear();
            txtnic.Clear();
            txtcontactnumparent.Clear();
            dtpdateofbirth.Value = DateTime.Now;
            radiobtnmale.Checked = true;
            radiobtnfemale.Checked = false;

            MessageBox.Show("Form cleared successfully!");

            
            LoadRegNoData();
        }

        private void cmbboxregno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbboxregno.SelectedItem == null)
                {
                    MessageBox.Show("Please select a registration number.");
                    return;
                }

                string regno = cmbboxregno.SelectedItem.ToString();
                string query = "SELECT * FROM Registration WHERE RegNo = @regNo";
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@regNo", regno);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader["dateOfBirth"] != DBNull.Value)
                        {
                            dtpdateofbirth.Value = (DateTime)reader["dateOfBirth"];
                        }
                        else
                        {
                            dtpdateofbirth.Value = DateTime.Now;  
                        }

                        string gender = reader["gender"].ToString();
                        if (string.Equals(gender, "Female", StringComparison.OrdinalIgnoreCase))
                        {
                            radiobtnfemale.Checked = true;
                        }
                        else if (string.Equals(gender, "Male", StringComparison.OrdinalIgnoreCase))
                        {
                            radiobtnmale.Checked = true;
                        }

                        txtfirstname.Text = reader["FirstName"].ToString();

                        txtlastname.Text = reader["LastName"].ToString();

                        txtaddress.Text = reader["Address"].ToString();

                        txtemail.Text = reader["Email"].ToString();

                        txtmobileno.Text = reader["MobilePhone"].ToString();

                        txthomephone.Text = reader["HomePhone"].ToString();

                        txtparentname.Text = reader["ParentName"].ToString();

                        txtnic.Text = reader["Nic"].ToString();

                        txtcontactnumparent.Text = reader["ParentContactNo"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No record found for the selected registration number.");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                
                conn.Open();

                
                string query = "SELECT regNo FROM Registration";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                
                cmbboxregno.Items.Clear();

                
                while (reader.Read())
                {
                    cmbboxregno.Items.Add(reader["regNo"].ToString());
                }

                reader.Close();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void LoadRegNoData()
        {
            
            using (SqlConnection newConn = new SqlConnection("Data Source=VICTUS\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True;Encrypt=False"))
            {
                try
                {
                    newConn.Open();

                    string query = "SELECT regNo FROM Registration";
                    SqlCommand cmd = new SqlCommand(query, newConn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbboxregno.Items.Clear();

                    while (reader.Read())
                    {
                        cmbboxregno.Items.Add(reader["regNo"].ToString());
                    }

                    reader.Close();
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Database error: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
