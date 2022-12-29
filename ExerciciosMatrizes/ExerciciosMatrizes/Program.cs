/*Ler dois números M e N, e depois ler uma matriz MxN de números inteiros, conforme exemplo. Em seguida, mostrar
na tela somente os números negativos da matriz.
Entrada:
A entrada contém os números M e N na mesma linha, depois os dados da matriz.
Saída:
A saída contém uma mensagem e depois os números negativos da matriz, conforme exemplo.
Exemplo:
Entrada Saída
2 3
12 -8 5
-13 10 -6
VALORES NEGATIVOS:
-8
-13
-6
*/


using System;

namespace ExercicioMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int M = int.Parse(vet[0]);
            int N = int.Parse(vet[1]);

            int[,] mat = new int[M, N];

            for(int i =0; i<M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j=0; j<N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }
            Console.WriteLine("VALORES NEGATIVOS:");
            for(int i=0; i < M; i++)
            {
                for(int j = 0; j<N; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        Console.WriteLine(mat[i, j]);
                    }
                }
            }
        }
    }
}