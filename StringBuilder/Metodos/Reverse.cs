using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revere {
    public static class Reverse {
        public static string ReverterEntrada(string entrada)
        {
            string[] palavras = entrada.Split(' ');
            string primeira = palavras[0];
            string segunda = palavras[1];
            string terceira = palavras[2];

            StringBuilder sb = new StringBuilder();

            sb.Append(segunda);
            sb.Append(" ");
            sb.AppendLine(primeira);
            sb.Append(" ");
            sb.AppendLine(terceira);

            return sb.ToString();

        }
    }
}
