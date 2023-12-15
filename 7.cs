﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET_3._7
{
    internal class Program
    {
        static void Main(string[] args)
        //Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.
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
            InverseazaVector(vector);
            Console.WriteLine("Vectorul dupa inversare:");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"{vector[i]} ");
            }
            Console.ReadLine();
        }
        static void InverseazaVector(int[] vector)
        {
            int lungime = vector.Length;
            for (int i = 0; i < lungime / 2; i++)
            {
                int temp = vector[i];
                vector[i] = vector[lungime - 1 - i];
                vector[lungime - 1 - i] = temp;
            }
        }
    }
}