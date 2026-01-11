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
    public partial class SubsMono : Form
    {
        private MonoAplhaCipher cipher = new MonoAplhaCipher();
        private CriptAnalysis analysisForm;
        public SubsMono()
        {
            InitializeComponent();
            generate_perm_radio.CheckedChanged += radio_buttons_CheckedChanged;
            input_perm_radio.CheckedChanged += radio_buttons_CheckedChanged;
            this.FormClosing += ChildFormClosing;
        }

        private void SubsMono_Load(object sender, EventArgs e)
        {

        }

        #region VALIDATORS

        // verificam daca e ales un radio button
        private bool validate_radio_buttons()
        {
            if (!generate_perm_radio.Checked && !input_perm_radio.Checked)
            {
                MessageBox.Show("selecteaza modul de generare a permutarii", "eroare permutare");
                return false;
            }

            if (input_perm_radio.Checked)
            {
                if (!validate_manual_input())
                    return false;

                cipher.set_manual_permuation(manual_perm_text_box.Text);
            }

            return true;
        }

        private bool validate_manual_input()
        {
            //daca e selectet si text box-ul e gol, eroare
            //daca e selectat, nu e gol, dar nu are lungimea corecta, eroare,
            //daca e selectat, nu e gol, are lungimea corecta, dar se repeta litere, eroare
            string perm = manual_perm_text_box.Text.Trim().ToUpper();
            //gol 
            if (string.IsNullOrWhiteSpace(perm))
            {
                MessageBox.Show("permutarea manuala este goala", "eroare permutare");
                return false;
            }
            //lungime
            if (perm.Length != 26)
            {
                MessageBox.Show("permutarea trebuie sa aiba exact 26 de caractere", "eroare permutare");
                return false;
            }

            int[] freq = new int[26];
            //altceva in afara de litere
            for (int i = 0; i < perm.Length; i++)
            {
                char c = perm[i];
                if (c < 'A' || c > 'Z')
                {
                    MessageBox.Show("permutarea trebuie sa contina doar litere A-Z", "eroare permutare");
                    return false;
                }
                freq[c - 'A']++;
            }

            // litere care se repeta
            for (int i = 0; i < 26; i++)
            {
                if (freq[i] != 1)
                {
                    MessageBox.Show("permutarea nu este valida (litere lipsa sau duplicate)", "eroare permutare");
                    return false;
                }
            }
            return true;
        }

        // verificam plain text pt encrypt
        private bool validate_plain_text()
        {
            if (string.IsNullOrWhiteSpace(plain_text_box.Text))
            {
                MessageBox.Show("plain text este gol", "eroare text");
                return false;
            }

            return true;
        }

        // verificam encrypted text pt decrypt
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

        // radio buttons se exclud intre ele
        private void radio_buttons_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == generate_perm_radio && generate_perm_radio.Checked)
            {
                input_perm_radio.Checked = false;
                cipher.generate_permuation();
                generated_perm_text_box.Text = cipher.get_encryption_key();
            }

            if (sender == input_perm_radio && input_perm_radio.Checked)
            {
                generate_perm_radio.Checked = false;
            }
        }

        private void generate_permutation_button_Click(object sender, EventArgs e)
        {
            generate_perm_radio.Checked = true;
            cipher.generate_permuation();
            generated_perm_text_box.Text = cipher.get_encryption_key();
        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            if (!validate_radio_buttons()) return;
            if (!validate_plain_text()) return;
            to_be_encrypted_text_box.Text = cipher.Encrypt_Mnono_Alpha(plain_text_box.Text);
        }

        private void decrypt_button_Click(object sender, EventArgs e)
        {
            if (!validate_radio_buttons()) return;
            if (!validate_encrypted_text()) return;
            to_be_decrypted_text_box.Text = cipher.Decrypt_Mnono_Alphabetic(encrypted_text_box.Text);
        }

        private void generate_perm_radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void input_perm_radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void show_key_button_Click(object sender, EventArgs e)
        {
            if (!validate_radio_buttons()) return;
            map_text_box.Text = cipher.get_display_text();
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
    }
}
