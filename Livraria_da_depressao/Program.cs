﻿using Livraria_da_depressao.FORMS.Assistente_virtual;
using Livraria_da_depressao.FORMS.Configuracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria_da_depressao
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Marc21_teste());
            //Application.Run(new frmLogin());
        }
    }
}
