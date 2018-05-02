using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

namespace CSharpCoin.db
{
    class CoinDatabaseDAO
    {
        // conexao com o banco de dados
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db\CoinDatabase.mdf;Integrated Security=True");
        private SqlTransaction transaction;

        public Int32 GetRowCountBlockchainSQL()
        {
            conn.Open();

            transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                SqlCommand sql = new SqlCommand("SELECT COUNT(*) FROM C_BLOCKCHAIN", conn, transaction);

                Int32 rowCount = (Int32) sql.ExecuteScalar();     

                sql.ExecuteNonQuery();
                transaction.Commit();
                conn.Close();
                return rowCount;
            }
            catch (SqlException ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);
                return 0;
            }
        }


        public void WriteToBlockchainSQL(String blockHash, String transactionHash)
        {
            // abre a conexão;
            conn.Open();

            // inicia a transação
            transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                // instrução sql
                SqlCommand sql = new SqlCommand("INSERT INTO C_BLOCKCHAIN (block_hash, transaction_hash)" + 
                                                " VALUES (@block_hash, @transaction_hash)", conn, transaction);

                // parametros da instrução sql
                sql.Parameters.AddWithValue("@block_hash", blockHash);
                sql.Parameters.AddWithValue("@transaction_hash", transactionHash);
                sql.ExecuteNonQuery(); // executa a instrução no banco
                transaction.Commit(); // commita a transação
                conn.Close();  // fecha a conexao
            }
            catch (SqlException ex)
            {
                // Rollback na transação
                transaction.Rollback();
                MessageBox.Show(ex.Message);
            }
        }

        public String[] ReadFromBlockchainSQL(int blockID)
        {
            conn.Open();

            transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                SqlCommand sql = new SqlCommand("SELECT codblock, block_hash, transaction_hash" +
                                                " FROM C_BLOCKCHAIN WHERE CODBLOCK = " + blockID, conn, transaction);

                SqlDataReader dataReader = sql.ExecuteReader();

                // Cria um Array de string para preencher com os dados da tabela
                
                String[] data = new String[3];

                // Pega cada coluna da tabela e coloca no Array
                while (dataReader.Read())
                {
                    data[0] = dataReader["codblock"].ToString();
                    data[1] = dataReader["block_hash"].ToString();
                    data[2] = dataReader["transaction_hash"].ToString();
                }

                dataReader.Close(); // Fecha a conexão de leitura

                sql.ExecuteNonQuery();
                transaction.Commit();
                conn.Close();
                return data;
            }
            catch (SqlException ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void WriteToWalletSQL(String publicKeyHash, String privateKeyHash, String balanceHash)
        {
            conn.Open();
            
            transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                SqlCommand sql = new SqlCommand("INSERT INTO C_WALLET (publickey_hash, privatekey_hash, balance_hash)" +
                                                " VALUES (@publickey_hash, @privatekey_hash, @balance_hash)", conn, transaction);

                sql.Parameters.AddWithValue("@publickey_hash", publicKeyHash);
                sql.Parameters.AddWithValue("@privatekey_hash", privateKeyHash);
                sql.Parameters.AddWithValue("@balance_hash", balanceHash);
                sql.ExecuteNonQuery(); 
                transaction.Commit(); 
                conn.Close(); 
            }
            catch (SqlException ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);
            }
        }

        public String[] ReadFromWalletSQL(int walletID)
        {
            conn.Open();

            transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                SqlCommand sql = new SqlCommand("SELECT publickey_hash, privatekey_hash, balance_hash" +
                                                " FROM C_WALLET WHERE CODWALLET = " + walletID, conn, transaction);

                SqlDataReader dataReader = sql.ExecuteReader();

                // Cria um Array de string para preencher com os dados da tabela
                String[] data = new String[3];

                // Pega cada coluna da tabela e coloca no Array
                while (dataReader.Read())
                {
                    data[0] = dataReader["publickey_hash"].ToString();
                    data[1] = dataReader["privatekey_hash"].ToString();
                    data[2] = dataReader["balance_hash"].ToString();
                }

                dataReader.Close(); // Fecha a conexão de leitura

                sql.ExecuteNonQuery();
                transaction.Commit();
                conn.Close();
                return data;
            }
            catch (SqlException ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
