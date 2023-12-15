using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET3._31
{
    internal class Program
    {
        static void Main(string[] args)
        //(Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 din valorile vectorului sunt egale cu m (prin urmare, daca un vector are element majoritate acesta este unui singur).  Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>). (incercati sa gasiti o solutie liniara). 
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int lungime = Convert.ToInt32(Console.ReadLine());
            int[] vector = new int[lungime];
            Console.WriteLine("Introduceti elementele vectorului:");
            for (int i = 0; i < lungime; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            int majoritate = GasesteElementMajoritate(vector);
            if (majoritate != -1)
            {
                Console.WriteLine($"Elementul majoritate este: {majoritate}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Nu exista element majoritate.");
                Console.ReadLine();
            }
        }
        static int GasesteElementMajoritate(int[] vector)
        {
            int majoritateCandidat = -1;
            int count = 0;
            foreach (int element in vector)
            {
                if (count == 0)
                {
                    majoritateCandidat = element;
                    count = 1;
                }
                else if (element == majoritateCandidat)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            count = 0;
            foreach (int element in vector)
            {
                if (element == majoritateCandidat)
                {
                    count++;
                }
            }
            return count > vector.Length / 2 ? majoritateCandidat : -1;
        }
    }
}
