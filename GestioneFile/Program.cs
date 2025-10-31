using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Commento di prova
namespace GestioneFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il path");
            string path = Console.ReadLine();

            Writercs w = new Writercs(path);

            w.ScriviFile();

            Console.WriteLine("Operazione completata");
        }
    }
}
