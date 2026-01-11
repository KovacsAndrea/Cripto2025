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
    public partial class Playfair : Form
    {
        private PlayfairCipher cipher = new PlayfairCipher();
        private CriptAnalysis analysisForm;

        public Playfair()
        {
            InitializeComponent();
            this.FormClosing += ChildFormClosing;
        }

        #region VALIDAOTRS
        //validate plain text
        //validate key (sa nu fie goala)
        //validate encrypted text 
        private bool validate_key()
        {
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


        private void PopulateSetup()
        {
            if (!validate_key()) return;
            cipher.SetKey(key_text_box.Text);
            //if key valid
            formated_key_text_box.Text = cipher.GetFormattedKey();
            matrix_text_box.Text = cipher.GetMatrix();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void n_value_text_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Playfair_Load(object sender, EventArgs e)
        {

        }

        private void setup_button_Click(object sender, EventArgs e)
        {
            PopulateSetup();
        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            //validate plain text
            //if plain text valid
            //populate the setup si setupul include oricum vallidate key
            if (!validate_plain_text()) return;
            PopulateSetup();
            formatted_plain_text.Text = cipher.FormatPlainText(plain_text_box.Text);
            to_be_encrypted_text_box.Text = cipher.Encrypt_Playfair(plain_text_box.Text);

            
            
        }

        private void decrypt_button_Click(object sender, EventArgs e)
        {
            if(!validate_encrypted_text()) return;
            PopulateSetup();
            to_be_decrypted_text_box.Text = cipher.Decrypt_Playfair(encrypted_text_box.Text);

        }

        private void analysis_buutton_Click(object sender, EventArgs e)
        {
            if (analysisForm == null || analysisForm.IsDisposed)
            {
                analysisForm = new CriptAnalysis();
                analysisForm.SetCipher(CipherType.Playfair);
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
