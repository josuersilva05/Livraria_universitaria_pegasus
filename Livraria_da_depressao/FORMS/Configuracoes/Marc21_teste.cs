using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;

namespace Livraria_da_depressao.FORMS.Configuracoes
{
    public partial class Marc21_teste : Form
    {

        public Marc21_teste()
        {
            InitializeComponent();
        }

        public object JsonSerializer { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            //string jsonString = JsonSerializer.ToString();
            WebClient client = new WebClient();
            //string strPageCode = client.DownloadString("https://raw.githubusercontent.com/pkiraly/metadata-qa-marc/d11077c2a71903112b0c24225bd0f42bc1c80f1f/src/main/resources/marc-schema.json");
            string strPageCode = client.DownloadString("https://raw.githubusercontent.com/pkiraly/metadata-qa-marc/master/src/main/resources/marc-schema.json");
            dynamic dobj = JsonConvert.DeserializeObject<dynamic>(strPageCode);
            
            richTextBox1.Text = strPageCode;
            richTextBox2.Text = dobj.ToString();
        }
    }
}
