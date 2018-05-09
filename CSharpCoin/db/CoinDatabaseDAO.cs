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
        // Conexão com o banco de dados
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db\CoinDatabase.mdf;Integrated Security=True");
        private SqlTransaction transaction;

        // MÉTODOS:
        // GetRowCount -> Conta as linhas de uma tabela especificada
        // WriteTo -> Escreve dados em uma tabela
        // ReadFrom -> Lê dados de uma tabela
        // DataExists -> Verifica se há dados na tabela

        public bool DataExistsWalletSQL()
        {
            conn.Open();

            transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                SqlCommand sql = new SqlCommand("SELECT TOP 1 WALLET_ID FROM C_WALLET", conn, transaction);
                if(sql.ExecuteScalar() == null) // SE o número de linhas afetadas for nulo
                {
                    transaction.Commit();
                    conn.Close();
                    return false; // retorna falso
                }
                else // SENÃO
                {
                    transaction.Commit();
                    conn.Close();
                    return true; // retorna verdadeiro
                }
            }
            catch (SqlException ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public Int32 GetRowCountSQL(String tableName)
        {
            conn.Open();

            transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                SqlCommand sql = new SqlCommand("SELECT COUNT(*) FROM " + tableName, conn, transaction);

                Int32 rowCount = (Int32)sql.ExecuteScalar();

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

        public String[] ReadFromUTXOSQL(int utxosID)
        {
            conn.Open();

            transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                SqlCommand sql = new SqlCommand("SELECT UTXOS_ID, output_id, output_reciepient, output_value, output_parentTransactionId" +
                                                " FROM C_UTXOS WHERE UTXOS_ID = " + utxosID, conn, transaction);

                SqlDataReader dataReader = sql.ExecuteReader();

                // Cria um Array de string para preencher com os dados da tabela
                String[] data = new String[5];

                // Pega cada coluna da tabela e coloca no Array
                while (dataReader.Read())
                {
                    data[0] = dataReader["UTXOS_ID"].ToString();
                    data[1] = dataReader["output_id"].ToString();
                    data[2] = dataReader["output_reciepient"].ToString();
                    data[3] = dataReader["output_value"].ToString();
                    data[4] = dataReader["output_parentTransactionId"].ToString();
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

        public void WriteToUTXOSQL(String id, String output_reciepient, double output_value, String output_parentTransactionId)
        {
            conn.Open();

            transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                SqlCommand sql = new SqlCommand("INSERT INTO C_UTXOS (output_id, output_reciepient, output_value, output_parentTransactionId)" +
                                                " VALUES (@output_id, @output_reciepient, @output_value, @output_parentTransactionId)", conn, transaction);

                sql.Parameters.AddWithValue("@output_id", id);
                sql.Parameters.AddWithValue("@output_reciepient", output_reciepient);
                sql.Parameters.AddWithValue("@output_value", output_value);
                sql.Parameters.AddWithValue("@output_parentTransactionId", output_parentTransactionId);
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

        public void WriteToWalletSQL(String publicKey, String privateKey, double balance)
        {
            conn.Open();
            
            transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                SqlCommand sql = new SqlCommand("INSERT INTO C_WALLET (publicKey, privateKey, balance)" +
                                                " VALUES (@publicKey, @privateKey, @balance)", conn, transaction);

                sql.Parameters.AddWithValue("@publicKey", publicKey);
                sql.Parameters.AddWithValue("@privateKey", privateKey);
                sql.Parameters.AddWithValue("@balance", balance);
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
                SqlCommand sql = new SqlCommand("SELECT WALLET_ID, publicKey, privateKey, balance" +
                                                " FROM C_WALLET WHERE WALLET_ID = " + walletID, conn, transaction);

                SqlDataReader dataReader = sql.ExecuteReader();

                // Cria um Array de string para preencher com os dados da tabela
                String[] data = new String[4];

                // Pega cada coluna da tabela e coloca no Array
                while (dataReader.Read())
                {
                    data[0] = dataReader["WALLET_ID"].ToString();
                    data[1] = dataReader["publicKey"].ToString();
                    data[2] = dataReader["privateKey"].ToString();
                    data[3] = dataReader["balance"].ToString();
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
