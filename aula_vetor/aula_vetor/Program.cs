using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_vetor
{
    class Program
    {
        static void Main(string[] args)
        {

            //VETOR CRESCENTE DE 10 VALORES
            int i = 0;
            int[] vetor = new int[10];

            while (i < 10)
            {
                vetor[i] = i;
                i++;
            }

            int y = 0;
            Console.WriteLine("Array Crescente:");

            while (y < 10)
            {
                Console.WriteLine(vetor[y]);
                y++;
            }
            //VETOR DECRESCENTE DE 10 VALORES
            Console.WriteLine("Array Decrescente:");
            int[] vetor2 = new int[10];
            y = 0;
            i = 0;
            int var = 10;

            while (i < 10)
            {
                vetor2[i] = var--;
                i++;
            }

            while (y < 10)
            {
                Console.WriteLine(vetor2[y]);
                y++;
            }
            //VETOR ALEATORIO DE 10 VALORES
            Console.WriteLine("Array Aleatorio:");

            y = 0;
            i = 0;
            int[] vetor3 = new int[10];
            Random x = new Random(100);
            while (i < 10)
            {
                vetor3[i] = x.Next(1,100);
                i++;
            }

            while (y < 10)
            {
                Console.WriteLine(vetor3[y]);
                y++;
            }



            // Versão do Virgilio
            /*
            int[] cre = new int[10];
            int[] dec = new int[10];
            int[] ran = new int[10];
            Random r = new Random();
            for (int u = 0; u < cre.Length; u++)
            {
                cre[u] = u;
                dec[u] = 10 - u;
                ran[u] = r.Next(1,100);
            }


            Console.WriteLine("Versão do virgilio:");
            // Impressão

            for (int u = 0; u < cre.Length; u++)
            {
                Console.WriteLine(cre[u]);
            }
            for (int u = 0; u < dec.Length; u++)
            {
                Console.WriteLine(dec[u]);
            }
            for (int u = 0; u < dec.Length; u++)
            {
                Console.WriteLine(ran[u]);
            }
            */




            //EXERCICIO MATRIZ
            /*
            int[,] mat = new int[7, 7];

            i = 0;
            int j = 0;

            for (i = 0; i < 7; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    if (i == j)
                    {
                        mat[i, j] = 0;
                    }
                    else if (i > j)
                    {
                        mat[i, j] = 1;
                    }
                    else
                    {
                        mat[i, j] = 2;
                    }
                }
               
            }

            for (i = 0; i < 7; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    Console.Write(mat[i,j] + " ");
                }
                Console.WriteLine();
            }
            */
            int[,] mat = new int[7, 7];

            i = 0;
            int j = 0;
            for (i = 0; i < 7; i++)
            {
                mat[i, i] = 0;

                for (j = i + 1; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = 2;
                }
                for (j = 0; j < i; j++)
                {
                    mat[i, j] = 1;
                }
            }

                
            for (i = 0; i < 7; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
