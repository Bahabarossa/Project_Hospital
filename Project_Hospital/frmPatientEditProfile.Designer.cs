namespace Project_Hospital
{
    partial class frmPatientEditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientEditProfile));
            this.btn_Update = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_Gender = new System.Windows.Forms.ComboBox();
            this.mtxt_Phone = new System.Windows.Forms.MaskedTextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxt_SSN = new System.Windows.Forms.MaskedTextBox();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Update.Location = new System.Drawing.Point(295, 398);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(160, 45);
            this.btn_Update.TabIndex = 7;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 32);
            this.label6.TabIndex = 30;
            this.label6.Text = "Patient Gender :";
            // 
            // cbx_Gender
            // 
            this.cbx_Gender.FormattingEnabled = true;
            this.cbx_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbx_Gender.Location = new System.Drawing.Point(295, 332);
            this.cbx_Gender.Name = "cbx_Gender";
            this.cbx_Gender.Size = new System.Drawing.Size(151, 40);
            this.cbx_Gender.TabIndex = 6;
            // 
            // mtxt_Phone
            // 
            this.mtxt_Phone.Location = new System.Drawing.Point(295, 160);
            this.mtxt_Phone.Mask = "(999) 000-0000";
            this.mtxt_Phone.Name = "mtxt_Phone";
            this.mtxt_Phone.Size = new System.Drawing.Size(216, 39);
            this.mtxt_Phone.TabIndex = 3;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(295, 43);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(216, 39);
            this.txt_Name.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 32);
            this.label4.TabIndex = 25;
            this.label4.Text = "Patient Name :";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(295, 271);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(216, 39);
            this.txt_Password.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Patient Password :";
            // 
            // mtxt_SSN
            // 
            this.mtxt_SSN.Location = new System.Drawing.Point(295, 217);
            this.mtxt_SSN.Mask = "00000000000";
            this.mtxt_SSN.Name = "mtxt_SSN";
            this.mtxt_SSN.Size = new System.Drawing.Size(216, 39);
            this.mtxt_SSN.TabIndex = 4;
            this.mtxt_SSN.ValidatingType = typeof(int);
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(295, 100);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(216, 39);
            this.txt_Surname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "Patient Surname :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Patient SSN :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 32);
            this.label5.TabIndex = 32;
            this.label5.Text = "Patient Phone :";
            // 
            // frmPatientEditProfile
            // 
            this.AcceptButton = this.btn_Update;
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(551, 474);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_Gender);
            this.Controls.Add(this.mtxt_Phone);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxt_SSN);
            this.Controls.Add(this.txt_Surname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "frmPatientEditProfile";
            this.Text = "PatientEditProfile";
            this.Load += new System.EventHandler(this.frmPatientEditProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_Gender;
        private System.Windows.Forms.MaskedTextBox mtxt_Phone;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxt_SSN;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}