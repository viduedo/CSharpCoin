using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoin
{
    class Block
    {
        public String hash; // assinatura digital
        public String previousHash; // assinatura anterior
        public String merkleRoot;
        public List<Transaction> transactions = new List<Transaction>(); // nossos dados será uma simples mensagem
        private long timeStamp; // numeros que compõem a data e hora do sistema (utilizado para dar um reforço na criptografia) 
        private int nonce; // Number Once (número usado apenas uma vez)

        // CONSTRUTOR
        public Block(String previousHash)
        {
            this.previousHash = previousHash;
            this.timeStamp = Convert.ToInt64(GetTimeStamp(DateTime.Now)); // Pega o TimeStamp atual

            this.hash = CalculateHash(); // insere o algoritmo SHA-256 no hash
        }

        // Calcula uma nova HASH baseada no conteúdo dos Blocos
        public String CalculateHash() // Calcula uma HASH
        {
            String calculatedHash = StringUtil.EncryptSHA256(
                            previousHash +
                            Convert.ToString(timeStamp) +
                            Convert.ToString(nonce) +
                            merkleRoot
                            );
            return calculatedHash;
        }

        // Minera um bloco
        public void mineBlock(int difficulty)
        {
            merkleRoot = StringUtil.GetMerkleRoot(transactions);

            // CONSTRUIR CÓDIGO DE DIFICULDADE ------------


            /*char[] test = new char[difficulty];
            String target;
            
            while (!hash.Substring(0, difficulty).Equals(test[difficulty])) // Enquanto os caracteres da posição 0 até a posição x  não for igual ao target...
            {
                nonce++; // Incrementa o nonce
                hash = CalculateHash(); // Calcula uma nova HASH
            }*/
            Debug.WriteLine("Bloco Minerado!!! " + hash);
        }

        // Adiciona transações ao Bloco
        public bool AddTransaction(Transaction transaction)
        {
            // Processa a transação e checa se é valida, caso o bloco seja o genesisBlock, o ignora.
            if (transaction == null) return false;
            if(previousHash != "0")
            {
                if(transaction.ProcessTransaction() != true)
                {
                    Debug.WriteLine("#A transação falhou ao processar. Descartada.");
                    return false;
                }
            }
            transactions.Add(transaction);
            Debug.WriteLine("#Transação adicionada ao bloco com sucesso.");
            return true;
        }

        // Cria um TimeStamp (Carimbo do Tempo) no formato abaixo...
        public static String GetTimeStamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }

    }
}
