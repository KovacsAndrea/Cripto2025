using CipherBox.CipherModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherBox.CipherService
{
    internal class PlusNCipher
    {
        private int n = 0;
        private PlusNModel cipher;

        public int N
        {
            get { return n; }
            set
            {
                n = value;
                cipher = new PlusNModel(n);
            }
        }

        public PlusNCipher(int n)
        {
            this.n = n;
            this.cipher = new PlusNModel(n);
        }

        public string Encrypt_Cezar(string plainText)
        {
            cipher.plainText = plainText;
            cipher.Encrypt();
            return cipher.encryptedText;
        }

        public string Decrypt_Cezar(string encryptedText)
        {
            cipher.encryptedText = encryptedText;
            cipher.Decrypt();
            return cipher.plainText;
        }
    }
}
