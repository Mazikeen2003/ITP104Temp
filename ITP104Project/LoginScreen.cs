using GlobalVariables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP104Project
{
    public partial class LoginScreen : Form
    {
        public DashformScreen dashformScreenTemp = null;
        public LoginScreen(DashformScreen dashform)
        {
            InitializeComponent();
            dashformScreenTemp = dashform;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0) {
                //validate user information here later

                Globals.cond = true;
                this.Close();

            }
            else
            {
                MessageBox.Show("Please fill in all the fields.");
            }
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            if (!GlobalVariables.Globals.cond)
            {
                //e.Cancel = true;
                //this.Hide();
                //dashformScreenTemp.Close();
               
              
            }
        }
    }
}
