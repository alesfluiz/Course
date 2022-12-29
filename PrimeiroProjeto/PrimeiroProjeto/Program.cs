using System;
using System.Globalization;
using System.Xml;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] vls = Console.ReadLine().Split(' ');

            int[] vet = new int[N];
            int cont = 0;
            for (int i = 0; i<N; i++)
            {
                vet[i] = int.Parse(vls[i]);
                
                if (vet[i] % 2 == 0)
                {
                    int pares = vet[i];
                    cont++;
                    Console.Write(pares+" ");
                }
                

            }
            Console.WriteLine();
            Console.WriteLine(cont);
        }
    }
}