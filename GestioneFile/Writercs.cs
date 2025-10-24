using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneFile
{
    internal class Writercs
    {
        private string filePath;

        public Writercs(string path)
        {
            this.filePath = path;
        }

        public void ScriviFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))  //Crea un oggetto
                {
                    writer.WriteLine("Prima riga");   //Scrive sul file di testo
                    writer.WriteLine("Seconda riga");
                    writer.WriteLine("Terza riga");
                }

                Console.WriteLine("File scritto con successo");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore nella scrittura del file" + ex.Message);
            }
        }

    }
}
