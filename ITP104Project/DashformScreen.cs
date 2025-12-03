using GlobalVariables;
using MySql.Data.MySqlClient;    // MySQL client library
//using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;  // Needed for rounded corners
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        // ---------------------------
        // ROUNDED CONTROL FUNCTION
        // ---------------------------
        private void RoundControl(Control ctrl, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(ctrl.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(ctrl.Width - radius, ctrl.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, ctrl.Height - radius, radius, radius), 90, 90);

            path.CloseFigure();
            ctrl.Region = new Region(path);
            ctrl.Refresh();
        }

        // ---------------------------
        // LOAD STUDENT INFO FROM MySQL DATABASE
        // ---------------------------
        private void LoadStudentInfo()
        {
            string connectionString = "server=localhost;port=3306;database=tempdb;uid=root;pwd=;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT fullname, age, address FROM tempUser LIMIT 1;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                dbName.Text = reader["fullname"].ToString();
                                dbAge.Text = reader["age"].ToString();
                                dbAddress.Text = reader["address"].ToString();
                            }
                            else
                            {
                                dbName.Text = "No Record";
                                dbAge.Text = "No Record";
                                dbAddress.Text = "No Record";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }

        // ---------------------------
        // FORM LOAD
        // ---------------------------
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

            // ---------------------------
            // ROUND PANELS
            // ---------------------------
            RoundControl(panel2, 25);
            RoundControl(panel3, 25);
            RoundControl(panel4, 25);

            // ---------------------------
            // ROUND BUTTONS
            // ---------------------------
            RoundControl(scanID, 20);
            RoundControl(studentRecord, 20);
            RoundControl(scanHistory, 20);
            RoundControl(settings, 20);
            RoundControl(logOut, 20);

            // ---------------------------
            // FIX BUTTON APPEARANCE
            // ---------------------------
            scanID.FlatStyle = FlatStyle.Flat;
            scanID.FlatAppearance.BorderSize = 0;

            studentRecord.FlatStyle = FlatStyle.Flat;
            studentRecord.FlatAppearance.BorderSize = 0;

            scanHistory.FlatStyle = FlatStyle.Flat;
            scanHistory.FlatAppearance.BorderSize = 0;
            
            settings.FlatStyle = FlatStyle.Flat;
            settings.FlatAppearance.BorderSize = 0;

            logOut.FlatStyle = FlatStyle.Flat;
            logOut.FlatAppearance.BorderSize = 1;

            // ---------------------------
            // AUTO RE-ROUND ON RESIZE
            // ---------------------------
            panel2.Resize += (s, ev) => RoundControl(panel2, 25);
            panel3.Resize += (s, ev) => RoundControl(panel3, 25);
            panel4.Resize += (s, ev) => RoundControl(panel4, 25);

            scanID.Resize += (s, ev) => RoundControl(scanID, 20);
            studentRecord.Resize += (s, ev) => RoundControl(studentRecord, 20);
            scanHistory.Resize += (s, ev) => RoundControl(scanHistory, 20);
            settings.Resize += (s, ev) => RoundControl(settings, 20);

            // ---------------------------
            // LOAD DATABASE INFO INTO LABELS
            // ---------------------------
            LoadStudentInfo();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }

        private void btnScanOverview_Click(object sender, EventArgs e)
        {
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

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void btntUserInformation_Click(object sender, EventArgs e)
        {
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

        private void label3_Click(object sender, EventArgs e) { }
        private void label3_Click_1(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void button5_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label2_Click_1(object sender, EventArgs e) { }
        private void label3_Click_2(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
    }
}
