using System;
using System.Collections.Generic;

namespace Aula212_ConjuntosExProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();  // Cria conjunto para o curso A
            HashSet<int> courseB = new HashSet<int>(); // Cria conjunto para o curso B
            HashSet<int> courseC = new HashSet<int>(); // Cria conjunto para o curso C

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine()); // Variavel auxiliar para contagem do Loop
            for (int i = 0; i < n; i++) // Loop
            {
                int course = int.Parse(Console.ReadLine());
                courseA.Add(course); // Adiciona ao conjunto do curso A
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine()); // Reutilizacao da variavel auxiliar para contagem do Loop
            for (int i = 0; i < n; i++) // Loop
            {
                int course = int.Parse(Console.ReadLine());
                courseB.Add(course); // Adiciona ao conjunto do curso B
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine()); // Reutilizacao da variavel auxiliar para contagem do Loop
            for (int i = 0; i < n; i++) // Loop
            {
                int course = int.Parse(Console.ReadLine());
                courseC.Add(course); // Adiciona ao conjunto do curso C
            }

            HashSet<int> all = new HashSet<int>(courseA); // Conjunto "all" contendo os elementos do conjunto do curso A
            all.UnionWith(courseB); // Adiciona os elementos (sem repetir) do conjunto do curso B ao conjunto "all"
            all.UnionWith(courseC); // // Adiciona os elementos (sem repetir) do C ao "all" (ja somado a B)
            Console.WriteLine("Total students: " + all.Count); // Contagem dos elementos de "all"
        }
    }
}
