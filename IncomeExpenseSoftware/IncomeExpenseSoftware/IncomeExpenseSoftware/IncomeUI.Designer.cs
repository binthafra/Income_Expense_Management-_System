namespace IncomeExpenseSoftware
{
    partial class IncomeUI
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
            this.IncometabCntrl = new System.Windows.Forms.TabControl();
            this.ViewIncometabPage = new System.Windows.Forms.TabPage();
            this.IncomeViwGroupBox = new System.Windows.Forms.GroupBox();
            this.INfullViewGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.IncomeViewGridView = new System.Windows.Forms.DataGridView();
            this.AddIncomeTabPage = new System.Windows.Forms.TabPage();
            this.InBackbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.incomeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.inDateTexBox = new System.Windows.Forms.TextBox();
            this.AddIncomeGridView = new System.Windows.Forms.DataGridView();
            this.AddIncomebtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InSrcNamecomboBox = new System.Windows.Forms.ComboBox();
            this.IncomeAmountTextBox = new System.Windows.Forms.TextBox();
            this.InNoteTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InSrcDesTexBox = new System.Windows.Forms.TextBox();
            this.InSaveSrcGridView = new System.Windows.Forms.DataGridView();
            this.SaveInSrcBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InSrcNametextBox = new System.Windows.Forms.TextBox();
            this.IncometabCntrl.SuspendLayout();
            this.ViewIncometabPage.SuspendLayout();
            this.IncomeViwGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.INfullViewGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeViewGridView)).BeginInit();
            this.AddIncomeTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddIncomeGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InSaveSrcGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // IncometabCntrl
            // 
            this.IncometabCntrl.Controls.Add(this.ViewIncometabPage);
            this.IncometabCntrl.Controls.Add(this.AddIncomeTabPage);
            this.IncometabCntrl.Location = new System.Drawing.Point(62, 3);
            this.IncometabCntrl.Name = "IncometabCntrl";
            this.IncometabCntrl.SelectedIndex = 0;
            this.IncometabCntrl.Size = new System.Drawing.Size(1103, 488);
            this.IncometabCntrl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.IncometabCntrl.TabIndex = 1;
            // 
            // ViewIncometabPage
            // 
            this.ViewIncometabPage.Controls.Add(this.IncomeViwGroupBox);
            this.ViewIncometabPage.Controls.Add(this.groupBox3);
            this.ViewIncometabPage.Location = new System.Drawing.Point(4, 22);
            this.ViewIncometabPage.Name = "ViewIncometabPage";
            this.ViewIncometabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ViewIncometabPage.Size = new System.Drawing.Size(1095, 462);
            this.ViewIncometabPage.TabIndex = 0;
            this.ViewIncometabPage.Text = "View Income";
            this.ViewIncometabPage.UseVisualStyleBackColor = true;
            // 
            // IncomeViwGroupBox
            // 
            this.IncomeViwGroupBox.Controls.Add(this.INfullViewGridView);
            this.IncomeViwGroupBox.Location = new System.Drawing.Point(482, 23);
            this.IncomeViwGroupBox.Name = "IncomeViwGroupBox";
            this.IncomeViwGroupBox.Size = new System.Drawing.Size(476, 418);
            this.IncomeViwGroupBox.TabIndex = 3;
            this.IncomeViwGroupBox.TabStop = false;
            this.IncomeViwGroupBox.Text = "Income";
            // 
            // INfullViewGridView
            // 
            this.INfullViewGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.INfullViewGridView.Location = new System.Drawing.Point(53, 53);
            this.INfullViewGridView.Name = "INfullViewGridView";
            this.INfullViewGridView.Size = new System.Drawing.Size(408, 338);
            this.INfullViewGridView.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.IncomeViewGridView);
            this.groupBox3.Location = new System.Drawing.Point(22, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 418);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Income Type";
            // 
            // IncomeViewGridView
            // 
            this.IncomeViewGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncomeViewGridView.Location = new System.Drawing.Point(16, 40);
            this.IncomeViewGridView.Name = "IncomeViewGridView";
            this.IncomeViewGridView.Size = new System.Drawing.Size(399, 355);
            this.IncomeViewGridView.TabIndex = 0;
            this.IncomeViewGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IncomeViewGridView_CellContentClick);
            this.IncomeViewGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IncomeViewGridView_CellDoubleClick);
            // 
            // AddIncomeTabPage
            // 
            this.AddIncomeTabPage.Controls.Add(this.InBackbtn);
            this.AddIncomeTabPage.Controls.Add(this.groupBox2);
            this.AddIncomeTabPage.Controls.Add(this.groupBox1);
            this.AddIncomeTabPage.Location = new System.Drawing.Point(4, 22);
            this.AddIncomeTabPage.Name = "AddIncomeTabPage";
            this.AddIncomeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AddIncomeTabPage.Size = new System.Drawing.Size(1095, 462);
            this.AddIncomeTabPage.TabIndex = 1;
            this.AddIncomeTabPage.Text = "Add Income";
            this.AddIncomeTabPage.UseVisualStyleBackColor = true;
            // 
            // InBackbtn
            // 
            this.InBackbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InBackbtn.Location = new System.Drawing.Point(909, 419);
            this.InBackbtn.Name = "InBackbtn";
            this.InBackbtn.Size = new System.Drawing.Size(75, 35);
            this.InBackbtn.TabIndex = 5;
            this.InBackbtn.Text = "Back";
            this.InBackbtn.UseVisualStyleBackColor = true;
            this.InBackbtn.Click += new System.EventHandler(this.InBackbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.incomeDatePicker);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.inDateTexBox);
            this.groupBox2.Controls.Add(this.AddIncomeGridView);
            this.groupBox2.Controls.Add(this.AddIncomebtn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.InSrcNamecomboBox);
            this.groupBox2.Controls.Add(this.IncomeAmountTextBox);
            this.groupBox2.Controls.Add(this.InNoteTextBox);
            this.groupBox2.Location = new System.Drawing.Point(339, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 395);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Income";
            // 
            // incomeDatePicker
            // 
            this.incomeDatePicker.Location = new System.Drawing.Point(325, 123);
            this.incomeDatePicker.Name = "incomeDatePicker";
            this.incomeDatePicker.Size = new System.Drawing.Size(200, 20);
            this.incomeDatePicker.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date";
            // 
            // inDateTexBox
            // 
            this.inDateTexBox.Location = new System.Drawing.Point(325, 149);
            this.inDateTexBox.Name = "inDateTexBox";
            this.inDateTexBox.Size = new System.Drawing.Size(200, 20);
            this.inDateTexBox.TabIndex = 9;
            // 
            // AddIncomeGridView
            // 
            this.AddIncomeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddIncomeGridView.Location = new System.Drawing.Point(29, 219);
            this.AddIncomeGridView.Name = "AddIncomeGridView";
            this.AddIncomeGridView.Size = new System.Drawing.Size(652, 162);
            this.AddIncomeGridView.TabIndex = 8;
            // 
            // AddIncomebtn
            // 
            this.AddIncomebtn.Location = new System.Drawing.Point(325, 180);
            this.AddIncomebtn.Name = "AddIncomebtn";
            this.AddIncomebtn.Size = new System.Drawing.Size(81, 33);
            this.AddIncomebtn.TabIndex = 3;
            this.AddIncomebtn.Text = "Add Income";
            this.AddIncomebtn.UseVisualStyleBackColor = true;
            this.AddIncomebtn.Click += new System.EventHandler(this.AddIncomebtn_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Notes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Source Name";
            // 
            // InSrcNamecomboBox
            // 
            this.InSrcNamecomboBox.FormattingEnabled = true;
            this.InSrcNamecomboBox.Location = new System.Drawing.Point(325, 28);
            this.InSrcNamecomboBox.Name = "InSrcNamecomboBox";
            this.InSrcNamecomboBox.Size = new System.Drawing.Size(200, 21);
            this.InSrcNamecomboBox.TabIndex = 0;
            // 
            // IncomeAmountTextBox
            // 
            this.IncomeAmountTextBox.Location = new System.Drawing.Point(325, 62);
            this.IncomeAmountTextBox.Name = "IncomeAmountTextBox";
            this.IncomeAmountTextBox.Size = new System.Drawing.Size(200, 20);
            this.IncomeAmountTextBox.TabIndex = 1;
            // 
            // InNoteTextBox
            // 
            this.InNoteTextBox.Location = new System.Drawing.Point(325, 91);
            this.InNoteTextBox.Name = "InNoteTextBox";
            this.InNoteTextBox.Size = new System.Drawing.Size(200, 20);
            this.InNoteTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.InSrcDesTexBox);
            this.groupBox1.Controls.Add(this.InSaveSrcGridView);
            this.groupBox1.Controls.Add(this.SaveInSrcBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.InSrcNametextBox);
            this.groupBox1.Location = new System.Drawing.Point(20, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 395);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Income Source";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Description";
            // 
            // InSrcDesTexBox
            // 
            this.InSrcDesTexBox.Location = new System.Drawing.Point(99, 61);
            this.InSrcDesTexBox.Name = "InSrcDesTexBox";
            this.InSrcDesTexBox.Size = new System.Drawing.Size(144, 20);
            this.InSrcDesTexBox.TabIndex = 1;
            // 
            // InSaveSrcGridView
            // 
            this.InSaveSrcGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InSaveSrcGridView.Location = new System.Drawing.Point(15, 141);
            this.InSaveSrcGridView.Name = "InSaveSrcGridView";
            this.InSaveSrcGridView.Size = new System.Drawing.Size(240, 184);
            this.InSaveSrcGridView.TabIndex = 3;
            // 
            // SaveInSrcBtn
            // 
            this.SaveInSrcBtn.Location = new System.Drawing.Point(99, 93);
            this.SaveInSrcBtn.Name = "SaveInSrcBtn";
            this.SaveInSrcBtn.Size = new System.Drawing.Size(81, 33);
            this.SaveInSrcBtn.TabIndex = 2;
            this.SaveInSrcBtn.Text = "Save Source";
            this.SaveInSrcBtn.UseVisualStyleBackColor = true;
            this.SaveInSrcBtn.Click += new System.EventHandler(this.SaveInSrcBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Name";
            // 
            // InSrcNametextBox
            // 
            this.InSrcNametextBox.Location = new System.Drawing.Point(99, 29);
            this.InSrcNametextBox.Name = "InSrcNametextBox";
            this.InSrcNametextBox.Size = new System.Drawing.Size(144, 20);
            this.InSrcNametextBox.TabIndex = 0;
            // 
            // IncomeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IncomeExpenseSoftware.Properties.Resources.images__4_;
            this.ClientSize = new System.Drawing.Size(1230, 503);
            this.Controls.Add(this.IncometabCntrl);
            this.Name = "IncomeUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IncomeUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.IncometabCntrl.ResumeLayout(false);
            this.ViewIncometabPage.ResumeLayout(false);
            this.IncomeViwGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.INfullViewGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IncomeViewGridView)).EndInit();
            this.AddIncomeTabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddIncomeGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InSaveSrcGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl IncometabCntrl;
        private System.Windows.Forms.TabPage ViewIncometabPage;
        private System.Windows.Forms.GroupBox IncomeViwGroupBox;
        private System.Windows.Forms.DataGridView INfullViewGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView IncomeViewGridView;
        private System.Windows.Forms.TabPage AddIncomeTabPage;
        private System.Windows.Forms.Button InBackbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker incomeDatePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inDateTexBox;
        private System.Windows.Forms.DataGridView AddIncomeGridView;
        private System.Windows.Forms.Button AddIncomebtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox InSrcNamecomboBox;
        private System.Windows.Forms.TextBox IncomeAmountTextBox;
        private System.Windows.Forms.TextBox InNoteTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InSrcDesTexBox;
        private System.Windows.Forms.DataGridView InSaveSrcGridView;
        private System.Windows.Forms.Button SaveInSrcBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InSrcNametextBox;
    }
}