using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginSmartHome
{
    public partial class signup : Form  
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;

        public signup()
        {
            InitializeComponent();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
              if (passinput.Text == "" || passinput2.Text == "" || newuser.Text == "" || agecollection.Text == "")
               {
                   MessageBox.Show("Please enter values");
                   passinput.Focus();
                   return;
               }
               else if (passinput.Text != passinput2.Text)
               {
                   MessageBox.Show("Password not matching");
                   passinput2.Focus();
                   return;
               }
               else if (passinput.Text == passinput2.Text && passinput.Text != "" && passinput2.Text != "" && newuser.Text != "" && agecollection.SelectedValue != "")
               {
                   MessageBox.Show("Signed up succesfully...Welcome!");
               }

   
            if (string.IsNullOrEmpty(newuser.Text) || string.IsNullOrEmpty(passinput.Text) || string.IsNullOrEmpty(passinput2.Text) || string.IsNullOrEmpty(agecollection.Text))
            {
                MessageBox.Show("Please input all required fields", "Error");
            }

            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM smarthome.newuserinfo WHERE Username = '" + newuser.Text + "';";
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    MessageBox.Show("Username not available!");

                }
                else
                {

                    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=smarthome;";
                    string iquery = "INSERT INTO newuserinfo(`ID`,`username`,`Age`, `password`, `ConfirmPassword`) VALUES (NULL, '" + newuser.Text + "', '" + agecollection.Text + "', '" + passinput.Text + "', '" + passinput2.Text + "')";

                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, databaseConnection);
                    commandDatabase.CommandTimeout = 60;

                    try
                    {
                        databaseConnection.Open();
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                        databaseConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Account Successfully Created!");
                }

                connection.Close();
            
            }

        }

    


        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked)
            {

                this.passinput.UseSystemPasswordChar = false;
                this.passinput2.UseSystemPasswordChar = false;
                this.showpassword.Text = "Hide Password";
            }
            else
            {
                this.passinput.UseSystemPasswordChar = true;
                this.passinput2.UseSystemPasswordChar = true;
                this.showpassword.Text = "Show Password";
            }
        }

        private void passinput2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            Visible = false;
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void agecollection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
