using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET3._20
{
    internal class Program
    {
        static void Main(string[] args)
        //Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem. 
        {
            Console.Write("Introduceti primul sirag de margele (s1): ");
            string s1 = Console.ReadLine();
            Console.Write("Introduceti al doilea sirag de margele (s2): ");
            string s2 = Console.ReadLine();
            int overlapCount = CountOverlaps(s1, s2);
            Console.WriteLine($"Numarul de suprapuneri este: {overlapCount}");
            Console.ReadLine();
        }
        static int CountOverlaps(string s1, string s2)
        {
            int s1Length = s1.Length;
            int s2Length = s2.Length;
            int overlapCount = 0;
            for (int i = 0; i < s1Length; i++)
            {
                bool match = true;
                for (int j = 0; j < s1Length - i; j++)
                {
                    if (s1[i + j] != s2[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                    overlapCount++;
            }
            return overlapCount;
        }
    }
}