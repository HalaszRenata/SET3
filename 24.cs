using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET3._24
{
    internal class Program
    {
        static void Main(string[] args)
        //Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).
        {
            Console.WriteLine("Introduceti elementele primului vector (0 sau 1) separate prin spatii:");
            bool[] v1 = CitesteVectorDeLaTastatura();
            Console.WriteLine("Introduceti elementele celui de-al doilea vector (0 sau 1) separate prin spatii:");
            bool[] v2 = CitesteVectorDeLaTastatura();

            var intersectie = v1.Zip(v2, (a, b) => a & b).ToArray();
            var reuniune = v1.Zip(v2, (a, b) => a | b).ToArray();
            var diferentaV1V2 = v1.Zip(v2, (a, b) => a & !b).ToArray();
            var diferentaV2V1 = v2.Zip(v1, (a, b) => a & !b).ToArray();

            Console.WriteLine("Intersectie: " + string.Join(", ", intersectie.Select(b => b ? "1" : "0")));
            Console.WriteLine("Reuniune: " + string.Join(", ", reuniune.Select(b => b ? "1" : "0")));
            Console.WriteLine("Diferenta v1 - v2: " + string.Join(", ", diferentaV1V2.Select(b => b ? "1" : "0")));
            Console.WriteLine("Diferenta v2 - v1: " + string.Join(", ", diferentaV2V1.Select(b => b ? "1" : "0")));
            Console.ReadLine();
        }
        static bool[] CitesteVectorDeLaTastatura()
        {
            string input = Console.ReadLine();
            return input.Split(' ').Select(s => s == "1").ToArray();
        }
    }
}