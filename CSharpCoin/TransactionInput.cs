using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoin
{
    class TransactionInput
    {
        public String transactionOutputId; // Referencia a TransactionOutputs -> transactionId
        public TransactionOutput UTXO; // Contém a saída da transação não gasta

        public TransactionInput(String transactionOutputId)
        {
            this.transactionOutputId = transactionOutputId;
        }
    }
}
