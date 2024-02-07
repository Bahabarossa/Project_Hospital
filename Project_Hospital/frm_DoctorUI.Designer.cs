namespace Project_Hospital
{
    partial class frm_DoctorUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DoctorUI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_AllName = new System.Windows.Forms.Label();
            this.lbl_SSN = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxt_IllDescript = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Annonce = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_AllName);
            this.groupBox1.Controls.Add(this.lbl_SSN);
            this.groupBox1.Location = new System.Drawing.Point(23, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(438, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Information";
            // 
            // lbl_AllName
            // 
            this.lbl_AllName.AutoSize = true;
            this.lbl_AllName.Location = new System.Drawing.Point(54, 117);
            this.lbl_AllName.Name = "lbl_AllName";
            this.lbl_AllName.Size = new System.Drawing.Size(209, 32);
            this.lbl_AllName.TabIndex = 1;
            this.lbl_AllName.Text = "Name Surname";
            // 
            // lbl_SSN
            // 
            this.lbl_SSN.AutoSize = true;
            this.lbl_SSN.Location = new System.Drawing.Point(54, 73);
            this.lbl_SSN.Name = "lbl_SSN";
            this.lbl_SSN.Size = new System.Drawing.Size(67, 32);
            this.lbl_SSN.TabIndex = 0;
            this.lbl_SSN.Text = "SSN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rtxt_IllDescript);
            this.groupBox2.Location = new System.Drawing.Point(23, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 307);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment Detail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Illnes Description";
            // 
            // rtxt_IllDescript
            // 
            this.rtxt_IllDescript.Enabled = false;
            this.rtxt_IllDescript.Location = new System.Drawing.Point(23, 106);
            this.rtxt_IllDescript.Name = "rtxt_IllDescript";
            this.rtxt_IllDescript.Size = new System.Drawing.Size(396, 172);
            this.rtxt_IllDescript.TabIndex = 0;
            this.rtxt_IllDescript.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(470, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1001, 735);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment List";
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
            this.dataGridView1.Size = new System.Drawing.Size(995, 697);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Exit);
            this.groupBox4.Controls.Add(this.btn_Annonce);
            this.groupBox4.Location = new System.Drawing.Point(23, 518);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(438, 251);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(281, 202);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(130, 43);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Annonce
            // 
            this.btn_Annonce.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Annonce.Location = new System.Drawing.Point(6, 47);
            this.btn_Annonce.Name = "btn_Annonce";
            this.btn_Annonce.Size = new System.Drawing.Size(202, 90);
            this.btn_Annonce.TabIndex = 1;
            this.btn_Annonce.Text = "Announcement";
            this.btn_Annonce.UseVisualStyleBackColor = true;
            this.btn_Annonce.Click += new System.EventHandler(this.btn_Annonce_Click);
            // 
            // frm_DoctorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1525, 800);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimizeBox = false;
            this.Name = "frm_DoctorUI";
            this.Text = "DoctorUI";
            this.Load += new System.EventHandler(this.frm_DoctorUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_SSN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_AllName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxt_IllDescript;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Annonce;
    }
}