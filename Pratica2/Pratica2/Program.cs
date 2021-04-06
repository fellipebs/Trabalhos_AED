using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiposAbstratosDeDados;

namespace Pratica2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho = 0;

            Console.WriteLine("Boas vindas ao restaurante da Dona Tita! \n Escreva o tamanho das filas:");
            tamanho = int.Parse(Console.ReadLine());
            
            Fila pedido = new Fila(tamanho); //Fila de pedidos
            Fila pagamento = new Fila(tamanho); //Fila de pagamento
            Fila encomenda = new Fila(tamanho); //Fila de encomenda

            Console.WriteLine("MENU: \n 1 - Inserção de cliente na fila de pedidos \n 2 - Remoção de cliente da fila de pedidos \n 3 - Remoção de cliente da fila de pagamentos \n 4 - Remoção de cliente da fila de encomendas \n 5 - Sair");
            int aux = int.Parse(Console.ReadLine());
            int cliente = 0;
            int aux2 = 0;
            while(aux != 5)
            {
                if (aux == 1)
                {
                    cliente++;
                    pedido.enfileirar(cliente);
                    Console.WriteLine("Cliente " + cliente + " entrou na fila de pedidos.");
                }
                else if (aux == 2)
                {
                    if (pedido.vazia() == false)
                    {
                        aux2 = pedido.desenfileirar();
                        Console.WriteLine("Cliente " + aux2 + " saiu da fila de pedidos.");
                        pagamento.enfileirar(aux2);
                        Console.WriteLine("Cliente " + aux2 + " entrou na fila de pagamento.");
                    }
                    else
                    {
                        Console.WriteLine("Fila de pedidos vazia.");
                    }
                }
                else if (aux == 3)
                {
                    if (pagamento.vazia() == false)
                    {
                        aux2 = pagamento.desenfileirar();
                        Console.WriteLine("Cliente " + aux2 + " saiu da fila de pagamento.");
                        encomenda.enfileirar(aux2);
                        Console.WriteLine("Cliente " + aux2 + " entrou na fila de encomenda.");
                    }
                    else
                    {
                        Console.WriteLine("Fila de pagamento vazia.");
                    }
                }
                else if (aux == 4)
                {
                    if (encomenda.vazia() == false)
                    {
                        aux2 = encomenda.desenfileirar();
                        Console.WriteLine("Cliente " + aux2 + " saiu na fila de encomenda.");
                    }
                    else
                    {
                        Console.WriteLine("Fila de encomenda vazia.");
                    }
                }

                Console.WriteLine("Novo comando:");
                aux = int.Parse(Console.ReadLine());
            }
        }
    }
}
