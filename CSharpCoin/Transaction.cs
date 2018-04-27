using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoin
{
    class Transaction
    {
        public String transactionId; // ID da transação
        public RSAParameters sender; // Chave pública do REMETENTE
        public RSAParameters reciepient; // Chave pública do DESTINATÁRIO
        public double value; // Valor da transação
        public byte[] signature; // Assinatura Digital

        public List<TransactionInput> inputs = new List<TransactionInput>();
        public List<TransactionOutput> outputs = new List<TransactionOutput>();

        private static int sequence = 0; // Contagem de quantas transações foram realizadas

        // CONSTRUTOR
        public Transaction(RSAParameters from, RSAParameters to, double value, List<TransactionInput> inputs)
        {
            this.sender = from;
            this.reciepient = to;
            this.value = value;
            this.inputs = inputs;
        }

        // Este calculará a HASH de transação
        private String CalculateHash()
        {
            sequence++; // Aumenta a sequência para evitar 2 transações idênticas utilizando o mesmo HASH
            return StringUtil.EncryptSHA256(
                            StringUtil.GetStringFromPublicKey(sender) +
                            StringUtil.GetStringFromPublicKey(reciepient) +
                            Convert.ToString(value) + sequence
                            );
        }

        // Assina todos os dados que não queremos que estejam adulterados
        public void GenerateSignature(RSAParameters keyParameters)
        {
            String data = StringUtil.GetStringFromPublicKey(sender) + StringUtil.GetStringFromPublicKey(reciepient) + Convert.ToString(value);
            signature = StringUtil.ApplyRSASig(keyParameters, data);
        }

        // Verifica se os dados que assinamos não foram adulterados
        public bool VerifySignature()
        {
            String data = StringUtil.GetStringFromPublicKey(sender) + StringUtil.GetStringFromPublicKey(reciepient) + Convert.ToString(value);
            return StringUtil.VerifyRSASig(sender, data, signature);
        }

        // Retorna TRUE se a nova transação puder ser criada
        public bool ProcessTransaction()
        {

            if(VerifySignature() == false)
            {
                Debug.WriteLine("#A assinatura da transação falhou na verificação.");
                return false;
            }

            // Coleta entradas de transação (certifica de que não foram gastas)
            foreach(TransactionInput i in inputs)
            {
                i.UTXO = Program.UTXOs[i.transactionOutputId];
            }


            // Verifica se a transação está válida
            if(GetInputsValue() < Program.minimumTransaction)
            {
                Debug.WriteLine("#Entradas de Transação muito baixas: " + GetInputsValue());
                Debug.WriteLine("#Porfavor, entre com uma quantia maior que " + Program.minimumTransaction);
                return false;
            }

            // Gera saídas de transação
            double leftOver = GetInputsValue() - value; // Pega o valor da entrada e faz a diferença do saldo
            transactionId = CalculateHash();
            outputs.Add(new TransactionOutput(StringUtil.GetStringFromPublicKey(this.reciepient), value, transactionId));
            outputs.Add(new TransactionOutput(StringUtil.GetStringFromPublicKey(this.sender), leftOver, transactionId));

            // Adiciona saídas à lista não gasta
            foreach(TransactionOutput o in outputs)
            {
                Program.UTXOs.Add(o.id, o);
            }

            // Remove as entradas de transação das listas UTXO conforme os gastos
            foreach(TransactionInput i in inputs)
            {
                if (i.UTXO == null) continue; // Se a transação não puder ser encontrada, pule-a
                Program.UTXOs.Remove(i.UTXO.id);
            }

            return true;

        }


        // Retorna a soma das entradas (UTXOs)
        public double GetInputsValue()
        {
            double total = 0;
            foreach(TransactionInput i in inputs)
            {
                if (i.UTXO == null) continue; // Se a transação não puder ser encontrada, pule-a
                total += i.UTXO.value;
            }
            return total;
        }

        // Retorna a soma das saídas
        public double GetOutputsValue()
        {
            double total = 0;
            foreach(TransactionOutput o in outputs)
            {
                total += o.value;
            }
            return total;
        }
    }
}
