using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposAbstratosDeDados
{
    class TestaLista
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();
            int c, opcao;
            string nome;

                Console.WriteLine("1)Inserir 2)Pesquisar 3)Imprimir 4)Sair 5)Maior");
                opcao = Convert.ToInt32(Console.ReadLine());
            while (opcao != 4) {

                if (opcao == 1) {
                    Console.Write("Digite um nº (-1 para sair): ");
                    c = int.Parse(Console.ReadLine());
                    
                    while (c != -1)
                    {
                       
                        if (l.pesquisar(c) == null)
                        {
                            // Console.Write("Digite outro nº (-1 para sair): ");
                            Console.Write("Digite o nome:");
                            nome = Console.ReadLine();
                            l.inserir(new NoLista(c, nome));
                        }
                        else
                        {
                            Console.Write("Número de chave repetido. Digite outro nº (-1 para sair): ");
                            c = Convert.ToInt32(Console.ReadLine()); 
                        }

                        Console.Write("Digite um nº (-1 para sair): ");
                        c = int.Parse(Console.ReadLine());

                    }
                }

                if (opcao == 2) {
                    Console.Write("Digite um nº a ser pesquisado: ");
                    c = int.Parse(Console.ReadLine());

                    NoLista n = l.pesquisar(c);
                    if (n == null)
                        Console.WriteLine("Valor não encontrado!");
                    else
                        Console.WriteLine("Achou: " + n.chave);
                }

                if (opcao == 3) {
                    l.imprimir();
                    Console.WriteLine("maior chave: " + l.getMaior().chave + ": " + l.getMaior().nome);
                    l.TrocarChaves();
                    l.imprimir();
                    Console.ReadKey();
                }


                Console.WriteLine("1)Inserir 2)Pesquisar 3)Imprimir 4)Sair ");
                opcao = Convert.ToInt32(Console.ReadLine());

            }
            Console.ReadKey();
        }
    }
}
