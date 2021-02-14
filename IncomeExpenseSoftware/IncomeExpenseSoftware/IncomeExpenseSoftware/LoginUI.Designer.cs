namespace IncomeExpenseSoftware
{
    partial class LoginUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUI));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registrationBtn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.logpasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logemailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(195, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // registrationBtn
            // 
            this.registrationBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.registrationBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registrationBtn.Location = new System.Drawing.Point(309, 342);
            this.registrationBtn.Name = "registrationBtn";
            this.registrationBtn.Size = new System.Drawing.Size(104, 36);
            this.registrationBtn.TabIndex = 9;
            this.registrationBtn.Text = "New user?";
            this.registrationBtn.UseVisualStyleBackColor = false;
            this.registrationBtn.Click += new System.EventHandler(this.registrationBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginBtn.Location = new System.Drawing.Point(195, 342);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(99, 36);
            this.LoginBtn.TabIndex = 8;
            this.LoginBtn.Text = "Log In";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // logpasswordTextBox
            // 
            this.logpasswordTextBox.Location = new System.Drawing.Point(191, 304);
            this.logpasswordTextBox.Name = "logpasswordTextBox";
            this.logpasswordTextBox.Size = new System.Drawing.Size(222, 20);
            this.logpasswordTextBox.TabIndex = 7;
            this.logpasswordTextBox.TextChanged += new System.EventHandler(this.logpasswordTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // logemailTextBox
            // 
            this.logemailTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.logemailTextBox.Location = new System.Drawing.Point(191, 278);
            this.logemailTextBox.Name = "logemailTextBox";
            this.logemailTextBox.Size = new System.Drawing.Size(222, 20);
            this.logemailTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Email";
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IncomeExpenseSoftware.Properties.Resources.images__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 479);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.registrationBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.logpasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logemailTextBox);
            this.Controls.Add(this.label1);
            this.Name = "LoginUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button registrationBtn;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox logpasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox logemailTextBox;
        private System.Windows.Forms.Label label1;
    }
}