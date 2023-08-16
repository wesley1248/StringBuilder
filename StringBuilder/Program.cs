using Revere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse {
    internal class Program {
        static void Main(string[] args)
        {
            Console.Write("digite duas palavras: ");
            string entrada = Console.ReadLine();
            string resultado = Reverse.ReverterEntrada(entrada);
            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}
