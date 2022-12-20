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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

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

        }
    }
    }
