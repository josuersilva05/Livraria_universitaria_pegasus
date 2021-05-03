using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Livraria_da_depressao.CODE.DAL
{
    class Conexao
    {
        public static MySqlConnection con = new MySqlConnection(@"Server=localhost;Database=livraria_depressao2;User=root;Pwd=1234567");    
    }

    class ArquivosDeSistema
    {
        public string CurrentDirectory;
        public string ImagesDirectory;

        public ArquivosDeSistema()
        {
            CurrentDirectory = GetCurrentDirectory();
            ImagesDirectory = GetImageDirectory();
        }

        private string GetCurrentDirectory()
        {
            string path = Directory.GetCurrentDirectory();
            return path;
        }

        private string GetImageDirectory()
        {
            string imgFolder = "IMG";
            string imgDirectory = this.CurrentDirectory;
            
            foreach (char character in imgDirectory)
            {
                Directory.SetCurrentDirectory(imgDirectory);
                if (!Directory.Exists(imgFolder))
                {
                    Int32 dirLength = imgDirectory.LastIndexOf("\\");
                    if(dirLength == -1)
                    {
                        break;
                    }
                    imgDirectory = imgDirectory.Substring(0, dirLength);
                }
                else
                {
                    break;
                }
            }
            if(imgDirectory.IndexOf("\\") == -1)
            {
                imgDirectory += "\\";
            }
            string[] dirs = Directory.GetDirectories(@imgDirectory, "I*", SearchOption.TopDirectoryOnly);
            return dirs[0];
        } 
    }
}
