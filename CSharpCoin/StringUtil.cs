﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Security.Cryptography;
using System.Diagnostics;

namespace CSharpCoin
{
    class StringUtil
    {
        public static String ApplySHA256(String input)
        {
            try
            {
                byte[] hash = SHA256CryptoServiceProvider.Create().ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                        sBuilder.Append(hash[i].ToString("x2"));
                }
                return sBuilder.ToString();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);

                return null;
            }
        }

        // Utilizado para ENCRIPTAR os dados que vão até um banco de dados
        public static String EncryptRSA(String input, RSAParameters keyParameters)
        {
            try
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.ImportParameters(keyParameters); // Importa as chaves (Keys) na nova instância do RSACryptoServiceProvider

                byte[] encryptedData = rsa.Encrypt(Encoding.UTF8.GetBytes(input), true); // Encripta os dados, transformando-os em um Array de bytes
                String base64Encrypted = Convert.ToBase64String(encryptedData); // Converte os dados encriptados em String

                return base64Encrypted;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        // Utilizado para DECRIPTAR os dados que vem de um banco de dados
        public static String DecryptRSA(String input, RSAParameters keyParameters)
        {
            try
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.ImportParameters(keyParameters); // Importa as chaves (Keys) na nova instância do RSACryptoServiceProvider

                byte[] encryptedData = Convert.FromBase64String(input); // Converte os dados encriptados de String para Bytes
                byte[] decryptedBytes = rsa.Decrypt(encryptedData, true); // Decripta os dados
                String decryptedData = Encoding.UTF8.GetString(decryptedBytes); // Converte os dados decriptados em String

                return decryptedData;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        

        // Aplica uma Assinatura Digital através do algoritmo RSA
        public static byte[] ApplyRSASig(RSAParameters keyParameters, String input)
        {
            try
            {
                // Cria uma nova instância do RSACryptoServiceProvider usando a 
                // chave de RSAParameters.  
                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

                RSA.ImportParameters(keyParameters);

                byte[] data = Encoding.UTF8.GetBytes(input);

                // Faz um Hash e Assina os dados. Passa uma nova instancia do SHA256CryptoServiceProvider
                // para especificar o uso do SHA256 para criar o HASH.
                return RSA.SignData(data, new SHA256CryptoServiceProvider());
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);

                return null;
            }
        }

        // Verifica a Assinatura Digital através do algoritmo RSA
        public static bool VerifyRSASig(RSAParameters keyParameters, String input, byte[] signature)
        {
            try
            {
                // Pega a Chave e transforma a String em bytes
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.ImportParameters(keyParameters);
                byte[] data = Encoding.UTF8.GetBytes(input);

                // Verifica se está OK (retorna TRUE ou FALSE)
                bool dataOK = rsa.VerifyData(data, new SHA256CryptoServiceProvider(), signature);

                if (dataOK == true)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);

                return false;
            }
        }

        public static String GetStringFromPublicKey(RSAParameters keyParameters)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(keyParameters);
            String publicKey = rsa.ToXmlString(false);
            return publicKey;
        }

        public static String GetStringFromPrivateKey(RSAParameters keyParameters)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(keyParameters);
            String privateKey = rsa.ToXmlString(true);
            return privateKey;
        }

        // Tacha em uma LISTA de transações e retorna um merkle root. (Árvores Merkle)
        public static String GetMerkleRoot(List<Transaction> transactions)
        {
            int count = transactions.Count();
            List<String> previousTreeLayer = new List<String>();
            foreach(Transaction transaction in transactions)
            {
                previousTreeLayer.Add(transaction.transactionId);
            }
            List<String> treeLayer = new List<String>();
            while(count > 1)
            {
                treeLayer = new List<String>();
                for(int i=1; i<previousTreeLayer.Count; i++)
                {
                    treeLayer.Add(ApplySHA256(previousTreeLayer[i - 1] + previousTreeLayer[i]));
                }
                count = treeLayer.Count();
                previousTreeLayer = treeLayer;
            }
            String merkleRoot = (treeLayer.Count() == 1) ? treeLayer[0] : "";
            return merkleRoot;
        }
    }
}
