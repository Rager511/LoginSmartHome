using Guna.UI2.WinForms;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSmartHome
{
    public partial class Login : Form
    {
        private object guna2TextBox1;

        public Login()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Chip1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

           
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

 

        private void label2_Click_1(object sender, EventArgs e)
        {
           
        }

       

    
        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2GradientButton2_Click_1(object sender, EventArgs e)
        {
            signup su = new signup();
            su.Show();
            Visible = false;
        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            
             if (showpassword.Checked)
             {
                
                this.pass_input.UseSystemPasswordChar = false;
                this.showpassword.Text = "Hide Password";
             }
             else
             {
                this.pass_input.UseSystemPasswordChar = true;
                this.showpassword.Text = "Show Password";

             }
          
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
