using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET3._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.
            Console.Write("Introdu lungimea vectorului: ");
            int lungime = int.Parse(Console.ReadLine());
            int[] vector = new int[lungime];
            Console.WriteLine("Introdu elementele vectorului:");
            for (int i = 0; i < lungime; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }
            int cmmd = CalculCMMD(vector);
            Console.WriteLine($"Cel mai mare divizor comun al elementelor vectorului este: {cmmd}");
            Console.ReadLine();
        }
        static int CalculCMMD(int[] vector)
        {
            int cmmd = vector[0];
            for (int i = 1; i < vector.Length; i++)
            {
                cmmd = CalculCMMD2(cmmd, vector[i]);
                if (cmmd == 1)
                {
                    break;
                }
            }
            return cmmd;
        }
        static int CalculCMMD2(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}

