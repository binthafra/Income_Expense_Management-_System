namespace IncomeExpenseSoftware
{
    partial class ExpenseUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.InBackbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ExpenseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AddExpenseGridView = new System.Windows.Forms.DataGridView();
            this.AddExpcomebtn = new System.Windows.Forms.Button();
            this.ExpNoteTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ExAmountTextBox = new System.Windows.Forms.TextBox();
            this.ExpSrcNamecomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExpSaveSrcGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ExpSrcDesTextBox = new System.Windows.Forms.TextBox();
            this.ExpSrcNameTextBox = new System.Windows.Forms.TextBox();
            this.SaveExpSrcBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IncomeViwGroupBox = new System.Windows.Forms.GroupBox();
            this.ViewExpenseGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ViewExpenseSrcGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddExpenseGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpSaveSrcGridView)).BeginInit();
            this.IncomeViwGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewExpenseGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewExpenseSrcGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(57, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1083, 500);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.IncomeViwGroupBox);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1075, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Expense";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.InBackbtn);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1075, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Expense";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // InBackbtn
            // 
            this.InBackbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InBackbtn.Location = new System.Drawing.Point(388, 433);
            this.InBackbtn.Name = "InBackbtn";
            this.InBackbtn.Size = new System.Drawing.Size(104, 35);
            this.InBackbtn.TabIndex = 6;
            this.InBackbtn.Text = "Back";
            this.InBackbtn.UseVisualStyleBackColor = true;
            this.InBackbtn.Click += new System.EventHandler(this.InBackbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ExpenseDatePicker);
            this.groupBox2.Controls.Add(this.AddExpenseGridView);
            this.groupBox2.Controls.Add(this.AddExpcomebtn);
            this.groupBox2.Controls.Add(this.ExpNoteTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ExAmountTextBox);
            this.groupBox2.Controls.Add(this.ExpSrcNamecomboBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(420, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 407);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Expense";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Date";
            // 
            // ExpenseDatePicker
            // 
            this.ExpenseDatePicker.Location = new System.Drawing.Point(316, 147);
            this.ExpenseDatePicker.Name = "ExpenseDatePicker";
            this.ExpenseDatePicker.Size = new System.Drawing.Size(200, 20);
            this.ExpenseDatePicker.TabIndex = 3;
            // 
            // AddExpenseGridView
            // 
            this.AddExpenseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddExpenseGridView.Location = new System.Drawing.Point(27, 222);
            this.AddExpenseGridView.Name = "AddExpenseGridView";
            this.AddExpenseGridView.Size = new System.Drawing.Size(507, 179);
            this.AddExpenseGridView.TabIndex = 5;
            this.AddExpenseGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddExpenseGridView_CellContentClick);
            // 
            // AddExpcomebtn
            // 
            this.AddExpcomebtn.Location = new System.Drawing.Point(316, 181);
            this.AddExpcomebtn.Name = "AddExpcomebtn";
            this.AddExpcomebtn.Size = new System.Drawing.Size(97, 23);
            this.AddExpcomebtn.TabIndex = 4;
            this.AddExpcomebtn.Text = "Add Expense";
            this.AddExpcomebtn.UseVisualStyleBackColor = true;
            this.AddExpcomebtn.Click += new System.EventHandler(this.AddExpcomebtn_Click);
            // 
            // ExpNoteTextBox
            // 
            this.ExpNoteTextBox.Location = new System.Drawing.Point(316, 115);
            this.ExpNoteTextBox.Name = "ExpNoteTextBox";
            this.ExpNoteTextBox.Size = new System.Drawing.Size(200, 20);
            this.ExpNoteTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Notes";
            // 
            // ExAmountTextBox
            // 
            this.ExAmountTextBox.Location = new System.Drawing.Point(316, 79);
            this.ExAmountTextBox.Name = "ExAmountTextBox";
            this.ExAmountTextBox.Size = new System.Drawing.Size(200, 20);
            this.ExAmountTextBox.TabIndex = 1;
            // 
            // ExpSrcNamecomboBox
            // 
            this.ExpSrcNamecomboBox.FormattingEnabled = true;
            this.ExpSrcNamecomboBox.Location = new System.Drawing.Point(316, 39);
            this.ExpSrcNamecomboBox.Name = "ExpSrcNamecomboBox";
            this.ExpSrcNamecomboBox.Size = new System.Drawing.Size(200, 21);
            this.ExpSrcNamecomboBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Amount";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Source Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExpSaveSrcGridView);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ExpSrcDesTextBox);
            this.groupBox1.Controls.Add(this.ExpSrcNameTextBox);
            this.groupBox1.Controls.Add(this.SaveExpSrcBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expense Source";
            // 
            // ExpSaveSrcGridView
            // 
            this.ExpSaveSrcGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpSaveSrcGridView.Location = new System.Drawing.Point(23, 168);
            this.ExpSaveSrcGridView.Name = "ExpSaveSrcGridView";
            this.ExpSaveSrcGridView.Size = new System.Drawing.Size(318, 218);
            this.ExpSaveSrcGridView.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // ExpSrcDesTextBox
            // 
            this.ExpSrcDesTextBox.Location = new System.Drawing.Point(122, 73);
            this.ExpSrcDesTextBox.Name = "ExpSrcDesTextBox";
            this.ExpSrcDesTextBox.Size = new System.Drawing.Size(197, 20);
            this.ExpSrcDesTextBox.TabIndex = 1;
            // 
            // ExpSrcNameTextBox
            // 
            this.ExpSrcNameTextBox.Location = new System.Drawing.Point(122, 39);
            this.ExpSrcNameTextBox.Name = "ExpSrcNameTextBox";
            this.ExpSrcNameTextBox.Size = new System.Drawing.Size(197, 20);
            this.ExpSrcNameTextBox.TabIndex = 0;
            // 
            // SaveExpSrcBtn
            // 
            this.SaveExpSrcBtn.Location = new System.Drawing.Point(123, 115);
            this.SaveExpSrcBtn.Name = "SaveExpSrcBtn";
            this.SaveExpSrcBtn.Size = new System.Drawing.Size(100, 34);
            this.SaveExpSrcBtn.TabIndex = 2;
            this.SaveExpSrcBtn.Text = "Save Source";
            this.SaveExpSrcBtn.UseVisualStyleBackColor = true;
            this.SaveExpSrcBtn.Click += new System.EventHandler(this.SaveExpSrcBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Name";
            // 
            // IncomeViwGroupBox
            // 
            this.IncomeViwGroupBox.Controls.Add(this.ViewExpenseGridView);
            this.IncomeViwGroupBox.Location = new System.Drawing.Point(390, 19);
            this.IncomeViwGroupBox.Name = "IncomeViwGroupBox";
            this.IncomeViwGroupBox.Size = new System.Drawing.Size(594, 418);
            this.IncomeViwGroupBox.TabIndex = 5;
            this.IncomeViwGroupBox.TabStop = false;
            this.IncomeViwGroupBox.Text = "Expense";
            // 
            // ViewExpenseGridView
            // 
            this.ViewExpenseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewExpenseGridView.Location = new System.Drawing.Point(53, 53);
            this.ViewExpenseGridView.Name = "ViewExpenseGridView";
            this.ViewExpenseGridView.Size = new System.Drawing.Size(535, 338);
            this.ViewExpenseGridView.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ViewExpenseSrcGridView);
            this.groupBox3.Location = new System.Drawing.Point(31, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 418);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Expense Type";
            // 
            // ViewExpenseSrcGridView
            // 
            this.ViewExpenseSrcGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewExpenseSrcGridView.Location = new System.Drawing.Point(16, 40);
            this.ViewExpenseSrcGridView.Name = "ViewExpenseSrcGridView";
            this.ViewExpenseSrcGridView.Size = new System.Drawing.Size(296, 355);
            this.ViewExpenseSrcGridView.TabIndex = 0;
            this.ViewExpenseSrcGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewExpenseSrcGridView_CellDoubleClick);
            // 
            // ExpenseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IncomeExpenseSoftware.Properties.Resources.images__4_;
            this.ClientSize = new System.Drawing.Size(1246, 512);
            this.Controls.Add(this.tabControl1);
            this.Name = "ExpenseUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpenseUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddExpenseGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpSaveSrcGridView)).EndInit();
            this.IncomeViwGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewExpenseGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewExpenseSrcGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView AddExpenseGridView;
        private System.Windows.Forms.Button AddExpcomebtn;
        private System.Windows.Forms.TextBox ExpNoteTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ExAmountTextBox;
        private System.Windows.Forms.ComboBox ExpSrcNamecomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ExpSaveSrcGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ExpSrcDesTextBox;
        private System.Windows.Forms.TextBox ExpSrcNameTextBox;
        private System.Windows.Forms.Button SaveExpSrcBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ExpenseDatePicker;
        private System.Windows.Forms.Button InBackbtn;
        private System.Windows.Forms.GroupBox IncomeViwGroupBox;
        private System.Windows.Forms.DataGridView ViewExpenseGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView ViewExpenseSrcGridView;
    }
}