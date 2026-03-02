using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dess
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            //Get username and password from the textboxes, remove extra spaces
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            //Check if username or password is empty
            if(username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password");
                return; // stop the login process/program
            }
            //Call the DBconnection string
            DBConnect db = new DBConnect();

            try
            {
              db.Open();// Open database connection
                //SQL QUERY to count matching username and password
                string query = "SELECT COUNT(*) FROM users WHERE username=@username AND password=@password";

                //Create my SQL command
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
                //Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                //Execute query and get results
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    //if 1 record found, login successful
               
                    MessageBox.Show("Login Successful");
                    //Open DashBoard
                    dashboard dashboard = new dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    //no match found
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            catch (Exception ex)
            {
                // show error message if something goes wrong
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close(); //Close database connection
            }


            
        }
    }
}
