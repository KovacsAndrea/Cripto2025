using CipherBox.CipherModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherBox
{
    internal class CezarCipher
    {
        private PlusNModel cezarCipher = new PlusNModel(3);
        public string Encrypt_Cezar(string plainText)
        {
            cezarCipher.plainText = plainText;
            cezarCipher.Encrypt();
            return cezarCipher.encryptedText;
        }

        public string Decrypt_Cezar(string encryptedText)
        {
            cezarCipher.encryptedText = encryptedText;
            cezarCipher.Decrypt();
            return cezarCipher.plainText;
        }
    }
}
