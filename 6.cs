using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET_3._6
{
    internal class Program
    {
        static void Main(string[] args)
        //Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. 
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
            Console.Write("Introduceti pozitia k pentru stergere (0-primul element): ");
            int k = int.Parse(Console.ReadLine());
            if (k >= 0 && k < n)
            {
                vector = StergeElement(vector, k);
                Console.WriteLine("Vectorul dupa stergere:");
                for (int i = 0; i < vector.Length; i++)
                {
                    Console.Write($"{vector[i]} ");
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Pozitia de stergere este invalida.");
                Console.ReadLine();
            }
        }
        static int[] StergeElement(int[] vector, int k)
        {
            for (int i = k; i < vector.Length - 1; i++)
            {
                vector[i] = vector[i + 1];
            }
            Array.Resize(ref vector, vector.Length - 1);
            return vector;
        }
    }
}