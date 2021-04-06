using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica4
{
    class Program
    {
        static void Main(string[] args)
        {
            //VETOR CRESCENTE DE 1000 VALORES
            int i = 0;
            int[] vetor = new int[8];

            while (i < 8)
            {
                vetor[i] = i;
                i++;
            }

            MaxMin M = new MaxMin();

            

            //VETOR DECRESCENTE DE 10 VALORES
            int[] vetor2 = new int[8]; 
            i = 0;
            int var = 8;

            while (i < 8)
            {
                vetor2[i] = var--;
                i++;
            }

            


            //VETOR ALEATORIO DE 10 VALORES
            i = 0;
            int[] vetor3 = new int[8];
            Random x = new Random(100);
            while (i < 8)
            {
                vetor3[i] = x.Next(1, 50);
                i++;
            }

            Console.WriteLine("MaxMin1");
            

            i = 0;
            while (i < vetor3.Length)
            {
                //Console.Write(vetor3[i] + " ");
                i++;
            }



            M.MaxMin1(vetor);
            M.MaxMin1(vetor2);
            M.MaxMin1(vetor3);

            Console.WriteLine("MaxMin2");
            M.MaxMin2(vetor);
            M.MaxMin2(vetor2);
            M.MaxMin2(vetor3);

            Console.WriteLine("MaxMin3");
            M.MaxMin3(vetor);
            M.MaxMin3(vetor2);
            M.MaxMin3(vetor3);

            
        }
    }
}
