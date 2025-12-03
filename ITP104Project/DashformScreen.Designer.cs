namespace ITP104Project
{
    partial class DashformScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scanID = new System.Windows.Forms.Button();
            this.scanHistory = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dbAddress = new System.Windows.Forms.Label();
            this.dbAge = new System.Windows.Forms.Label();
            this.dbName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.studentRecord = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(105)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.logOut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1926, 76);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(105)))), ((int)(((byte)(38)))));
            this.logOut.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.logOut.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logOut.Location = new System.Drawing.Point(1892, 12);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(124, 53);
            this.logOut.TabIndex = 12;
            this.logOut.Text = "Logout";
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Dashboard";
            // 
            // scanID
            // 
            this.scanID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(105)))), ((int)(((byte)(38)))));
            this.scanID.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scanID.Location = new System.Drawing.Point(42, 192);
            this.scanID.Name = "scanID";
            this.scanID.Size = new System.Drawing.Size(215, 82);
            this.scanID.TabIndex = 8;
            this.scanID.Text = "Scan ID";
            this.scanID.UseVisualStyleBackColor = false;
            this.scanID.Click += new System.EventHandler(this.button1_Click);
            // 
            // scanHistory
            // 
            this.scanHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(105)))), ((int)(((byte)(38)))));
            this.scanHistory.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scanHistory.Location = new System.Drawing.Point(42, 478);
            this.scanHistory.Name = "scanHistory";
            this.scanHistory.Size = new System.Drawing.Size(215, 76);
            this.scanHistory.TabIndex = 10;
            this.scanHistory.Text = "Scan History";
            this.scanHistory.UseVisualStyleBackColor = false;
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(105)))), ((int)(((byte)(38)))));
            this.settings.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settings.Location = new System.Drawing.Point(42, 609);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(215, 79);
            this.settings.TabIndex = 11;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.dbAddress);
            this.panel2.Controls.Add(this.dbAge);
            this.panel2.Controls.Add(this.dbName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.name);
            this.panel2.Location = new System.Drawing.Point(344, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 323);
            this.panel2.TabIndex = 12;
            // 
            // dbAddress
            // 
            this.dbAddress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dbAddress.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dbAddress.Location = new System.Drawing.Point(296, 247);
            this.dbAddress.Name = "dbAddress";
            this.dbAddress.Size = new System.Drawing.Size(506, 49);
            this.dbAddress.TabIndex = 6;
            this.dbAddress.Text = "Name: ";
            // 
            // dbAge
            // 
            this.dbAge.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dbAge.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbAge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dbAge.Location = new System.Drawing.Point(296, 175);
            this.dbAge.Name = "dbAge";
            this.dbAge.Size = new System.Drawing.Size(506, 49);
            this.dbAge.TabIndex = 5;
            this.dbAge.Text = "Name: ";
            // 
            // dbName
            // 
            this.dbName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dbName.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dbName.Location = new System.Drawing.Point(296, 100);
            this.dbName.Name = "dbName";
            this.dbName.Size = new System.Drawing.Size(506, 49);
            this.dbName.TabIndex = 4;
            this.dbName.Text = "Name: ";
            this.dbName.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(104, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 49);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address: ";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(104, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 49);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age: ";
            this.label3.Click += new System.EventHandler(this.label3_Click_2);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(104, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name: ";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.name.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name.Location = new System.Drawing.Point(181, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(359, 49);
            this.name.TabIndex = 0;
            this.name.Text = "User Information";
            this.name.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lblDepartment);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(1432, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(566, 323);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Location = new System.Drawing.Point(344, 562);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1659, 428);
            this.panel4.TabIndex = 13;
            // 
            // studentRecord
            // 
            this.studentRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(105)))), ((int)(((byte)(38)))));
            this.studentRecord.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentRecord.Location = new System.Drawing.Point(42, 337);
            this.studentRecord.Name = "studentRecord";
            this.studentRecord.Size = new System.Drawing.Size(215, 79);
            this.studentRecord.TabIndex = 9;
            this.studentRecord.Text = "Student Record";
            this.studentRecord.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(31, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 49);
            this.label6.TabIndex = 8;
            this.label6.Text = "Department:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(31, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 49);
            this.label7.TabIndex = 9;
            this.label7.Text = "Status:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDepartment.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDepartment.Location = new System.Drawing.Point(316, 107);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(506, 49);
            this.lblDepartment.TabIndex = 7;
            this.lblDepartment.Text = "No record";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(316, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(506, 49);
            this.label8.TabIndex = 7;
            this.label8.Text = "No Record";
            // 
            // DashformScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1924, 840);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.scanHistory);
            this.Controls.Add(this.studentRecord);
            this.Controls.Add(this.scanID);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashformScreen";
            this.Text = "DashformScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashformScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button scanID;
        private System.Windows.Forms.Button scanHistory;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button studentRecord;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dbName;
        private System.Windows.Forms.Label dbAge;
        private System.Windows.Forms.Label dbAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}