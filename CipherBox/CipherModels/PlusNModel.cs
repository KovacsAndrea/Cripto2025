using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherBox.CipherModels
{
    internal class PlusNModel
    {
        int n = 0;

        private Dictionary<char, char> encriptionKey = new Dictionary<char, char>();
        private Dictionary<char, char> decriptionKey = new Dictionary<char, char>();
        public string plainText { get; set; }
        public string encryptedText { get; set; }


        public PlusNModel( int n)
        {
            this.n = n;
            this.Generate_Encription_Key();
            this.Generate_Decription_Key();
        }

        public void Encrypt()
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in plainText.ToUpper())
            {
                if (!char.IsLetter(c))
                {
                    result.Append(c);
                }
                else
                {
                    result.Append(encriptionKey[c]);
                }
            }
            encryptedText = result.ToString();
        }
        public void Decrypt(){
            StringBuilder result = new StringBuilder();

            foreach (char c in encryptedText.ToUpper())
            {
                if (!char.IsLetter(c))
                {
                    result.Append(c);
                }
                else
                {
                    result.Append(decriptionKey[c]);
                }
            }

            plainText = result.ToString();
        }

        private void Generate_Encription_Key()
        {
            for (int i = 0; i < 26; i++)
            {
                char original = (char)('A' + i);
                char shifted = (char)('A' + ((i + n) % 26));

                encriptionKey.Add(original, shifted);
            }
        }
        private void Generate_Decription_Key()
        {
            foreach (var pair in encriptionKey)
            {
                decriptionKey.Add(pair.Value, pair.Key);
            }
        }

    }
}
