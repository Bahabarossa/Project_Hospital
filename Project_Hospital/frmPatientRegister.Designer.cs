namespace Project_Hospital
{
    partial class frmPatientRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientRegister));
            this.mtxt_SSN = new System.Windows.Forms.MaskedTextBox();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxt_Phone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_Gender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtxt_SSN
            // 
            this.mtxt_SSN.Location = new System.Drawing.Point(299, 205);
            this.mtxt_SSN.Mask = "00000000000";
            this.mtxt_SSN.Name = "mtxt_SSN";
            this.mtxt_SSN.Size = new System.Drawing.Size(216, 39);
            this.mtxt_SSN.TabIndex = 4;
            this.mtxt_SSN.ValidatingType = typeof(int);
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(299, 88);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(216, 39);
            this.txt_Surname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Patient Surname :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Patinent SSN :";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(299, 259);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(216, 39);
            this.txt_Password.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Patient Password :";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(299, 31);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(216, 39);
            this.txt_Name.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Patient Name :";
            // 
            // mtxt_Phone
            // 
            this.mtxt_Phone.Location = new System.Drawing.Point(299, 148);
            this.mtxt_Phone.Mask = "(999) 000-0000";
            this.mtxt_Phone.Name = "mtxt_Phone";
            this.mtxt_Phone.Size = new System.Drawing.Size(216, 39);
            this.mtxt_Phone.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "Patinent Phone :";
            // 
            // cbx_Gender
            // 
            this.cbx_Gender.FormattingEnabled = true;
            this.cbx_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbx_Gender.Location = new System.Drawing.Point(299, 320);
            this.cbx_Gender.Name = "cbx_Gender";
            this.cbx_Gender.Size = new System.Drawing.Size(151, 40);
            this.cbx_Gender.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Patient Gender :";
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_SignUp.Location = new System.Drawing.Point(299, 386);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(160, 45);
            this.btn_SignUp.TabIndex = 18;
            this.btn_SignUp.Text = "Sign Up";
            this.btn_SignUp.UseVisualStyleBackColor = false;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // frmPatientRegister
            // 
            this.AcceptButton = this.btn_SignUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(560, 459);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_Gender);
            this.Controls.Add(this.mtxt_Phone);
            this.Controls.Add(this.label5);
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
            this.Name = "frmPatientRegister";
            this.Text = "PatientRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxt_SSN;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxt_Phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_Gender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_SignUp;
    }
}