namespace Project_Hospital
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.btn_Patient = new System.Windows.Forms.Button();
            this.btn_Doctor = new System.Windows.Forms.Button();
            this.btn_Secretary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Patient
            // 
            this.btn_Patient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Patient.BackgroundImage")));
            this.btn_Patient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Patient.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Patient.Location = new System.Drawing.Point(59, 297);
            this.btn_Patient.Name = "btn_Patient";
            this.btn_Patient.Size = new System.Drawing.Size(227, 216);
            this.btn_Patient.TabIndex = 0;
            this.btn_Patient.Text = "button1";
            this.btn_Patient.UseVisualStyleBackColor = true;
            this.btn_Patient.Click += new System.EventHandler(this.btn_Patient_Click);
            // 
            // btn_Doctor
            // 
            this.btn_Doctor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Doctor.BackgroundImage")));
            this.btn_Doctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Doctor.Location = new System.Drawing.Point(365, 297);
            this.btn_Doctor.Name = "btn_Doctor";
            this.btn_Doctor.Size = new System.Drawing.Size(227, 216);
            this.btn_Doctor.TabIndex = 1;
            this.btn_Doctor.Text = "button2";
            this.btn_Doctor.UseVisualStyleBackColor = true;
            this.btn_Doctor.Click += new System.EventHandler(this.btn_Doctor_Click);
            // 
            // btn_Secretary
            // 
            this.btn_Secretary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Secretary.BackgroundImage")));
            this.btn_Secretary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Secretary.Location = new System.Drawing.Point(669, 297);
            this.btn_Secretary.Name = "btn_Secretary";
            this.btn_Secretary.Size = new System.Drawing.Size(227, 216);
            this.btn_Secretary.TabIndex = 2;
            this.btn_Secretary.Text = "button3";
            this.btn_Secretary.UseVisualStyleBackColor = true;
            this.btn_Secretary.Click += new System.EventHandler(this.btn_Secretary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(710, 516);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Secretary";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(619, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(446, 52);
            this.label4.TabIndex = 7;
            this.label4.Text = "DOGRUER HOSPITAL";
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(978, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Secretary);
            this.Controls.Add(this.btn_Doctor);
            this.Controls.Add(this.btn_Patient);
            this.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "frmLogIn";
            this.Text = "Dogruer Hospital LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Patient;
        private System.Windows.Forms.Button btn_Doctor;
        private System.Windows.Forms.Button btn_Secretary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

