using CipherBox.CipherService;
using System;
using System.Windows.Forms;

namespace CipherBox.UI
{
    public partial class SubstPoli : Form
    {
        PoliAlphaCipher cipher;
        private CriptAnalysis analysisForm;

        public SubstPoli()
        {
            InitializeComponent();
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

        private void create_cipher()
        {
            if (!validate_value_of_n(out int n)) return;

            // daca nu e creat
            if (cipher == null)
            {
                cipher = new PoliAlphaCipher();
                cipher.N = n;
            }
            else
            {
                // daca N diferit, refacem
                if (cipher.N != n)
                    cipher.N = n;
            }
        }

        private void change_apfa_button_Click(object sender, EventArgs e)
        {
            if (!validate_value_of_n(out int n)) return;

            create_cipher();
            generated_alfa_text_box.Text = cipher.get_display_text();
        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            if (!validate_value_of_n(out int n)) return;
            if (!validate_plain_text()) return;

            create_cipher();

            to_be_encrypted_text_box.Text = cipher.Encrypt_Poli_Alpha(plain_text_box.Text);
        }

        private void decrypt_button_Click(object sender, EventArgs e)
        {
            if (!validate_value_of_n(out int n)) return;
            if (!validate_encrypted_text()) return;

            create_cipher();

            to_be_decrypted_text_box.Text = cipher.Decrypt_Poli_Alphabetic(encrypted_text_box.Text);
        }

        private void generated_alfa_text_box_TextChanged(object sender, EventArgs e)
        {
        }

        private void n_value_text_box_TextChanged(object sender, EventArgs e)
        {
        }

        private void SubstPoli_Load(object sender, EventArgs e)
        {

        }

        private void analysis_buutton_Click(object sender, EventArgs e)
        {
            if (analysisForm == null || analysisForm.IsDisposed)
            {
                analysisForm = new CriptAnalysis();
                analysisForm.SetCipher(CipherType.PoliAlpha);
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
    }
}
