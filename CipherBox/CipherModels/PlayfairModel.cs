using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherBox.CipherModels
{
    internal class PlayfairModel
    {
        public string PlainText { get; set; }
        public string EncryptedText { get; set; }
        private string key;
        private string formattedKey;
        private char[,] matrix = new char[5, 5];
        private string formattedMatrix;

        public void SetKey(string key)
        {
            this.key = key.ToUpper().Replace("J", "I");
            this.FormatKey();
            BuildMatrix();
        }

        private void FormatKey()
        {
            StringBuilder result = new StringBuilder();
            bool[] used = new bool[26];

            foreach (char c in key)
            {
                if (c < 'A' || c > 'Z')
                    continue;

                char letter = c;

                int index = letter - 'A';

                if (!used[index])
                {
                    used[index] = true;
                    result.Append(letter);
                    result.Append(" ");
                }
            }
            this.formattedKey = result.ToString().Trim();
        }

        public string GetFormattedGey()
        {
            return this.formattedKey;
        }

        private void BuildMatrix()
        {
            HashSet<char> used = new HashSet<char>();
            string fullKey = "";

            foreach (char c in key)
            {
                if (c < 'A' || c > 'Z') continue;
                if (!used.Contains(c))
                {
                    fullKey += c;
                    used.Add(c);
                }
            }

            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (c == 'J') continue;
                if (!used.Contains(c))
                {
                    fullKey += c;
                    used.Add(c);
                }
            }

            for (int i = 0; i < 25; i++)
            {
                matrix[i / 5, i % 5] = fullKey[i];
            }
            FormatMatrix();
        }

        private void FormatMatrix()
        {
            StringBuilder matrixDisplay = new StringBuilder();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrixDisplay.Append(matrix[i, j]);
                    matrixDisplay.Append("             "); 
                }
                matrixDisplay.Append("\r\n"); 
            }
            this.formattedMatrix = matrixDisplay.ToString();
        }

        public string GetFormattedMatrix()
        {
            return this.formattedMatrix;
        }

        public string FormatText(string text)
        {
            text = text.ToUpper().Replace("J", "I").Replace(" ", "");
            StringBuilder sb = new StringBuilder();
            int i = 0;
            while (i < text.Length)
            {
                char a = text[i];
                char b = (i + 1 < text.Length) ? text[i + 1] : 'X';
                if (a == b)
                {
                    sb.Append(a);
                    sb.Append('X');
                    i++;
                }
                else
                {
                    sb.Append(a);
                    sb.Append(b);
                    i += 2;
                }
            }
            if (sb.Length % 2 != 0) sb.Append('X');
            return sb.ToString();
        }

        private (int, int) FindPosition(char c)
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    if (matrix[i, j] == c) return (i, j);
            return (-1, -1);
        }

        public void Encrypt()
        {
            string text = FormatText(PlainText);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i += 2)
            {
                char a = text[i];
                char b = text[i + 1];
                (int r1, int c1) = FindPosition(a);
                (int r2, int c2) = FindPosition(b);

                if (r1 == r2)
                {
                    sb.Append(matrix[r1, (c1 + 1) % 5]);
                    sb.Append(matrix[r2, (c2 + 1) % 5]);
                }
                else if (c1 == c2)
                {
                    sb.Append(matrix[(r1 + 1) % 5, c1]);
                    sb.Append(matrix[(r2 + 1) % 5, c2]);
                }
                else
                {
                    sb.Append(matrix[r1, c2]);
                    sb.Append(matrix[r2, c1]);
                }
            }
            EncryptedText = sb.ToString();
        }

        public void Decrypt()
        {
            string text = EncryptedText.ToUpper().Replace(" ", "");
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i += 2)
            {
                char a = text[i];
                char b = text[i + 1];
                (int r1, int c1) = FindPosition(a);
                (int r2, int c2) = FindPosition(b);

                if (r1 == r2)
                {
                    sb.Append(matrix[r1, (c1 + 4) % 5]);
                    sb.Append(matrix[r2, (c2 + 4) % 5]);
                }
                else if (c1 == c2)
                {
                    sb.Append(matrix[(r1 + 4) % 5, c1]);
                    sb.Append(matrix[(r2 + 4) % 5, c2]);
                }
                else
                {
                    sb.Append(matrix[r1, c2]);
                    sb.Append(matrix[r2, c1]);
                }
            }
            PlainText = sb.ToString();
        }
    }
}
