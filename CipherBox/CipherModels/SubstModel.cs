using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherBox.CipherModels
{
    internal class AlphabeticSubstitutionModel
    {
        int m;

        private List<Dictionary<char, char>> encryptionKeys;
        private List<Dictionary<char, char>> decryptionKeys;
        public string plainText { get; set; }
        public string encryptedText { get; set; }
        public string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string formatted_alphabbet;

        public AlphabeticSubstitutionModel(int m)
        {
            this.m = m;
            encryptionKeys = new List<Dictionary<char, char>>();
            decryptionKeys = new List<Dictionary<char, char>>();

            Generate_Encription_Key();
            Generate_Decription_Key();

            formatted_alphabbet = this.build_formated_string(this.alphabet);
        }

        public void Set_Encryption_Key(int index, Dictionary<char, char> key)
        {
            encryptionKeys[index] = key;
        }

        public Dictionary<char, char> Get_Encryption_Key(int index)
        {
            return encryptionKeys[index];
        }

        public void Encrypt()
        {
            if (string.IsNullOrEmpty(plainText))
                return;

            StringBuilder result = new StringBuilder();

            int keyIndex = 0; 

            foreach (char c in plainText.ToUpper())
            {
                if (c < 'A' || c > 'Z')
                {
                    result.Append(c);
                }
                else
                {
                    Dictionary<char, char> currentKey = encryptionKeys[keyIndex];

                    result.Append(currentKey[c]);

                    keyIndex++;

                    if (keyIndex == m)
                        keyIndex = 0;
                }
            }

            encryptedText = result.ToString();
        }

        public void Decrypt()
        {
            if (string.IsNullOrEmpty(encryptedText))
                return;

            StringBuilder result = new StringBuilder();

            int keyIndex = 0;

            foreach (char c in encryptedText.ToUpper())
            {
                if (c < 'A' || c > 'Z')
                {
                    result.Append(c);
                }
                else
                {
                    Dictionary<char, char> currentKey = decryptionKeys[keyIndex];

                    result.Append(currentKey[c]);

                    keyIndex++;

                    if (keyIndex == m)
                        keyIndex = 0;
                }
            }

            plainText = result.ToString();
        }

        public void Generate_Encription_Key()
        {
            encryptionKeys.Clear();

            Random rnd = new Random();

            for (int i = 0; i < m; i++)
            {
                List<char> alphabet = Enumerable.Range('A', 26)
                                                 .Select(x => (char)x)
                                                 .ToList();
                List<char> shuffled = alphabet.OrderBy(x => rnd.Next()).ToList();

                Dictionary<char, char> key = new Dictionary<char, char>();

                for (int j = 0; j < 26; j++)
                {
                    key.Add(alphabet[j], shuffled[j]);
                }

                encryptionKeys.Add(key);
            }
        }

        public void Generate_Decription_Key()
        {
            decryptionKeys.Clear();

            for (int i = 0; i < m; i++)
            {
                Dictionary<char, char> encKey = encryptionKeys[i];
                Dictionary<char, char> decKey = new Dictionary<char, char>();

                foreach (var pair in encKey)
                {
                    decKey.Add(pair.Value, pair.Key);
                }

                decryptionKeys.Add(decKey);
            }
        }

        public string get_encryption_key(int i)
        {
            Dictionary<char, char> key = encryptionKeys[i];

            StringBuilder sb = new StringBuilder();

            for (char c = 'A'; c <= 'Z'; c++)
            {
                sb.Append(key[c]);
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            string val = formatted_alphabbet;
            for (int i = 0; i< m; i++)
            {
                val += "\r\n" + build_formated_string(get_encryption_key(i));
            }
            return val;
        }

        private string build_formated_string(string key)
        {
            StringBuilder spacedKey = new StringBuilder();

            foreach (char c in key)
            {
                spacedKey.Append(c);
                spacedKey.Append("    ");
            }
            return spacedKey.ToString();
        }

    }
}
