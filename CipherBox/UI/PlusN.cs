using CipherBox.CipherService;
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
    public partial class PlusN : Form
    {
        PlusNCipher cipher;
        CriptAnalysis analysisForm;

        public PlusN()
        {
            InitializeComponent();
            to_be_encrypted_text_box.ReadOnly = true;
            to_be_decrypted_text_box.ReadOnly = true;
            this.FormClosing += ChildFormClosing;
        }

        #region VALIDATORS
        private bool validate_value_of_n(out int n)
        {
            n = 0;
            if (!int.TryParse(n_value_text_box.Text, out n))
            {
                MessageBox.Show("valoarea lui n nu este un numar", "eroare n");
                return false;
            }

            if (n <= 0)
            {
                MessageBox.Show("valoarea lui n trebuie sa fie > 0", "eroare n");
                return false;
            }
            return true;
        }

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

        private void PlusN_Load(object sender, EventArgs e)
        {

        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            if (!validate_value_of_n(out int n)) return;
            if (!validate_plain_text()) return;
            if (cipher == null)
            {
                cipher = new PlusNCipher(n);
            }
            else
            {
                cipher.N = n;
            }

            string encrypted = cipher.Encrypt_Cezar(plain_text_box.Text);
            to_be_encrypted_text_box.Text = encrypted;
        }

        private void decrypt_button_Click(object sender, EventArgs e)
        {
            if (!validate_value_of_n(out int n)) return;
            if (!validate_encrypted_text()) return;

            if (cipher == null)
            {
                cipher = new PlusNCipher(n);
            }
            else
            {
                cipher.N = n;
            }

            string decrypted = cipher.Decrypt_Cezar(encrypted_text_box.Text);
            to_be_decrypted_text_box.Text = decrypted;
        }

        private void analysis_buutton_Click(object sender, EventArgs e)
        {
            if (analysisForm == null || analysisForm.IsDisposed)
            {
                analysisForm = new CriptAnalysis();
                analysisForm.SetCipher(CipherType.MonoAlpha);
                analysisForm.Show();
            }
            else
            {
                analysisForm.Focus();
            }
        }

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            if (analysisForm != null && !analysisForm.IsDisposed)
                analysisForm.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
