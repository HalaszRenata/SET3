using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        //Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma += vector[i];
            }
            Console.WriteLine($"Suma elementelor vectorului este: {suma}");
            Console.ReadLine();
        }

    }
}
