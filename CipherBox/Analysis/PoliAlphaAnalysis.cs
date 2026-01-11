using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CipherBox.Analysis
{
    internal class PoliAlphaAnalysis
    {
        private MonoAlphaAnalysis mono = new MonoAlphaAnalysis();

        // encryptedText = textul criptat
        // maxAlphabets = numarul maxim de alfabete pe care vrem sa le testam (1..5)
        public string GetAnalysisResults(string encryptedText, int maxAlphabets = 5)
        {
            encryptedText = encryptedText.ToUpper();
            encryptedText = new string(encryptedText.Where(c => c >= 'A' && c <= 'Z').ToArray());

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"POLYALPHABETIC ANALYSIS (max {maxAlphabets} alfabete)");
            sb.AppendLine("----------------------------------");

            for (int n = 1; n <= maxAlphabets; n++)
            {
                sb.AppendLine($"--- Presupunem {n} alfabet(e) ---");

                for (int i = 0; i < n; i++)
                {
                    // extragem literele corespunzatoare alfabetului i
                    var subset = new List<char>();
                    for (int j = i; j < encryptedText.Length; j += n)
                    {
                        subset.Add(encryptedText[j]);
                    }

                    string subsetText = new string(subset.ToArray());
                    sb.AppendLine($"ALFABET {i + 1}: {subsetText}");
                    sb.AppendLine(mono.GetAnalysisResults(subsetText));
                }

                sb.AppendLine("----------------------------------");
            }

            return sb.ToString();
        }
    }
}
