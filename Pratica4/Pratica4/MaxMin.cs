using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica4
{
    class MaxMin
    {

        // Operação relevante: TESTES (if)
        // T(n) = 2n - 2
        public void MaxMin1(int[] vet)
        {
            int ma, me;
            int i;
            int count = 0;
            ma = me = vet[0];
            for (i = 1; i < vet.Length; i++)
            {
                count += 2;
                if (vet[i] < me )
                {
                    me = vet[i];
                }
                if (vet[i] > ma)
                {
                    ma = vet[i];
                }
            }
            Console.WriteLine(count);
        }

        // Melhor caso: T(n) = n - 1
        // Pior caso: T(n) = 2n - 2
        // Caso médio: T(n) = 3n/2 - 3/2
        public void MaxMin2(int[] vet)
        {
            int ma, me, count = 0;
            int i;
            ma = me = vet[0];
            for (i = 1; i < vet.Length; i++)
            {
                count++;
                if (vet[i] < me)
                    me = vet[i];
                else
                {
                    count++;
                    if (vet[i] > ma)
                        ma = vet[i];
                }
            }
            Console.WriteLine(count);
        }

        // T(n) = 3n/2 - 2
        public void MaxMin3(int[] vet)
        {
            int ma, me, count = 0;
            int i;
            count++;
            if (vet[0] < vet[1])
            {
                me = vet[0];
                ma = vet[1];
            }
            else
            {
                me = vet[1];
                ma = vet[0];
            }
            for (i = 2; i < vet.Length; i += 2)
            {
                count += 3;
                if (vet[i] < vet[i + 1])
                {
                    if (vet[i] < me)
                        me = vet[i];
                    if (vet[i + 1] > ma)
                        ma = vet[i + 1];
                }
                else
                {
                    if (vet[i + 1] < me)
                        me = vet[i + 1];
                    if (vet[i] > ma)
                        ma = vet[i];
                }
            }
            Console.WriteLine(count);



        }
        public static void shellSort(int[] vet)
        {
            int i, j, x, n;
            int h = 1;
            n = vet.Length;
            do
            {
                h = h * 3 + 1; // Calcula o valor inicial de h, 
                               // que representa o tamanho do salto
            } while (h <= n);
            do
            {
                h /= 3; //Divisão de h por 3, pois ao  final do
                        // do while, estaremos um salto a frente
                        //do tamanho do vetor
                for (i = h; i < n; i++) //For para comparação de acordo com o salto h
                {   
                    //i recebe o tamanho do salto
                    // Enquanto i < n (vetor completo), continua-se comparando
                    x = vet[i];
                    j = i; 
                    while (j > (h - 1) && vet[j - h] > x) // Aqui temos a comparação
                    {                                     // dos valores de acordo com o
                        vet[j] = vet[j - h];              // salto, vemos um while pois 
                        j -= h;                           // ele irá comparar até que o 
                    }                                     // valor presente no menor indice seja
                    vet[j] = x;                           // menor que o de maior indice
                }
            } while (h != 1); // Repetir até a divisão chegar em h = 1
        }
    }
}
