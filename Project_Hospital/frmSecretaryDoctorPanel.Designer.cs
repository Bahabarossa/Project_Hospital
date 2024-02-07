namespace Project_Hospital
{
    partial class frmSecretaryDoctorPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecretaryDoctorPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.cbx_Department = new System.Windows.Forms.ComboBox();
            this.mtxt_SSN = new System.Windows.Forms.MaskedTextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doctor Surname :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Doctor SSN :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Doctor Password :";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(257, 67);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(216, 39);
            this.txt_Name.TabIndex = 1;
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(257, 148);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(216, 39);
            this.txt_Surname.TabIndex = 2;
            // 
            // cbx_Department
            // 
            this.cbx_Department.FormattingEnabled = true;
            this.cbx_Department.Location = new System.Drawing.Point(257, 249);
            this.cbx_Department.Name = "cbx_Department";
            this.cbx_Department.Size = new System.Drawing.Size(216, 40);
            this.cbx_Department.TabIndex = 3;
            this.cbx_Department.SelectedIndexChanged += new System.EventHandler(this.cbx_Department_SelectedIndexChanged);
            // 
            // mtxt_SSN
            // 
            this.mtxt_SSN.Location = new System.Drawing.Point(257, 329);
            this.mtxt_SSN.Mask = "00000000000";
            this.mtxt_SSN.Name = "mtxt_SSN";
            this.mtxt_SSN.Size = new System.Drawing.Size(216, 39);
            this.mtxt_SSN.TabIndex = 4;
            this.mtxt_SSN.ValidatingType = typeof(int);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(257, 395);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(216, 39);
            this.txt_Password.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Password);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mtxt_SSN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbx_Department);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Surname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 467);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(531, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 467);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doctor List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(672, 429);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Add.Location = new System.Drawing.Point(94, 485);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(118, 47);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Red;
            this.btn_Delete.Location = new System.Drawing.Point(218, 485);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(118, 47);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Yellow;
            this.btn_Update.Location = new System.Drawing.Point(342, 485);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(118, 47);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // frmSecretaryDoctorPanel
            // 
            this.AcceptButton = this.btn_Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1281, 584);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "frmSecretaryDoctorPanel";
            this.Text = "Secretary Doctor Panel";
            this.Load += new System.EventHandler(this.frmSecretaryDoctorPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.ComboBox cbx_Department;
        private System.Windows.Forms.MaskedTextBox mtxt_SSN;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
    }
}