using CipherBox.CipherModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherBox.CipherService
{
    internal class PoliAlphaCipher
    {
        private int n = 0;
        private AlphabeticSubstitutionModel cipher;

        public int N
        {
            get { return n; }
            set { n = value;
                cipher = new AlphabeticSubstitutionModel(n);
            }
        }

        public string get_display_text()
        {
            return cipher.ToString();
        }

        public string Encrypt_Poli_Alpha(string plainText)
        {
            cipher.plainText = plainText;
            cipher.Encrypt();
            return cipher.encryptedText;
        }

        public string Decrypt_Poli_Alphabetic(string encryptedText)
        {
            cipher.encryptedText = encryptedText;
            cipher.Decrypt();
            return cipher.plainText;
        }
    }
}
