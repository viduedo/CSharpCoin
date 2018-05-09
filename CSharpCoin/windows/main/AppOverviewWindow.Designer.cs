namespace CSharpCoin.windows.main
{
    partial class AppOverviewWindow
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelBalance = new System.Windows.Forms.Panel();
            this.lblBalanceLineBottom = new System.Windows.Forms.Label();
            this.lblWallet = new System.Windows.Forms.Label();
            this.lblUnconfirmed = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblBalanceLineTop = new System.Windows.Forms.Label();
            this.panelTransactions = new System.Windows.Forms.Panel();
            this.lblTransactionsLineTop = new System.Windows.Forms.Label();
            this.lblRecentTransactions = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel.SuspendLayout();
            this.panelBalance.SuspendLayout();
            this.panelTransactions.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.panelBalance, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panelTransactions, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 425);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // panelBalance
            // 
            this.panelBalance.Controls.Add(this.lblBalanceLineBottom);
            this.panelBalance.Controls.Add(this.lblWallet);
            this.panelBalance.Controls.Add(this.lblUnconfirmed);
            this.panelBalance.Controls.Add(this.lblBalance);
            this.panelBalance.Controls.Add(this.lbl2);
            this.panelBalance.Controls.Add(this.lbl1);
            this.panelBalance.Controls.Add(this.lblBalanceLineTop);
            this.panelBalance.Location = new System.Drawing.Point(3, 3);
            this.panelBalance.Name = "panelBalance";
            this.panelBalance.Size = new System.Drawing.Size(394, 419);
            this.panelBalance.TabIndex = 0;
            // 
            // lblBalanceLineBottom
            // 
            this.lblBalanceLineBottom.AutoSize = true;
            this.lblBalanceLineBottom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceLineBottom.Location = new System.Drawing.Point(3, 126);
            this.lblBalanceLineBottom.Name = "lblBalanceLineBottom";
            this.lblBalanceLineBottom.Size = new System.Drawing.Size(383, 17);
            this.lblBalanceLineBottom.TabIndex = 6;
            this.lblBalanceLineBottom.Text = "___________________________________________________________________________\r\n";
            // 
            // lblWallet
            // 
            this.lblWallet.AutoSize = true;
            this.lblWallet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWallet.Location = new System.Drawing.Point(167, 15);
            this.lblWallet.Name = "lblWallet";
            this.lblWallet.Size = new System.Drawing.Size(47, 17);
            this.lblWallet.TabIndex = 0;
            this.lblWallet.Text = "Wallet";
            // 
            // lblUnconfirmed
            // 
            this.lblUnconfirmed.AutoSize = true;
            this.lblUnconfirmed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnconfirmed.Location = new System.Drawing.Point(119, 100);
            this.lblUnconfirmed.Name = "lblUnconfirmed";
            this.lblUnconfirmed.Size = new System.Drawing.Size(15, 17);
            this.lblUnconfirmed.TabIndex = 4;
            this.lblUnconfirmed.Text = "0";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(119, 73);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(15, 17);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "0";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(30, 100);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(86, 17);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Unconfirmed:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(30, 73);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(55, 17);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Balance:";
            // 
            // lblBalanceLineTop
            // 
            this.lblBalanceLineTop.AutoSize = true;
            this.lblBalanceLineTop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceLineTop.Location = new System.Drawing.Point(3, 32);
            this.lblBalanceLineTop.Name = "lblBalanceLineTop";
            this.lblBalanceLineTop.Size = new System.Drawing.Size(383, 17);
            this.lblBalanceLineTop.TabIndex = 5;
            this.lblBalanceLineTop.Text = "___________________________________________________________________________\r\n";
            // 
            // panelTransactions
            // 
            this.panelTransactions.Controls.Add(this.lblTransactionsLineTop);
            this.panelTransactions.Controls.Add(this.lblRecentTransactions);
            this.panelTransactions.Location = new System.Drawing.Point(403, 3);
            this.panelTransactions.Name = "panelTransactions";
            this.panelTransactions.Size = new System.Drawing.Size(394, 419);
            this.panelTransactions.TabIndex = 1;
            // 
            // lblTransactionsLineTop
            // 
            this.lblTransactionsLineTop.AutoSize = true;
            this.lblTransactionsLineTop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionsLineTop.Location = new System.Drawing.Point(8, 32);
            this.lblTransactionsLineTop.Name = "lblTransactionsLineTop";
            this.lblTransactionsLineTop.Size = new System.Drawing.Size(383, 17);
            this.lblTransactionsLineTop.TabIndex = 6;
            this.lblTransactionsLineTop.Text = "___________________________________________________________________________\r\n";
            // 
            // lblRecentTransactions
            // 
            this.lblRecentTransactions.AutoSize = true;
            this.lblRecentTransactions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentTransactions.Location = new System.Drawing.Point(138, 15);
            this.lblRecentTransactions.Name = "lblRecentTransactions";
            this.lblRecentTransactions.Size = new System.Drawing.Size(130, 17);
            this.lblRecentTransactions.TabIndex = 0;
            this.lblRecentTransactions.Text = "Recent Transactions";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tableLayoutPanel);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 425);
            this.panelMain.TabIndex = 1;
            // 
            // AppOverviewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Name = "AppOverviewWindow";
            this.Text = "Overview";
            this.Controls.SetChildIndex(this.panelMain, 0);
            this.tableLayoutPanel.ResumeLayout(false);
            this.panelBalance.ResumeLayout(false);
            this.panelBalance.PerformLayout();
            this.panelTransactions.ResumeLayout(false);
            this.panelTransactions.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panelBalance;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblWallet;
        private System.Windows.Forms.Panel panelTransactions;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblRecentTransactions;
        private System.Windows.Forms.Label lblUnconfirmed;
        private System.Windows.Forms.Label lblBalanceLineBottom;
        private System.Windows.Forms.Label lblBalanceLineTop;
        private System.Windows.Forms.Label lblTransactionsLineTop;
        public System.Windows.Forms.Label lblBalance;
    }
}