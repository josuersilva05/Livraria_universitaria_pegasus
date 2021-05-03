using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;

namespace Livraria_da_depressao.FORMS.Chatbot
{
    public partial class ChatBot : Form
    {
        public ChatBot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from = "55933432323";
            string to = textBox1.Text;
            string msg = textBox2.Text;

            //WhatsApp wa = new WhatsApp();
        }
    }
}
