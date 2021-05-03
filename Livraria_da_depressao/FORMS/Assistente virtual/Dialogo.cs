using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Microsoft.Speech.Recognition;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria_da_depressao.FORMS.Assistente_virtual
{
    public partial class frmDialogo : Form
    {
        static CultureInfo ci = new CultureInfo("pt-BR");
        static Microsoft.Speech.Recognition.SpeechRecognitionEngine sr;
        SpeechSynthesizer ss = new SpeechSynthesizer();
        public string[] words = { "Oi", "Olá", "Teste", "Emprestimo" };

        public frmDialogo()
        {
            InitializeComponent();
            Init();
        }

        private void Gramatica()
        {
            try
            {
                sr = new Microsoft.Speech.Recognition.SpeechRecognitionEngine(ci);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: "+ex.Message);
            }

            var gramatica = new Microsoft.Speech.Recognition.Choices();
            gramatica.Add(words);

            var gb = new Microsoft.Speech.Recognition.GrammarBuilder();
            gb.Append(gramatica);

            try
            {
                var g = new Microsoft.Speech.Recognition.Grammar(gb);

                try
                {
                    sr.RequestRecognizerUpdate();
                    sr.LoadGrammarAsync(g);
                    sr.SpeechRecognized += Sr_SpeechRecognized;
                    sr.SetInputToDefaultAudioDevice();
                    ss.SetOutputToDefaultAudioDevice();
                    sr.RecognizeAsync(Microsoft.Speech.Recognition.RecognizeMode.Multiple);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void Sr_SpeechRecognized(object sender, Microsoft.Speech.Recognition.SpeechRecognizedEventArgs e)
        {
            string frase = e.Result.Text;
            switch (frase)
            {
                case "Oi": rtbDialogo.Text = frase; ss.SpeakAsync("Oi, meu chapa"); break;
                case "Olá": rtbDialogo.Text = frase; ss.SpeakAsync("Olá meu bom"); break;
                case "Teste": rtbDialogo.Text = frase; ss.SpeakAsync("Deu certo"); break;
                case "Emprestimo": rtbDialogo.Text = frase; ss.SpeakAsync("Iniciando novo empréstimo"); break;
            }
        }

        private void Init()
        {
            ss.Volume = 100;
            ss.Rate = 3;
            Gramatica();
        }

        private void btFalar_Click(object sender, EventArgs e)
        {
            
        }

        private void frmDialogo_Load(object sender, EventArgs e)
        {

        }
    }
}
