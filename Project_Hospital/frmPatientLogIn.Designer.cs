namespace Project_Hospital
{
    partial class frmPatientLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientLogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lnk_SignIn = new System.Windows.Forms.LinkLabel();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_SSN = new System.Windows.Forms.MaskedTextBox();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(235, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Log In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patinent SSN :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patient Password :";
            // 
            // lnk_SignIn
            // 
            this.lnk_SignIn.AutoSize = true;
            this.lnk_SignIn.Location = new System.Drawing.Point(599, 264);
            this.lnk_SignIn.Name = "lnk_SignIn";
            this.lnk_SignIn.Size = new System.Drawing.Size(104, 32);
            this.lnk_SignIn.TabIndex = 4;
            this.lnk_SignIn.TabStop = true;
            this.lnk_SignIn.Text = "Sign In";
            this.lnk_SignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_SignIn_LinkClicked);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(363, 257);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(216, 39);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_SSN
            // 
            this.txt_SSN.Location = new System.Drawing.Point(363, 181);
            this.txt_SSN.Mask = "00000000000";
            this.txt_SSN.Name = "txt_SSN";
            this.txt_SSN.Size = new System.Drawing.Size(216, 39);
            this.txt_SSN.TabIndex = 1;
            this.txt_SSN.ValidatingType = typeof(int);
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Location = new System.Drawing.Point(392, 323);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(118, 40);
            this.btn_LogIn.TabIndex = 3;
            this.btn_LogIn.Text = "Log In";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // btn_return
            // 
            this.btn_return.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_return.Location = new System.Drawing.Point(698, 428);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(126, 40);
            this.btn_return.TabIndex = 5;
            this.btn_return.Text = "return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // frmPatientLogIn
            // 
            this.AcceptButton = this.btn_LogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btn_return;
            this.ClientSize = new System.Drawing.Size(836, 480);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.txt_SSN);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lnk_SignIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.Name = "frmPatientLogIn";
            this.Text = "PatientLogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnk_SignIn;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.MaskedTextBox txt_SSN;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Button btn_return;
    }
}