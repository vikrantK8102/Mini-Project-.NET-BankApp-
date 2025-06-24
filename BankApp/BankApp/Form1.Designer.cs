namespace BankApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            ownertxt = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountGrid = new DataGridView();
            DepositBtn = new Button();
            CreateAccountBtn = new Button();
            WithdrawBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            InterestRateNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 59);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 0;
            label1.Text = "Owner:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 277);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 1;
            label2.Text = "Amount:";
            label2.Click += label2_Click;
            // 
            // ownertxt
            // 
            ownertxt.Location = new Point(109, 59);
            ownertxt.Name = "ownertxt";
            ownertxt.Size = new Size(179, 29);
            ownertxt.TabIndex = 2;
            ownertxt.TextChanged += textBox1_TextChanged;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(94, 277);
            AmountNum.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            AmountNum.Minimum = new decimal(new int[] { 9999999, 0, 0, int.MinValue });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(179, 29);
            AmountNum.TabIndex = 3;
            AmountNum.ValueChanged += AmountNum_ValueChanged;
            // 
            // BankAccountGrid
            // 
            BankAccountGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountGrid.Location = new Point(325, 55);
            BankAccountGrid.Name = "BankAccountGrid";
            BankAccountGrid.Size = new Size(449, 216);
            BankAccountGrid.TabIndex = 4;
            BankAccountGrid.CellContentClick += BankAccountGrid_CellContentClick;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(309, 277);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(212, 36);
            DepositBtn.TabIndex = 5;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point(106, 176);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(182, 36);
            CreateAccountBtn.TabIndex = 6;
            CreateAccountBtn.Text = "create account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(543, 277);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(231, 36);
            WithdrawBtn.TabIndex = 7;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(276, -1);
            label3.Name = "label3";
            label3.Size = new Size(215, 32);
            label3.TabIndex = 8;
            label3.Text = "Bank Of America";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 120);
            label4.Name = "label4";
            label4.Size = new Size(123, 21);
            label4.TabIndex = 9;
            label4.Text = "Interest Rate(%):";
            // 
            // InterestRateNum
            // 
            InterestRateNum.Location = new Point(141, 118);
            InterestRateNum.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            InterestRateNum.Minimum = new decimal(new int[] { 9999999, 0, 0, int.MinValue });
            InterestRateNum.Name = "InterestRateNum";
            InterestRateNum.Size = new Size(135, 29);
            InterestRateNum.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 325);
            Controls.Add(InterestRateNum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(WithdrawBtn);
            Controls.Add(CreateAccountBtn);
            Controls.Add(DepositBtn);
            Controls.Add(BankAccountGrid);
            Controls.Add(AmountNum);
            Controls.Add(ownertxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox ownertxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountGrid;
        private Button DepositBtn;
        private Button CreateAccountBtn;
        private Button WithdrawBtn;
        private Label label3;
        private Label label4;
        private NumericUpDown InterestRateNum;
    }
}
