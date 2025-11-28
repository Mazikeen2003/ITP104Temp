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
    public partial class ScanHistoryScreen : Form
    {
        public DashformScreen dashformnTemp = null;
        Boolean closeApp = true;
        public ScanHistoryScreen(DashformScreen dashform)
        {
            InitializeComponent();
            dashformnTemp = dashform;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ScanHistoryScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeApp)
            {
                GlobalVariables.Globals.cond = false;
                this.Hide();
            }
            else
            {
                this.Hide();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            closeApp = false;
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ScanHistoryScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
