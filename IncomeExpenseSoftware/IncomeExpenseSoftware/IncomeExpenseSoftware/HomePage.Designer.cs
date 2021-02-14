namespace IncomeExpenseSoftware
{
    partial class HomePage
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
            this.Savingsbutton = new System.Windows.Forms.Button();
            this.Expensebutton = new System.Windows.Forms.Button();
            this.incomebutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LogOutbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Savingsbutton
            // 
            this.Savingsbutton.Location = new System.Drawing.Point(178, 290);
            this.Savingsbutton.Name = "Savingsbutton";
            this.Savingsbutton.Size = new System.Drawing.Size(239, 53);
            this.Savingsbutton.TabIndex = 6;
            this.Savingsbutton.Text = "SAVINGS";
            this.Savingsbutton.UseVisualStyleBackColor = true;
            // 
            // Expensebutton
            // 
            this.Expensebutton.Location = new System.Drawing.Point(178, 212);
            this.Expensebutton.Name = "Expensebutton";
            this.Expensebutton.Size = new System.Drawing.Size(239, 53);
            this.Expensebutton.TabIndex = 5;
            this.Expensebutton.Text = "EXPENSE";
            this.Expensebutton.UseVisualStyleBackColor = true;
            this.Expensebutton.Click += new System.EventHandler(this.Expensebutton_Click);
            // 
            // incomebutton
            // 
            this.incomebutton.Location = new System.Drawing.Point(178, 140);
            this.incomebutton.Name = "incomebutton";
            this.incomebutton.Size = new System.Drawing.Size(239, 53);
            this.incomebutton.TabIndex = 4;
            this.incomebutton.Text = "INCOME";
            this.incomebutton.UseVisualStyleBackColor = true;
            this.incomebutton.Click += new System.EventHandler(this.incomebutton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(142, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(343, 55);
            this.label7.TabIndex = 35;
            this.label7.Text = "Income - Expense";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(100, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 55);
            this.label1.TabIndex = 36;
            this.label1.Text = "Management System";
            // 
            // LogOutbtn
            // 
            this.LogOutbtn.BackgroundImage = global::IncomeExpenseSoftware.Properties.Resources.download1;
            this.LogOutbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogOutbtn.Location = new System.Drawing.Point(199, 367);
            this.LogOutbtn.Name = "LogOutbtn";
            this.LogOutbtn.Size = new System.Drawing.Size(205, 73);
            this.LogOutbtn.TabIndex = 37;
            this.LogOutbtn.UseVisualStyleBackColor = true;
            this.LogOutbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IncomeExpenseSoftware.Properties.Resources.images__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 452);
            this.Controls.Add(this.LogOutbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Savingsbutton);
            this.Controls.Add(this.Expensebutton);
            this.Controls.Add(this.incomebutton);
            this.DoubleBuffered = true;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Savingsbutton;
        private System.Windows.Forms.Button Expensebutton;
        private System.Windows.Forms.Button incomebutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogOutbtn;
    }
}