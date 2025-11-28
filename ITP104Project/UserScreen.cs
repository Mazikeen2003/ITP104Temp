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
    public partial class UserScreen : Form
    {
        public DashformScreen dashformnTemp = null;
        Boolean closeApp = true;
        public UserScreen(DashformScreen dashform)
        {
            InitializeComponent();
            dashformnTemp = dashform;
        }

        private void UserScreen_Load(object sender, EventArgs e)
        {

        }

        private void UserScreen_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
