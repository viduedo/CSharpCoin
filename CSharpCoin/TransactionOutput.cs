using System;
using System.Security.Cryptography;

namespace CSharpCoin
{
    public class TransactionOutput
    {
        public String id;
        public String reciepient; // também conhecido como o novo proprietário dessas moedas. (contém as chaves dele)
        public double value; // a quantidade de moedas que possuem
        public String parentTransactionId; // o id da transação que esta saída foi criada

        // CONSTRUTOR
        public TransactionOutput(String reciepient, double value, String parentTransactionId)
        {
            this.reciepient = reciepient;
            this.value = value;
            this.parentTransactionId = parentTransactionId;
            this.id = StringUtil.ApplySHA256(reciepient + Convert.ToString(value) + parentTransactionId);
        }


        // Verifica se a moeda pertence a você
        public bool isMine(RSAParameters keyParameters)
        {
            String publicKey = StringUtil.GetStringFromPublicKey(keyParameters);
            return (publicKey == reciepient);
        }
    }
}