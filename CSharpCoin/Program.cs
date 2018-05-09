using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Diagnostics;
using CSharpCoin.db;

namespace CSharpCoin
{
    class Program
    {
        public static List<Block> blockchain = new List<Block>();
        public static Dictionary<String, TransactionOutput> UTXOs = new Dictionary<String, TransactionOutput>();
        public static int difficulty = 1;
        public static double minimumTransaction = 0.1; // Valor mínimo para efetuar uma transação
        public static Wallet walletA;
        public static Wallet walletB;
        public static Transaction genesisTransaction;

        static void Main(string[] args)
        {
            // --- TESTE BANCO DE DADOS ---

            CoinDatabaseDAO db = new CoinDatabaseDAO();

            /*db.WriteToWalletSQL("batata", "hamburguer", "100.00");
            db.WriteToWalletSQL("batata", "hamburguer", "200.00");
            db.WriteToWalletSQL("batata", "hamburguer", "300.00");
            db.WriteToWalletSQL("batata", "hamburguer", "800.00");*/
            /*Debug.WriteLine(db.GetRowCountSQL("C_WALLET"));
            String[] test = db.ReadFromWalletSQL(1);
            Debug.WriteLine("TESTE CARTEIRA SQL");
            Debug.WriteLine(test[0] + ", " + test[1] + ", " + test[2] + ", " + test[3]);

            Debug.WriteLine(db.DataExistsWalletSQL());*/

            /*// Lê os dados do banco de dados e preenche o UTXOs
            if(db.GetRowCountSQL("C_UTXOS") > 0)
            {
                for(int i = 0; i < db.GetRowCountSQL("C_UTXOS"); i++)
                {
                    String[] recipiente = db.ReadFromUTXOSQL(i);
                    TransactionOutput output = new TransactionOutput(recipiente[2], Convert.ToDouble(recipiente[3]), recipiente[4]);
                    UTXOs.Add(recipiente[1] + "A", output);
                }
            }*/
                


            // --------------------------------------


            // --- INICIALIZAÇÃO DO CONSOLE DEBUG ---

            // Instancia as novas carteiras

            Wallet coinbase = new Wallet();

            walletA = new Wallet();
            db.WriteToWalletSQL(StringUtil.GetStringFromPublicKey(walletA.keyParameters), StringUtil.GetStringFromPrivateKey(walletA.keyParameters), walletA.GetBalance());
            walletB = new Wallet();
            db.WriteToWalletSQL(StringUtil.GetStringFromPublicKey(walletB.keyParameters), StringUtil.GetStringFromPrivateKey(walletB.keyParameters), walletB.GetBalance());

            

            // Cria a transação GENESIS, na qual envia 100 CSharpCoins para a walletA:
            genesisTransaction = new Transaction(coinbase.keyParameters, walletA.keyParameters, 100, null);
            genesisTransaction.GenerateSignature(coinbase.keyParameters); // Assina manualmente a transação GENESIS
            genesisTransaction.transactionId = "0"; // Seta manualmente o ID de transação
            genesisTransaction.outputs.Add(new TransactionOutput(StringUtil.GetStringFromPublicKey(genesisTransaction.reciepient), genesisTransaction.value, genesisTransaction.transactionId)); // Manualmente adiciona as saídas da transação
            //UTXOs.Add(genesisTransaction.outputs[0].id, genesisTransaction.outputs[0]); // SUBSTITUÍDO PELO BANCO DE DADOS
            db.WriteToUTXOSQL(genesisTransaction.outputs[0].id, genesisTransaction.outputs[0].reciepient, genesisTransaction.outputs[0].value, genesisTransaction.outputs[0].parentTransactionId); // É importante armazenar a nossa primeira transação na lista de UTXOs
            
            // Lê os dados do banco de dados e preenche o UTXOs
            if (db.GetRowCountSQL("C_UTXOS") > 0)
            {
                for (int i = 1; i <= db.GetRowCountSQL("C_UTXOS"); i++)
                {
                    String[] recipiente = db.ReadFromUTXOSQL(i);
                    TransactionOutput output = new TransactionOutput(recipiente[2], Convert.ToDouble(recipiente[3]), recipiente[4]);
                    UTXOs.Add(recipiente[1], output);
                }
            }
            

           Debug.WriteLine("\n-------------------------------------------------------------------------------\n");

            Debug.WriteLine("#Criando e minerando o Bloco GENESIS...");
            Block genesis = new Block("0");
            genesis.AddTransaction(genesisTransaction);
            AddBlock(genesis);

            // TESTE 
            Block block1 = new Block(genesis.hash);
            Debug.WriteLine("\nO saldo da carteiraA é: " + walletA.GetBalance());
            Debug.WriteLine("\nA carteiraA está tentando enviar fundos (40) para a carteiraB...");
            block1.AddTransaction(walletA.SendFunds(walletB.keyParameters, 40));
            AddBlock(block1);
            Debug.WriteLine("\nO saldo da carteiraA é: " + walletA.GetBalance());
            Debug.WriteLine("O saldo da carteiraB é: " + walletB.GetBalance());

            // TESTE 
            Block block2 = new Block(block1.hash);
            Debug.WriteLine("\nA carteiraA está tentando enviar mais fundos (1000) do que se tem de saldo...");
            block2.AddTransaction(walletA.SendFunds(walletB.keyParameters, 1000));
            AddBlock(block2);
            Debug.WriteLine("\nO saldo da carteiraA é: " + walletA.GetBalance());
            Debug.WriteLine("O saldo da carteiraB é: " + walletB.GetBalance());

            // TESTE 
            Block block3 = new Block(block2.hash);
            Debug.WriteLine("\nA carteiraB está tentando enviar fundos (20) para a carteiraA...");
            block1.AddTransaction(walletB.SendFunds(walletA.keyParameters, 20));
            AddBlock(block3);
            Debug.WriteLine("\nO saldo da carteiraA é: " + walletA.GetBalance());
            Debug.WriteLine("O saldo da carteiraB é: " + walletB.GetBalance());

            IsChainValid();
            
            Debug.WriteLine("\n-------------------------------------------------------------------------------\n");

            // --- INICIALIZAÇÃO DO WINDOWS FORMS ---

            Application.EnableVisualStyles();
            Application.Run(new AppMainWindow());

            // --------------------------------------
        }


