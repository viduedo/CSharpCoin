namespace CSharpCoin.windows.main
{
    partial class AppOptionsPopUp
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxWallets = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.coinDatabaseDataSet = new CSharpCoin.CoinDatabaseDataSet();
            this.coinDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coinDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinDatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboxWallets);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Change/Create your Wallet";
            // 
            // cboxWallets
            // 
            this.cboxWallets.FormattingEnabled = true;
            this.cboxWallets.Location = new System.Drawing.Point(20, 85);
            this.cboxWallets.Name = "cboxWallets";
            this.cboxWallets.Size = new System.Drawing.Size(121, 21);
            this.cboxWallets.TabIndex = 1;
            this.cboxWallets.SelectedIndexChanged += new System.EventHandler(this.cboxWallets_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // coinDatabaseDataSet
            // 
            this.coinDatabaseDataSet.DataSetName = "CoinDatabaseDataSet";
            this.coinDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coinDatabaseDataSetBindingSource
            // 
            this.coinDatabaseDataSetBindingSource.DataSource = this.coinDatabaseDataSet;
            this.coinDatabaseDataSetBindingSource.Position = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AppOptionsPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AppOptionsPopUp";
            this.Text = "AppOptionsPopUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coinDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinDatabaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxWallets;
        private System.Windows.Forms.Button button1;
        private CoinDatabaseDataSet coinDatabaseDataSet;
        private System.Windows.Forms.BindingSource coinDatabaseDataSetBindingSource;
        private System.Windows.Forms.Button button2;
    }
}