using CSharpCoin.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCoin.windows.main
{
    public partial class AppOverviewWindow : FormBase
    {
        public static int walletID = 1;

        public AppOverviewWindow()
        {
            InitializeComponent();
            lblBalance.Text = GetBalance();
            // Cria um Timer para atualizar o saldo a cada 500ms (0.5s)
            var timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = 500;
            timer.Start();
        }

        // Alterações que o Timer faz...
        private void Timer_Tick(object sender, EventArgs e)
        {
            lblBalance.Text = GetBalance();
        }

        // Retorna o saldo da carteira
        public static String GetBalance()
        {
            // Seta os Parâmetros de acordo com os dados do DB
            CoinDatabaseDAO db = new CoinDatabaseDAO();
            String[] dbParameters = new String[3];
            dbParameters = db.ReadFromWalletSQL(walletID);
            return dbParameters[3] + " C#";
        }

        public void UpdateBalance()
        {
            lblBalance.Text = GetBalance();
        }
    }
}
