using CipherBox.CipherModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherBox.CipherService
{
    internal class MonoAplhaCipher
    {
        private AlphabeticSubstitutionModel cipher;
        private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public MonoAplhaCipher()
        {
            cipher = new AlphabeticSubstitutionModel(1);
            
        }

        private void set_encryption_key(string permuation)
        {
            Dictionary<char, char> key = new Dictionary<char, char>();

            permuation = permuation.ToUpper();

            for (int i = 0; i < 26; i++)
            {
                key.Add(alphabet[i], permuation[i]);
            }

            cipher.Set_Encryption_Key(0, key);
        }

        public void set_manual_permuation(string permuation)
        {
            set_encryption_key(permuation);
            cipher.Generate_Decription_Key();
        }

        public void generate_permuation()
        {
            cipher.Generate_Encription_Key();
            cipher.Generate_Decription_Key();
        }

        public string get_encryption_key()
        {
            return cipher.get_encryption_key(0);
        }

        public string get_display_text()
        {
            return cipher.ToString();
        }

        public string Encrypt_Mnono_Alpha(string plainText)
        {
            cipher.plainText = plainText;
            cipher.Encrypt();
            return cipher.encryptedText;
        }

        public string Decrypt_Mnono_Alphabetic(string encryptedText)
        {
            cipher.encryptedText = encryptedText;
            cipher.Decrypt();
            return cipher.plainText;
        }
    }
}
