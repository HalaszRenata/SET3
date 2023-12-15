using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        //Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. 
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            Console.WriteLine("Introduceti elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Introduceti valoarea k: ");
            int k = int.Parse(Console.ReadLine());
            int pozitie = GasestePozitie(vector, k);
            if (pozitie != -1)
            {
                Console.WriteLine($"Valoarea {k} apare pentru prima data la pozitia {pozitie + 1} in vector.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Valoarea {k} nu apare in vector. Rezultat: -1");
                Console.ReadLine();
            }
        }
        static int GasestePozitie(int[] vector, int k)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == k)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

