using CSharpCoin.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCoin.windows.main
{
    public partial class AppOverviewWindow : FormBase
    {
        public AppOverviewWindow()
        {
            InitializeComponent();

            lblBalance.Text = GetBalance();
        }

        // Retorna o saldo da carteira 1
        public String GetBalance()
        {
            // Seta os Parâmetros de acordo com os dados do DB
            CoinDatabaseDAO db = new CoinDatabaseDAO();
            String[] dbParameters = new String[3];
            dbParameters = db.ReadFromWalletSQL(1);
            return dbParameters[2] + " C#";
        }
    }
}
