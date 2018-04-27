namespace CSharpCoin
{
    partial class AppMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppMainWindow));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuOverview = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSend = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReceive = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransactions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdresses = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemEncryptWallet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemDecryptWallet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItemAboutCSharpCoinCore = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAboutDotNet = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.toolbarMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOverview,
            this.mnuSend,
            this.mnuReceive,
            this.mnuTransactions,
            this.mnuAdresses});
            this.mainMenu.Location = new System.Drawing.Point(0, 24);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(933, 44);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenu";
            this.mainMenu.ItemAdded += new System.Windows.Forms.ToolStripItemEventHandler(this.mainMenu_ItemAdded);
            // 
            // mnuOverview
            // 
            this.mnuOverview.AutoSize = false;
            this.mnuOverview.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuOverview.Image = ((System.Drawing.Image)(resources.GetObject("mnuOverview.Image")));
            this.mnuOverview.Name = "mnuOverview";
            this.mnuOverview.Size = new System.Drawing.Size(89, 40);
            this.mnuOverview.Text = "Overview";
            this.mnuOverview.Click += new System.EventHandler(this.mnuOverview_Click);
            // 
            // mnuSend
            // 
            this.mnuSend.AutoSize = false;
            this.mnuSend.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuSend.Image = ((System.Drawing.Image)(resources.GetObject("mnuSend.Image")));
            this.mnuSend.Name = "mnuSend";
            this.mnuSend.Size = new System.Drawing.Size(65, 40);
            this.mnuSend.Text = "Send";
            this.mnuSend.Click += new System.EventHandler(this.mnuSend_Click);
            // 
            // mnuReceive
            // 
            this.mnuReceive.AutoSize = false;
            this.mnuReceive.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuReceive.Image = ((System.Drawing.Image)(resources.GetObject("mnuReceive.Image")));
            this.mnuReceive.Name = "mnuReceive";
            this.mnuReceive.Size = new System.Drawing.Size(80, 40);
            this.mnuReceive.Text = "Receive";
            this.mnuReceive.Click += new System.EventHandler(this.mnuReceive_Click);
            // 
            // mnuTransactions
            // 
            this.mnuTransactions.AutoSize = false;
            this.mnuTransactions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTransactions.Image = ((System.Drawing.Image)(resources.GetObject("mnuTransactions.Image")));
            this.mnuTransactions.Name = "mnuTransactions";
            this.mnuTransactions.Size = new System.Drawing.Size(108, 40);
            this.mnuTransactions.Text = "Transactions";
            this.mnuTransactions.Click += new System.EventHandler(this.mnuTransactions_Click);
            // 
            // mnuAdresses
            // 
            this.mnuAdresses.AutoSize = false;
            this.mnuAdresses.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAdresses.Image = ((System.Drawing.Image)(resources.GetObject("mnuAdresses.Image")));
            this.mnuAdresses.Name = "mnuAdresses";
            this.mnuAdresses.Size = new System.Drawing.Size(89, 40);
            this.mnuAdresses.Text = "Adresses";
            this.mnuAdresses.Click += new System.EventHandler(this.mnuAdresses_Click);
            // 
            // toolbarMenu
            // 
            this.toolbarMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolbarMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuSettings,
            this.mnuHelp});
            this.toolbarMenu.Location = new System.Drawing.Point(0, 0);
            this.toolbarMenu.Name = "toolbarMenu";
            this.toolbarMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.toolbarMenu.Size = new System.Drawing.Size(933, 24);
            this.toolbarMenu.TabIndex = 1;
            this.toolbarMenu.Text = "toolbarMenu";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuItemExit
            // 
            this.mnuItemExit.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemExit.Image")));
            this.mnuItemExit.Name = "mnuItemExit";
            this.mnuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuItemExit.Size = new System.Drawing.Size(180, 22);
            this.mnuItemExit.Text = "Exit";
            this.mnuItemExit.Click += new System.EventHandler(this.mnuItemExit_Click);
            // 
            // mnuSettings
            // 
            this.mnuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemEncryptWallet,
            this.mnuItemChangePass,
            this.mnuItemDecryptWallet,
            this.toolStripSeparator1,
            this.mnuItemOptions});
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.Size = new System.Drawing.Size(61, 20);
            this.mnuSettings.Text = "Settings";
            // 
            // mnuItemEncryptWallet
            // 
            this.mnuItemEncryptWallet.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemEncryptWallet.Image")));
            this.mnuItemEncryptWallet.Name = "mnuItemEncryptWallet";
            this.mnuItemEncryptWallet.Size = new System.Drawing.Size(185, 22);
            this.mnuItemEncryptWallet.Text = "Encrypt Wallet...";
            this.mnuItemEncryptWallet.Click += new System.EventHandler(this.mnuItemEncryptWallet_Click);
            // 
            // mnuItemChangePass
            // 
            this.mnuItemChangePass.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemChangePass.Image")));
            this.mnuItemChangePass.Name = "mnuItemChangePass";
            this.mnuItemChangePass.Size = new System.Drawing.Size(185, 22);
            this.mnuItemChangePass.Text = "Change Passphrase...";
            this.mnuItemChangePass.Click += new System.EventHandler(this.mnuItemChangePass_Click);
            // 
            // mnuItemDecryptWallet
            // 
            this.mnuItemDecryptWallet.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemDecryptWallet.Image")));
            this.mnuItemDecryptWallet.Name = "mnuItemDecryptWallet";
            this.mnuItemDecryptWallet.Size = new System.Drawing.Size(185, 22);
            this.mnuItemDecryptWallet.Text = "Unlock Wallet...";
            this.mnuItemDecryptWallet.Click += new System.EventHandler(this.mnuItemDecryptWallet_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // mnuItemOptions
            // 
            this.mnuItemOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemOptions.Image")));
            this.mnuItemOptions.Name = "mnuItemOptions";
            this.mnuItemOptions.Size = new System.Drawing.Size(185, 22);
            this.mnuItemOptions.Text = "Options...";
            this.mnuItemOptions.Click += new System.EventHandler(this.mnuItemOptions_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemDebug,
            this.toolStripSeparator2,
            this.mnuItemAboutCSharpCoinCore,
            this.mnuItemAboutDotNet});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuItemDebug
            // 
            this.mnuItemDebug.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemDebug.Image")));
            this.mnuItemDebug.Name = "mnuItemDebug";
            this.mnuItemDebug.Size = new System.Drawing.Size(201, 22);
            this.mnuItemDebug.Text = "Debug Window";
            this.mnuItemDebug.Click += new System.EventHandler(this.mnuItemDebug_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(198, 6);
            // 
            // mnuItemAboutCSharpCoinCore
            // 
            this.mnuItemAboutCSharpCoinCore.Name = "mnuItemAboutCSharpCoinCore";
            this.mnuItemAboutCSharpCoinCore.Size = new System.Drawing.Size(201, 22);
            this.mnuItemAboutCSharpCoinCore.Text = "About CSharpCoin Core";
            this.mnuItemAboutCSharpCoinCore.Click += new System.EventHandler(this.mnuItemAboutCSharpCoinCore_Click);
            // 
            // mnuItemAboutDotNet
            // 
            this.mnuItemAboutDotNet.Name = "mnuItemAboutDotNet";
            this.mnuItemAboutDotNet.Size = new System.Drawing.Size(201, 22);
            this.mnuItemAboutDotNet.Text = "About .NET";
            this.mnuItemAboutDotNet.Click += new System.EventHandler(this.mnuItemAboutDotNet_Click);
            // 
            // AppMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 589);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.toolbarMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AppMainWindow";
            this.Text = "CSharpCoin - Wallet";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.toolbarMenu.ResumeLayout(false);
            this.toolbarMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuOverview;
        private System.Windows.Forms.ToolStripMenuItem mnuSend;
        private System.Windows.Forms.ToolStripMenuItem mnuReceive;
        private System.Windows.Forms.MenuStrip toolbarMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSettings;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuTransactions;
        private System.Windows.Forms.ToolStripMenuItem mnuAdresses;
        private System.Windows.Forms.ToolStripMenuItem mnuItemEncryptWallet;
        private System.Windows.Forms.ToolStripMenuItem mnuItemChangePass;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuItemOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuItemExit;
        private System.Windows.Forms.ToolStripMenuItem mnuItemDecryptWallet;
        private System.Windows.Forms.ToolStripMenuItem mnuItemDebug;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAboutCSharpCoinCore;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAboutDotNet;
    }
}