        // ---------------------------
        // -------------------------------
        // MÉTODOS DA CLASSE PRINCIPAL
        // -------------------------------
        // ---------------------------


        // Verifica se o BlockChain é válido
        public static bool IsChainValid()
        {
            Block currentBlock;
            Block previousBlock;

            Dictionary<String, TransactionOutput> tempUTXOs = new Dictionary<String, TransactionOutput>(); // Uma lista de trabalho temporário de transações não gastas em um determinado estado de um bloco.
            tempUTXOs.Add(genesisTransaction.outputs[0].id, genesisTransaction.outputs[0]);

            // Loop pelo BLOCKCHAIN para checar as HASHES
            for(int i=1; i < blockchain.Count(); i++)
            {
                currentBlock = blockchain[i];
                previousBlock = blockchain[i - 1];
                // Compara a HASH registrada e a calculada
                if (!currentBlock.hash.Equals(currentBlock.CalculateHash()))
                {
                    Debug.WriteLine("#Hashes atuais não estão iguais!");
                    return false;
                }
                // Compara a HASH anterior e a registrada anteriormente
                if (!previousBlock.hash.Equals(currentBlock.previousHash))
                {
                    Debug.WriteLine("#Hashes anteriores não estão iguais!");
                    return false;
                }
                // Verifica se o HASH foi solucionado
                // EM CONSTRUÇÃO...

                // Loop pelas transações de BlockChains
                TransactionOutput tempOutput;
                for(int t = 0; t < currentBlock.transactions.Count; t++)
                {
                    Transaction currentTransaction = currentBlock.transactions[t];

                    if (!currentTransaction.VerifySignature())
                    {
                        Debug.WriteLine("#A assinatura na Transação(" + t + ") é inválida.");
                        return false;
                    }
                    if(currentTransaction.GetInputsValue() != currentTransaction.GetOutputsValue())
                    {
                        Debug.WriteLine("#As entradas e saídas não são iguais na Transação(" + t + ")");
                    }

                    foreach(TransactionInput input in currentTransaction.inputs)
                    {
                        tempOutput = tempUTXOs[input.transactionOutputId];

                        if(tempOutput == null)
                        {
                            Debug.WriteLine("#A entrada referenciada na Transação(" + t + ") está faltando.");
                            return false;
                        }

                        if(input.UTXO.value != tempOutput.value)
                        {
                            Debug.WriteLine("#A entrada referenciada na Transação(" + t + ") está inválida.");
                            return false;
                        }

                        tempUTXOs.Remove(input.transactionOutputId);
                    }

                    foreach(TransactionOutput output in currentTransaction.outputs)
                    {
                        tempUTXOs.Add(output.id, output);
                    }

                    if(currentTransaction.outputs[0].reciepient != StringUtil.GetStringFromPublicKey(currentTransaction.reciepient))
                    {
                        Debug.WriteLine("#Na Transação(" + t + ") o destinatário de saída não é quem deveria ser.");
                        return false;
                    }

                    if(currentTransaction.outputs[1].reciepient != StringUtil.GetStringFromPublicKey(currentTransaction.sender))
                    {
                        Debug.WriteLine("#Na Transação(" + t + ") saída 'mudança' não é o Remetente.");
                        return false;
                    }
                }
            }

            Debug.WriteLine("\n#O BlockChain é válido!");
            return true;
        }

        public static void AddBlock(Block newBlock)
        {
            newBlock.mineBlock(difficulty);
            blockchain.Add(newBlock);
        }
    }
}