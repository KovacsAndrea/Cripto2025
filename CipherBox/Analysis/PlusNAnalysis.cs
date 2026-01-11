using System;
using System.Text;

namespace CipherBox.Analysis
{
    internal class PlusNAnalysis
    {
        private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public string GetAnalysisResults(string encryptedText)
        {
            encryptedText = encryptedText.ToUpper();

            StringBuilder results = new StringBuilder();

            for (int shift = 1; shift <= 26; shift++)
            {
                results.AppendLine($"Shift {shift}:");
                results.AppendLine(DecryptWithShift(encryptedText, shift));
                results.AppendLine();
            }

            return results.ToString();
        }

        private string DecryptWithShift(string text, int shift)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in text)
            {
                if (c < 'A' || c > 'Z')
                {
                    result.Append(c);
                }
                else
                {
                    int index = c - 'A';
                    int newIndex = (index - shift) % 26;

                    if (newIndex < 0)
                        newIndex += 26;

                    result.Append(alphabet[newIndex]);
                }
            }

            return result.ToString();
        }
    }
}
