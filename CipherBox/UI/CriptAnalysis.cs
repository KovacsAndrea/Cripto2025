using CipherBox.Analysis;
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
    public partial class CriptAnalysis : Form
    {
        private CipherType currentCipher;
        public CriptAnalysis()
        {
            InitializeComponent();
        }

        private bool validate_encryptedText()
        {
            if (string.IsNullOrWhiteSpace(analysis_encrypted_text_box.Text))
            {
                MessageBox.Show("encripted text este gol", "eroare text");
                return false;
            }

            return true;
        }

        private void CriptAnalysis_Load(object sender, EventArgs e)
        {

        }

        public void SetCipher(CipherType cipher)
        {
            currentCipher = cipher;
            
        }

        private void RunAnalisys()
        {
            if(!validate_encryptedText()) return;
            switch (currentCipher)
            {
                case CipherType.Caesar:
                    PlusNAnalysis Canalysis = new PlusNAnalysis();
                    analysis_results_texxt_box.Text = Canalysis.GetAnalysisResults(analysis_encrypted_text_box.Text);
                    break;
                case CipherType.PlusN:
                    PlusNAnalysis PNanalysis = new PlusNAnalysis();
                    analysis_results_texxt_box.Text = PNanalysis.GetAnalysisResults(analysis_encrypted_text_box.Text);
                    break;
                case CipherType.MonoAlpha:
                    MonoAlphaAnalysis MAanalysis = new MonoAlphaAnalysis();
                    analysis_results_texxt_box.Text = MAanalysis.GetAnalysisResults(analysis_encrypted_text_box.Text);
                    break;
                case CipherType.PoliAlpha:
                    PoliAlphaAnalysis PAanalysis = new PoliAlphaAnalysis();
                    analysis_results_texxt_box.Text = PAanalysis.GetAnalysisResults(analysis_encrypted_text_box.Text);
                    break;
                case CipherType.Playfair:
                    PlayfairAnalysis PFanalysis = new PlayfairAnalysis();
                    analysis_results_texxt_box.Text = PFanalysis.GetAnalysisResults(analysis_encrypted_text_box.Text);
                    break;
            }
        }

        private void analyze_button_Click(object sender, EventArgs e)
        {
            RunAnalisys();
        }
    }
}
