using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CipherBox.Analysis
{
    internal class PlayfairAnalysis
    {
        private Random _random = new Random();

        public string GetAnalysisResults(string encryptedText)
        {
            if (string.IsNullOrEmpty(encryptedText)) return "Text invalid.";

            string ciphertext = new string(encryptedText.ToUpper().Where(c => char.IsLetter(c)).ToArray()).Replace("J", "I");

            if (ciphertext.Length % 2 != 0) ciphertext += "X";

            string currentKey = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
            string bestKey = currentKey;
            double bestScore = double.MinValue;

            for (int i = 0; i < 5000; i++)
            {
                string modifiedKey = ShuffleKey(currentKey);
                string decrypted = DecryptWithKey(ciphertext, modifiedKey);
                double currentScore = CalculateFitness(decrypted);

                if (currentScore > bestScore)
                {
                    bestScore = currentScore;
                    bestKey = modifiedKey;
                    currentKey = modifiedKey;
                }
            }

            return FormatResults(bestKey, DecryptWithKey(ciphertext, bestKey));
        }

        private string DecryptWithKey(string text, string key)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i += 2)
            {
                char a = text[i];
                char b = text[i + 1];

                int posA = key.IndexOf(a);
                int posB = key.IndexOf(b);

                int rowA = posA / 5;
                int colA = posA % 5;
                int rowB = posB / 5;
                int colB = posB % 5;

                if (rowA == rowB)
                {
                    sb.Append(key[rowA * 5 + (colA + 4) % 5]);
                    sb.Append(key[rowB * 5 + (colB + 4) % 5]);
                }
                else if (colA == colB) 
                {
                    sb.Append(key[((rowA + 4) % 5) * 5 + colA]);
                    sb.Append(key[((rowB + 4) % 5) * 5 + colB]);
                }
                else 
                {
                    sb.Append(key[rowA * 5 + colB]);
                    sb.Append(key[rowB * 5 + colA]);
                }
            }
            return sb.ToString();
        }

        private string ShuffleKey(string key)
        {
            char[] k = key.ToCharArray();
            int i = _random.Next(25);
            int j = _random.Next(25);
            char temp = k[i];
            k[i] = k[j];
            k[j] = temp;
            return new string(k);
        }

        private double CalculateFitness(string text)
        {
            string[] commonBigrams = { "EN", "ER", "RE", "NT", "TH", "ON", "IN", "DE", "AN", "OR" };
            double score = 0;

            for (int i = 0; i < text.Length - 1; i++)
            {
                string bigram = text.Substring(i, 2);
                if (commonBigrams.Contains(bigram)) score += 10;

                if ("QZJX".Contains(text[i])) score -= 5;
            }
            return score;
        }

        private string FormatResults(string key, string text)
        {
            StringBuilder res = new StringBuilder();
            res.AppendLine("--- Rezultate Criptanaliza Playfair ---");
            res.AppendLine($"Matricea identificata (cheie): {key}");
            res.AppendLine();
            res.AppendLine("Matrice vizuala:");
            for (int i = 0; i < 25; i++)
            {
                res.Append(key[i] + " ");
                if ((i + 1) % 5 == 0) res.AppendLine();
            }
            res.AppendLine();
            res.AppendLine("Text decriptat (probabil):");
            res.AppendLine(text.Length > 200 ? text.Substring(0, 200) + "..." : text);
            return res.ToString();
        }
    }
}