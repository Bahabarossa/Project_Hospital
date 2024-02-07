namespace Project_Hospital
{
    partial class frmPatientUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientUI));
            this.Lbl_AllName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lnk_Profile = new System.Windows.Forms.LinkLabel();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_randevuID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Appointment = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxt_illnes = new System.Windows.Forms.RichTextBox();
            this.cbx_Doctor = new System.Windows.Forms.ComboBox();
            this.cbx_Departmant = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_AllName
            // 
            this.Lbl_AllName.AutoSize = true;
            this.Lbl_AllName.Location = new System.Drawing.Point(24, 96);
            this.Lbl_AllName.Name = "Lbl_AllName";
            this.Lbl_AllName.Size = new System.Drawing.Size(70, 32);
            this.Lbl_AllName.TabIndex = 13;
            this.Lbl_AllName.Text = "xxxx";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.Lnk_Profile);
            this.groupBox1.Controls.Add(this.Lbl_ID);
            this.groupBox1.Controls.Add(this.Lbl_AllName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 203);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Information";
            // 
            // Lnk_Profile
            // 
            this.Lnk_Profile.AutoSize = true;
            this.Lnk_Profile.Location = new System.Drawing.Point(377, 35);
            this.Lnk_Profile.Name = "Lnk_Profile";
            this.Lnk_Profile.Size = new System.Drawing.Size(96, 32);
            this.Lnk_Profile.TabIndex = 20;
            this.Lnk_Profile.TabStop = true;
            this.Lnk_Profile.Text = "Profile";
            this.Lnk_Profile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnk_Profile_LinkClicked);
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Location = new System.Drawing.Point(24, 51);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(46, 32);
            this.Lbl_ID.TabIndex = 14;
            this.Lbl_ID.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txt_randevuID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_Appointment);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rtxt_illnes);
            this.groupBox2.Controls.Add(this.cbx_Doctor);
            this.groupBox2.Controls.Add(this.cbx_Departmant);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 577);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient Information";
            // 
            // txt_randevuID
            // 
            this.txt_randevuID.Enabled = false;
            this.txt_randevuID.Location = new System.Drawing.Point(196, 68);
            this.txt_randevuID.Name = "txt_randevuID";
            this.txt_randevuID.Size = new System.Drawing.Size(277, 39);
            this.txt_randevuID.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID";
            // 
            // btn_Appointment
            // 
            this.btn_Appointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Appointment.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Appointment.Location = new System.Drawing.Point(128, 494);
            this.btn_Appointment.Name = "btn_Appointment";
            this.btn_Appointment.Size = new System.Drawing.Size(218, 61);
            this.btn_Appointment.TabIndex = 19;
            this.btn_Appointment.Text = "make an appointment";
            this.btn_Appointment.UseVisualStyleBackColor = false;
            this.btn_Appointment.Click += new System.EventHandler(this.btn_Appointment_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "Explain your illness";
            // 
            // rtxt_illnes
            // 
            this.rtxt_illnes.Location = new System.Drawing.Point(30, 299);
            this.rtxt_illnes.Name = "rtxt_illnes";
            this.rtxt_illnes.Size = new System.Drawing.Size(443, 178);
            this.rtxt_illnes.TabIndex = 17;
            this.rtxt_illnes.Text = "";
            // 
            // cbx_Doctor
            // 
            this.cbx_Doctor.FormattingEnabled = true;
            this.cbx_Doctor.Location = new System.Drawing.Point(196, 204);
            this.cbx_Doctor.Name = "cbx_Doctor";
            this.cbx_Doctor.Size = new System.Drawing.Size(277, 40);
            this.cbx_Doctor.TabIndex = 16;
            this.cbx_Doctor.SelectedIndexChanged += new System.EventHandler(this.cbx_Doctor_SelectedIndexChanged);
            // 
            // cbx_Departmant
            // 
            this.cbx_Departmant.FormattingEnabled = true;
            this.cbx_Departmant.Location = new System.Drawing.Point(196, 138);
            this.cbx_Departmant.Name = "cbx_Departmant";
            this.cbx_Departmant.Size = new System.Drawing.Size(277, 40);
            this.cbx_Departmant.TabIndex = 15;
            this.cbx_Departmant.SelectedIndexChanged += new System.EventHandler(this.cbx_Departmant_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Doctor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Departmant";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(521, 408);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1075, 390);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Appointments";
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
            this.dataGridView2.Size = new System.Drawing.Size(1069, 352);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(521, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1075, 390);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment History";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1069, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(383, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 43);
            this.button1.TabIndex = 22;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPatientUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1608, 811);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.Name = "frmPatientUI";
            this.Text = "PatientUI";
            this.Load += new System.EventHandler(this.frmPatientUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_AllName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtxt_illnes;
        private System.Windows.Forms.ComboBox cbx_Doctor;
        private System.Windows.Forms.ComboBox cbx_Departmant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Appointment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel Lnk_Profile;
        private System.Windows.Forms.TextBox txt_randevuID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}