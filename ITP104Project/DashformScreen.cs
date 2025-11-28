using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobalVariables;

namespace ITP104Project
{
    public partial class DashformScreen : Form
    {
        Boolean shouldHide = false;
        public DashformScreen(Boolean condition)
        {

            InitializeComponent();
            
            LoginScreen loginscreen = new LoginScreen(this);

            loginscreen.ShowDialog();

            shouldHide = condition;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void DashformScreen_Load(object sender, EventArgs e)
        {
            if (!GlobalVariables.Globals.cond)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
                

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnScanOverview_Click(object sender, EventArgs e)
        {
            //show scan screen
            ScanScreen scanScreen = new ScanScreen(this);
            this.Hide();
            scanScreen.ShowDialog();

            if (!GlobalVariables.Globals.cond)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btntUserInformation_Click(object sender, EventArgs e)
        {
            //show user screen
            UserScreen userScreen = new UserScreen(this);
            this.Hide();
            userScreen.ShowDialog();

            if (!GlobalVariables.Globals.cond)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
