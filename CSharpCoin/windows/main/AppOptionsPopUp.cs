using CSharpCoin.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCoin.windows.main
{

    public partial class AppOptionsPopUp : Form
    {
        int selectedValue = 1;

        public AppOptionsPopUp()
        {
            InitializeComponent();
            SetComboBox();
        }

        private void SetComboBox()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db\CoinDatabase.mdf;Integrated Security=True");
            SqlTransaction transaction;

            conn.Open();
            transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);

            try
            {
                SqlCommand sql = new SqlCommand("SELECT WALLET_ID FROM C_WALLET", conn, transaction);
                SqlDataReader reader;

                reader = sql.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Columns.Add("WALLET_ID", typeof(String));
                dt.Load(reader);

                cboxWallets.ValueMember = "WALLET_ID";
                cboxWallets.DisplayMember = "WALLET_ID";
                cboxWallets.DataSource = dt;

                conn.Close();

            }
            catch (SqlException ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);
            }
        }

        private void cboxWallets_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedValue = Convert.ToInt32(cboxWallets.SelectedValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppOverviewWindow.walletID = selectedValue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CoinDatabaseDAO db = new CoinDatabaseDAO();
            Wallet newWallet = new Wallet(); // Instancia uma WALLET nova
            AppOverviewWindow.walletID = db.GetRowCountSQL("C_WALLET") + 1; // Muda o walletID para o ID da WALLET nova
            db.WriteToWalletSQL(StringUtil.GetStringFromPublicKey(newWallet.keyParameters), StringUtil.GetStringFromPrivateKey(newWallet.keyParameters), newWallet.GetBalance()); // Preenche o banco de dados com os dados da Wallet
            SetComboBox(); // Atualiza o ComboBox
        }
    }
}
