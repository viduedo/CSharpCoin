using CSharpCoin.windows.debug;
using CSharpCoin.windows.main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCoin
{
    public partial class AppMainWindow : Form
    {
        public AppMainWindow()
        {
            InitializeComponent();

            // Inicializa o Form OVERVIEW
            AppOverviewWindow newMdiChild = new AppOverviewWindow();
            // Aplica o Form PAI no Form FILHO
            newMdiChild.MdiParent = this;
            // Desabilita o ControlBox (Minimizar, Maximizar e Fechar)
            newMdiChild.ControlBox = false;
            // Maximiza a Janela
            newMdiChild.WindowState = FormWindowState.Maximized;
            // Mostra o novo Form
            newMdiChild.Show();
        }

        // ---------------------------
        // --- MENU DE BAIXO ---
        // ---------------------------

        private void mnuOverview_Click(object sender, EventArgs e)
        {
            CloseForms();
            AppOverviewWindow newMdiChild = new AppOverviewWindow();
            newMdiChild.MdiParent = this;
            newMdiChild.ControlBox = false;
            newMdiChild.WindowState = FormWindowState.Maximized;
            newMdiChild.Show();
        }

        private void mnuSend_Click(object sender, EventArgs e)
        {
            CloseForms();
            AppSendWindow newMdiChild = new AppSendWindow();
            newMdiChild.MdiParent = this;
            newMdiChild.ControlBox = false;
            newMdiChild.WindowState = FormWindowState.Maximized;
            newMdiChild.Show();
        }

        private void mnuReceive_Click(object sender, EventArgs e)
        {
            CloseForms();
            AppReceiveWindow newMdiChild = new AppReceiveWindow();
            newMdiChild.MdiParent = this;
            newMdiChild.ControlBox = false;
            newMdiChild.WindowState = FormWindowState.Maximized;
            newMdiChild.Show();
        }

        private void mnuTransactions_Click(object sender, EventArgs e)
        {
            CloseForms();
            AppTransactionsWindow newMdiChild = new AppTransactionsWindow();
            newMdiChild.MdiParent = this;
            newMdiChild.ControlBox = false;
            newMdiChild.WindowState = FormWindowState.Maximized;
            newMdiChild.Show();
        }

        private void mnuAdresses_Click(object sender, EventArgs e)
        {
            CloseForms();
            AppAdressesWindow newMdiChild = new AppAdressesWindow();
            newMdiChild.MdiParent = this;
            newMdiChild.ControlBox = false;
            newMdiChild.WindowState = FormWindowState.Maximized;
            newMdiChild.Show();
        }

        // ---------------------------
        // --- MENU DO TOPO ---
        // ---------------------------

        private void mnuItemExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void mnuItemEncryptWallet_Click(object sender, EventArgs e)
        {

        }

        private void mnuItemChangePass_Click(object sender, EventArgs e)
        {

        }

        private void mnuItemDecryptWallet_Click(object sender, EventArgs e)
        {

        }

        private void mnuItemOptions_Click(object sender, EventArgs e)
        {

        }

        private void mnuItemDebug_Click(object sender, EventArgs e)
        {
            DebugMainWindow debug = new DebugMainWindow();
            debug.Show();
        }

        private void mnuItemAboutCSharpCoinCore_Click(object sender, EventArgs e)
        {

        }

        private void mnuItemAboutDotNet_Click(object sender, EventArgs e)
        {

        }

        // Desabilita o ÍCONE das Janelas no MdiContainer (deixa invisível)
        private void mainMenu_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            if (e.Item.Text == "")
            {
                e.Item.Visible = false;
            }
        }



        // Fecha todos os Forms do MdiContainer
        private void CloseForms()
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Dispose();
            }
        }

    }
}
