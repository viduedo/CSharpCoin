using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoin
{
    class Wallet
    {
        public String privateKey; // Chave privada.
        public String publicKey; // Chave publica.
        public RSAParameters keyParameters; // Objeto utilizado para armazenar chaves sem ser em forma de texto.

        // UTXO = Unspent Transaction Output ---> Saída de Transação não Gasta.
        public Dictionary<String, TransactionOutput> UTXOs = new Dictionary<String, TransactionOutput>();

        // CONSTRUTOR
        public Wallet()
        {
            GenerateKeyPair(); // Constrói o par de chaves.
        }

        // Gera um par de chaves pública/privada
        private void GenerateKeyPair()
        {
            // Create a new RSACryptoServiceProvider object.
            var rsa = new RSACryptoServiceProvider();
            privateKey = rsa.ToXmlString(true); // Gera a chave privada
            publicKey = rsa.ToXmlString(false); // Gera a chave pública

            // Export the key information to an RSAParameters object.
            // Pass false to export the public key information or pass
            // true to export public and private key information.
            keyParameters = rsa.ExportParameters(true);
        }

        public double GetBalance()
        {
            double total = 0;
            foreach(KeyValuePair<String, TransactionOutput> item in Program.UTXOs)
            {
                // EM CONSTRUÇÃO (CÓDIGO QUE PUXA INFORMAÇÕES DOS OUTPUTS DO BANCO DE DADOS)


                TransactionOutput UTXO = item.Value;
                if (UTXO.isMine(keyParameters)) // Se a saída pertence a mim ( se o dinheiro pertence a mim )
                {
                    // Verifica se a chave já existe no Dicionário
                    AddOrUpdateUTXOs(UTXO.id, UTXO);
                    //UTXOs.Add(UTXO.id, UTXO); // Adiciona na nossa lista de transações não gastas
                    total += UTXO.value;
                }
            }
            return total;
        }

        // Gera e retorna uma nova transação desta carteira
        public Transaction SendFunds(RSAParameters reciepient, double value)
        {
            if(GetBalance() < value) // Coleta o saldo e checa os fundos
            {
                Debug.WriteLine("#Sem fundos o suficiente efetuar uma transação. Transação Descartada.");
                return null;
            }
            // Cria uma Lista de entradas
            List<TransactionInput> inputs = new List<TransactionInput>();

            double total = 0;
            foreach(KeyValuePair<String, TransactionOutput> item in UTXOs)
            {
                TransactionOutput UTXO = item.Value;
                inputs.Add(new TransactionInput(UTXO.id));
                if (total > value) break;
            }

            Transaction newTransaction = new Transaction(keyParameters, reciepient, value, inputs);
            newTransaction.GenerateSignature(keyParameters);

            foreach(TransactionInput input in inputs)
            {
                UTXOs.Remove(input.transactionOutputId);
            }

            return newTransaction;
        }

        // Adiciona uma CHAVE com valores ou Atualiza os valores de uma CHAVE de um Dictionary 
        public void AddOrUpdateUTXOs(string key, TransactionOutput value)
        {
            if (UTXOs.ContainsKey(key))
            {
                UTXOs[key] = value;
            }
            else
            {
                UTXOs.Add(key, value);
            }
        }
    }
}
