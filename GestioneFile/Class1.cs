using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneFile
{
    internal class Class1
    {
        private string testo;
        StreamWriter sw;
        public Class1()
        {
            StreamWriter sw = new StreamWriter("Info.txt");
        }
        
        public void ScriviFile(string t)
        {
            testo = t;
            sw.WriteLine(testo);
            sw.Close();
        }

    }
}
