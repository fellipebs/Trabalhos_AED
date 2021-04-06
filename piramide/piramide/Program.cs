using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lógica com WHILE e um IF
            /*
            Console.WriteLine("Escreva o número de linhas da piramide: ");
            int num = 0;
            int i = 0;
            num = int.Parse(Console.ReadLine());
            int num2 = 0;
            int espacos = num - 1;
            while (num >= i)
            {
                int y = 0;
                int z = 0;
                
                while (espacos >= y)
                {
                    Console.Write(" ");
                    y++;
                }

                while (num2 > z)
                {
                    if (z == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("*");
                        Console.Write("*");
                    }
                    
                    z++;
                }

                Console.WriteLine();
                num2++;
                espacos--;
                i++;
            }
                
            Console.ReadKey();
            */





            /*
            //Lógica com FOR
            Console.WriteLine("Escreva o número de linhas da piramide");
            int linhas = int.Parse(Console.ReadLine()); 
            int espaco;
            int numero;
            
            for (int i = 1; i <= linhas; i++)  // Declarando for inicial com o número de linhas
            {

                for (espaco = 1; espaco <= (linhas - i); espaco++) // For para os espacos  
                { 
                    Console.Write(" ");
                }
                for (numero = 1; numero <= i; numero++) //Numero de asteriscos baseando em que linha estou, caso primeira linha, joga para a de baixo
                { 
                    Console.Write('*');
                }
                for (numero = (i - 1); numero >= 1; numero--) //Numero de asteriscos baseando em que linha estou
                {
                    Console.Write('*');
                }

                Console.WriteLine(); // Quebra de linhas
            }


            Console.ReadKey();
            */






            //Lógica passada pelo virgilio:

            int numlinhas;
            Console.Write("Digite o número de linhas: ");
            numlinhas = Convert.ToInt32(Console.ReadLine());

            for (int linha = 0; linha < numlinhas; linha++)
            {
                for (int i = 0; i < numlinhas - 1 - linha; i++)
                {
                    Console.Write(" ");
                }

                for (int i = 0; i < 2 * linha + 1; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
