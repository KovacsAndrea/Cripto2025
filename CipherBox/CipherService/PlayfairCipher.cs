using CipherBox.CipherModels;
using System;

namespace CipherBox.CipherService
{
    internal class PlayfairCipher
    {
        private PlayfairModel model;

        public PlayfairCipher()
        {
            model = new PlayfairModel();
        }

        public void SetKey(string key)
        {
            model.SetKey(key);
        }

        public string GetFormattedKey()
        {
            return model.GetFormattedGey();
        }

        public string GetMatrix()
        {
            return model.GetFormattedMatrix();
        }

        public string FormatPlainText(string plainText)
        {
            return model.FormatText(plainText);
        }

        public string Encrypt_Playfair(string plainText)
        {
            model.PlainText = FormatPlainText(plainText);
            model.Encrypt(); 
            return model.EncryptedText; 
        }

        public string Decrypt_Playfair(string encryptedText)
        {
            model.EncryptedText = encryptedText;
            model.Decrypt(); 
            return model.PlainText; 
        }
    }
}
