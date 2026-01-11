using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherBox.UI
{
    public partial class Cezar : Form
    {
        private CezarCipher cipher = new CezarCipher();
        private CriptAnalysis analysisForm;

        public Cezar()
        {
            InitializeComponent();
            to_be_decrypted_text_box.ReadOnly = true;
            to_be_decrypted_test_box.ReadOnly = true;
            this.FormClosing += ChildFormClosing;
        }

        #region VALIDATORS
        private bool validate_plain_text()
        {
            if (string.IsNullOrWhiteSpace(plain_text_box.Text))
            {
                MessageBox.Show("plain text este gol", "eroare text");
                return false;
            }
            return true;
        }

        private bool validate_encrypted_text()
        {
            if (string.IsNullOrWhiteSpace(encrypted_text_box.Text))
            {
                MessageBox.Show("encrypted text este gol", "eroare text");
                return false;
            }
            return true;
        }
        #endregion

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            if (!validate_plain_text()) return;
            string plainText = plain_text_box.Text;
            to_be_decrypted_text_box.Text = cipher.Encrypt_Cezar(plainText);
        }

        private void decrypt_button_Click(object sender, EventArgs e)
        {
            if (!validate_encrypted_text()) return;
            string encryptedText = encrypted_text_box.Text;
            to_be_decrypted_test_box.Text = cipher.Decrypt_Cezar(encryptedText);
        }

        private void analysis_buutton_Click(object sender, EventArgs e)
        {
            if (analysisForm == null || analysisForm.IsDisposed)
            {
                analysisForm = new CriptAnalysis();
                analysisForm.SetCipher(CipherType.Caesar);
                analysisForm.Show();
            }
            else
            {
                analysisForm.Focus();
            }
        }
        private void Cezar_Load(object sender, EventArgs e) { }

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            if (analysisForm != null && !analysisForm.IsDisposed)
                analysisForm.Close();
        }
    }
}
