using CipherBox.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
public enum CipherType
{
    Caesar,
    PlusN,
    MonoAlpha,
    PoliAlpha,
    Playfair,
}

namespace CipherBox
{
    public partial class Home : Form
    {
        public static CriptAnalysis analysisForm = new CriptAnalysis();
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cezar cezarForm = new Cezar();
            cezarForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlusN plusNForm = new PlusN();
            plusNForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SubsMono subsMonoForm = new SubsMono();
            subsMonoForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SubstPoli subsPoliForm = new SubstPoli();
            subsPoliForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Playfair playfairForm = new Playfair();
            playfairForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
