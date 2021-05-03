using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria_da_depressao.FORMS.Assistente_virtual
{
    public partial class NewDialog : Form
    {
        public static CultureInfo ci = new CultureInfo("pt-BR");
        public static SpeechRecognitionEngine recognizer; 
        public NewDialog()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            try {
                try
                {
                    // Create an in-process speech recognizer for the en-US locale.  
                    recognizer = new SpeechRecognitionEngine(ci);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                recognizer.LoadGrammar(new DictationGrammar());
                recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);
                recognizer.SetInputToDefaultAudioDevice();
                recognizer.RecognizeAsync(RecognizeMode.Multiple);

                while (true)
                {
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
