using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha p = new Pilha(1000);
            string num = "";
            int numDesempilha1, numDesempilha2, total;
            int i = 0;
            while (true)
            {
                Console.Write("Digite um número ou operador (*,/,+,-): ");
                num = Console.ReadLine();
                if (num == "*" || num == "/" || num == "+" || num == "-")
                {
                    if (p.vazia() || i == 1)
                    {
                        Console.WriteLine("Digite antes dois números.");
                    }
                    else
                    {
                        numDesempilha1 = p.desempilhar();
                        numDesempilha2 = p.desempilhar();

                        if (num == "*")
                        {
                            total = numDesempilha1 * numDesempilha2;
                            p.empilhar(total);
                            Console.WriteLine(total);
                        }
                        else if (num == "/")
                        {
                            total = numDesempilha2 / numDesempilha1;
                            p.empilhar(total);
                            Console.WriteLine(total);
                        }
                        else if (num == "-")
                        {
                            total =  numDesempilha2 - numDesempilha1;
                            p.empilhar(total);
                            Console.WriteLine(total);
                        }
                        else if (num == "+")
                        {
                            total = numDesempilha1 + numDesempilha2;
                            p.empilhar(total);
                            Console.WriteLine(total);
                        }

                    }
                }
                else if (num == "" || num == String.Empty)
                {
                    Console.WriteLine("Digite um valor válido.");
                }
                else
                
                {
                    p.empilhar(Convert.ToInt32(num));
                    i++;
                }
            }

            Console.ReadKey();
        }
    }
}
