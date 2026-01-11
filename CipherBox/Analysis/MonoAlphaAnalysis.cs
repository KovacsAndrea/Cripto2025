using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CipherBox.Analysis
{
    internal class MonoAlphaAnalysis
    {
        private readonly string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private readonly string englishFrequencyOrder = "ETAOINSHRDLCUMWFGYPBVKJXQZ";

        public string GetAnalysisResults(string encryptedText)
        {
            encryptedText = encryptedText.ToUpper();

            int[] freq = new int[26];
            int totalLetters = 0;

            foreach (char c in encryptedText)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    freq[c - 'A']++;
                    totalLetters++;
                }
            }

            var lettersWithFreq = new List<(char letter, int count)>();

            for (int i = 0; i < 26; i++)
            {
                lettersWithFreq.Add(((char)('A' + i), freq[i]));
            }

            lettersWithFreq = lettersWithFreq
                                .OrderByDescending(x => x.count)
                                .ToList();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("FRECVENTA LITERELOR:");
            sb.AppendLine("-------------------");

            foreach (var item in lettersWithFreq)
            {
                double percent = totalLetters == 0 ? 0 : (item.count * 100.0 / totalLetters);
                sb.AppendLine($"{item.letter} : {item.count} ({percent:F2}%)");
            }

            sb.AppendLine();
            sb.AppendLine("ORDINE FRECVENȚE (CIFRU):");
            sb.AppendLine(string.Join("", lettersWithFreq.Select(x => x.letter)));

            sb.AppendLine();
            sb.AppendLine("ORDINE FRECVENȚE (ENG):");
            sb.AppendLine(englishFrequencyOrder);

            sb.AppendLine();
            sb.AppendLine("SUGESTIE SUBSTITUTIE:");
            sb.AppendLine("-------------------");

            for (int i = 0; i < 26; i++)
            {
                sb.AppendLine($"{lettersWithFreq[i].letter} → {englishFrequencyOrder[i]}");
            }

            return sb.ToString();
        }
    }
}
