namespace Project_Hospital
{
    partial class frmSecretaryUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecretaryUI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_SSN = new System.Windows.Forms.Label();
            this.lbl_AllName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtxt_Announcement = new System.Windows.Forms.RichTextBox();
            this.btn_SendAnnounc = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_MakeAppoint = new System.Windows.Forms.Button();
            this.cb_State = new System.Windows.Forms.CheckBox();
            this.mtxt_SSN = new System.Windows.Forms.MaskedTextBox();
            this.cbx_Doctor = new System.Windows.Forms.ComboBox();
            this.cbx_Department = new System.Windows.Forms.ComboBox();
            this.mtxt_Time = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_Date = new System.Windows.Forms.MaskedTextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_AnnouncementList = new System.Windows.Forms.Button();
            this.btn_DepartmentPanel = new System.Windows.Forms.Button();
            this.btn_AppointmentList = new System.Windows.Forms.Button();
            this.btn_DoctorPanel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_SSN);
            this.groupBox1.Controls.Add(this.lbl_AllName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secretary Information";
            // 
            // lbl_SSN
            // 
            this.lbl_SSN.AutoSize = true;
            this.lbl_SSN.Location = new System.Drawing.Point(22, 50);
            this.lbl_SSN.Name = "lbl_SSN";
            this.lbl_SSN.Size = new System.Drawing.Size(67, 32);
            this.lbl_SSN.TabIndex = 1;
            this.lbl_SSN.Text = "SSN";
            // 
            // lbl_AllName
            // 
            this.lbl_AllName.AutoSize = true;
            this.lbl_AllName.Location = new System.Drawing.Point(22, 99);
            this.lbl_AllName.Name = "lbl_AllName";
            this.lbl_AllName.Size = new System.Drawing.Size(209, 32);
            this.lbl_AllName.TabIndex = 0;
            this.lbl_AllName.Text = "Name Surname";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtxt_Announcement);
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 439);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Make Announcement";
            // 
            // rtxt_Announcement
            // 
            this.rtxt_Announcement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_Announcement.Location = new System.Drawing.Point(3, 35);
            this.rtxt_Announcement.Name = "rtxt_Announcement";
            this.rtxt_Announcement.Size = new System.Drawing.Size(439, 401);
            this.rtxt_Announcement.TabIndex = 0;
            this.rtxt_Announcement.Text = "";
            // 
            // btn_SendAnnounc
            // 
            this.btn_SendAnnounc.Location = new System.Drawing.Point(348, 634);
            this.btn_SendAnnounc.Name = "btn_SendAnnounc";
            this.btn_SendAnnounc.Size = new System.Drawing.Size(109, 42);
            this.btn_SendAnnounc.TabIndex = 2;
            this.btn_SendAnnounc.Text = "Send";
            this.btn_SendAnnounc.UseVisualStyleBackColor = true;
            this.btn_SendAnnounc.Click += new System.EventHandler(this.btn_SendAnnounc_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_MakeAppoint);
            this.groupBox3.Controls.Add(this.cb_State);
            this.groupBox3.Controls.Add(this.mtxt_SSN);
            this.groupBox3.Controls.Add(this.cbx_Doctor);
            this.groupBox3.Controls.Add(this.cbx_Department);
            this.groupBox3.Controls.Add(this.mtxt_Time);
            this.groupBox3.Controls.Add(this.mtxt_Date);
            this.groupBox3.Controls.Add(this.txt_Id);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(463, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(526, 661);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment Panel";
            // 
            // btn_MakeAppoint
            // 
            this.btn_MakeAppoint.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_MakeAppoint.Location = new System.Drawing.Point(239, 474);
            this.btn_MakeAppoint.Name = "btn_MakeAppoint";
            this.btn_MakeAppoint.Size = new System.Drawing.Size(158, 70);
            this.btn_MakeAppoint.TabIndex = 13;
            this.btn_MakeAppoint.Text = "Make an Appointment";
            this.btn_MakeAppoint.UseVisualStyleBackColor = true;
            this.btn_MakeAppoint.Click += new System.EventHandler(this.btn_MakeAppoint_Click);
            // 
            // cb_State
            // 
            this.cb_State.AutoSize = true;
            this.cb_State.Location = new System.Drawing.Point(239, 403);
            this.cb_State.Name = "cb_State";
            this.cb_State.Size = new System.Drawing.Size(104, 36);
            this.cb_State.TabIndex = 12;
            this.cb_State.Text = "State";
            this.cb_State.UseVisualStyleBackColor = true;
            // 
            // mtxt_SSN
            // 
            this.mtxt_SSN.Location = new System.Drawing.Point(239, 337);
            this.mtxt_SSN.Mask = "0000000000";
            this.mtxt_SSN.Name = "mtxt_SSN";
            this.mtxt_SSN.Size = new System.Drawing.Size(222, 39);
            this.mtxt_SSN.TabIndex = 11;
            // 
            // cbx_Doctor
            // 
            this.cbx_Doctor.FormattingEnabled = true;
            this.cbx_Doctor.Location = new System.Drawing.Point(239, 289);
            this.cbx_Doctor.Name = "cbx_Doctor";
            this.cbx_Doctor.Size = new System.Drawing.Size(222, 40);
            this.cbx_Doctor.TabIndex = 10;
            // 
            // cbx_Department
            // 
            this.cbx_Department.FormattingEnabled = true;
            this.cbx_Department.Location = new System.Drawing.Point(239, 239);
            this.cbx_Department.Name = "cbx_Department";
            this.cbx_Department.Size = new System.Drawing.Size(222, 40);
            this.cbx_Department.TabIndex = 9;
            this.cbx_Department.SelectedIndexChanged += new System.EventHandler(this.cbx_Department_SelectedIndexChanged);
            // 
            // mtxt_Time
            // 
            this.mtxt_Time.Location = new System.Drawing.Point(239, 183);
            this.mtxt_Time.Mask = "00:00";
            this.mtxt_Time.Name = "mtxt_Time";
            this.mtxt_Time.Size = new System.Drawing.Size(222, 39);
            this.mtxt_Time.TabIndex = 8;
            this.mtxt_Time.ValidatingType = typeof(System.DateTime);
            // 
            // mtxt_Date
            // 
            this.mtxt_Date.Location = new System.Drawing.Point(239, 132);
            this.mtxt_Date.Mask = "00/00/0000";
            this.mtxt_Date.Name = "mtxt_Date";
            this.mtxt_Date.Size = new System.Drawing.Size(222, 39);
            this.mtxt_Date.TabIndex = 7;
            this.mtxt_Date.ValidatingType = typeof(System.DateTime);
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(239, 74);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(222, 39);
            this.txt_Id.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 32);
            this.label8.TabIndex = 5;
            this.label8.Text = "SSN :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "Doctor :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Department :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Time :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(995, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(491, 436);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Department";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(485, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(998, 451);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(491, 436);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doctor";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 35);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(485, 398);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.btn_AnnouncementList);
            this.groupBox6.Controls.Add(this.btn_DepartmentPanel);
            this.groupBox6.Controls.Add(this.btn_AppointmentList);
            this.groupBox6.Controls.Add(this.btn_DoctorPanel);
            this.groupBox6.Location = new System.Drawing.Point(15, 679);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(977, 205);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = " ";
            // 
            // btn_AnnouncementList
            // 
            this.btn_AnnouncementList.Location = new System.Drawing.Point(333, 126);
            this.btn_AnnouncementList.Name = "btn_AnnouncementList";
            this.btn_AnnouncementList.Size = new System.Drawing.Size(256, 48);
            this.btn_AnnouncementList.TabIndex = 3;
            this.btn_AnnouncementList.Text = "Announcements";
            this.btn_AnnouncementList.UseVisualStyleBackColor = true;
            this.btn_AnnouncementList.Click += new System.EventHandler(this.btn_AnnouncementList_Click);
            // 
            // btn_DepartmentPanel
            // 
            this.btn_DepartmentPanel.Location = new System.Drawing.Point(333, 38);
            this.btn_DepartmentPanel.Name = "btn_DepartmentPanel";
            this.btn_DepartmentPanel.Size = new System.Drawing.Size(256, 67);
            this.btn_DepartmentPanel.TabIndex = 2;
            this.btn_DepartmentPanel.Text = "Department Panel";
            this.btn_DepartmentPanel.UseVisualStyleBackColor = true;
            this.btn_DepartmentPanel.Click += new System.EventHandler(this.btn_DepartmentPanel_Click);
            // 
            // btn_AppointmentList
            // 
            this.btn_AppointmentList.Location = new System.Drawing.Point(653, 38);
            this.btn_AppointmentList.Name = "btn_AppointmentList";
            this.btn_AppointmentList.Size = new System.Drawing.Size(256, 67);
            this.btn_AppointmentList.TabIndex = 1;
            this.btn_AppointmentList.Text = "Appointment List";
            this.btn_AppointmentList.UseVisualStyleBackColor = true;
            this.btn_AppointmentList.Click += new System.EventHandler(this.btn_AppointmentList_Click);
            // 
            // btn_DoctorPanel
            // 
            this.btn_DoctorPanel.Location = new System.Drawing.Point(25, 38);
            this.btn_DoctorPanel.Name = "btn_DoctorPanel";
            this.btn_DoctorPanel.Size = new System.Drawing.Size(256, 67);
            this.btn_DoctorPanel.TabIndex = 0;
            this.btn_DoctorPanel.Text = "Doctor Panel";
            this.btn_DoctorPanel.UseVisualStyleBackColor = true;
            this.btn_DoctorPanel.Click += new System.EventHandler(this.btn_DoctorPanel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSecretaryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1511, 912);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_SendAnnounc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "frmSecretaryUI";
            this.Text = "SecretaryUI";
            this.Load += new System.EventHandler(this.frmSecretaryUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_SSN;
        private System.Windows.Forms.Label lbl_AllName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtxt_Announcement;
        private System.Windows.Forms.Button btn_SendAnnounc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_State;
        private System.Windows.Forms.MaskedTextBox mtxt_SSN;
        private System.Windows.Forms.ComboBox cbx_Doctor;
        private System.Windows.Forms.ComboBox cbx_Department;
        private System.Windows.Forms.MaskedTextBox mtxt_Time;
        private System.Windows.Forms.MaskedTextBox mtxt_Date;
        private System.Windows.Forms.Button btn_MakeAppoint;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_AppointmentList;
        private System.Windows.Forms.Button btn_DoctorPanel;
        private System.Windows.Forms.Button btn_DepartmentPanel;
        private System.Windows.Forms.Button btn_AnnouncementList;
        private System.Windows.Forms.Button button1;
    }
}