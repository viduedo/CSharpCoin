namespace CSharpCoin.windows.main
{
    partial class FormBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.lblProgressBar = new System.Windows.Forms.ToolStripLabel();
            this.pbProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblSync = new System.Windows.Forms.ToolStripLabel();
            this.lblConnection = new System.Windows.Forms.ToolStripLabel();
            this.lblLock = new System.Windows.Forms.ToolStripLabel();
            this.toolStripBase = new System.Windows.Forms.ToolStrip();
            this.toolStripBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProgressBar
            // 
            this.lblProgressBar.Name = "lblProgressBar";
            this.lblProgressBar.Size = new System.Drawing.Size(172, 22);
            this.lblProgressBar.Text = " Synchronizing with network ... ";
            // 
            // pbProgressBar
            // 
            this.pbProgressBar.Name = "pbProgressBar";
            this.pbProgressBar.Size = new System.Drawing.Size(400, 22);
            this.pbProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbProgressBar.Tag = "";
            // 
            // lblSync
            // 
            this.lblSync.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblSync.Image = ((System.Drawing.Image)(resources.GetObject("lblSync.Image")));
            this.lblSync.Name = "lblSync";
            this.lblSync.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSync.Size = new System.Drawing.Size(38, 22);
            this.lblSync.Text = "     ";
            this.lblSync.ToolTipText = "Synchronizing...";
            // 
            // lblConnection
            // 
            this.lblConnection.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblConnection.Image = ((System.Drawing.Image)(resources.GetObject("lblConnection.Image")));
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblConnection.Size = new System.Drawing.Size(26, 22);
            this.lblConnection.Text = " ";
            this.lblConnection.ToolTipText = "0 Connections";
            // 
            // lblLock
            // 
            this.lblLock.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblLock.Image = ((System.Drawing.Image)(resources.GetObject("lblLock.Image")));
            this.lblLock.Name = "lblLock";
            this.lblLock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLock.Size = new System.Drawing.Size(26, 22);
            this.lblLock.Text = " ";
            this.lblLock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLock.ToolTipText = "Encrypted";
            // 
            // toolStripBase
            // 
            this.toolStripBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripBase.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblProgressBar,
            this.pbProgressBar,
            this.lblSync,
            this.lblConnection,
            this.lblLock});
            this.toolStripBase.Location = new System.Drawing.Point(0, 425);
            this.toolStripBase.Name = "toolStripBase";
            this.toolStripBase.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripBase.Size = new System.Drawing.Size(800, 25);
            this.toolStripBase.TabIndex = 0;
            this.toolStripBase.Text = "toolStrip1";
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormBase";
            this.ShowIcon = false;
            this.Text = "FormBase";
            this.toolStripBase.ResumeLayout(false);
            this.toolStripBase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripLabel lblProgressBar;
        private System.Windows.Forms.ToolStripProgressBar pbProgressBar;
        private System.Windows.Forms.ToolStripLabel lblSync;
        private System.Windows.Forms.ToolStripLabel lblConnection;
        private System.Windows.Forms.ToolStripLabel lblLock;
        private System.Windows.Forms.ToolStrip toolStripBase;
    }
}