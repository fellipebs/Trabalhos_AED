using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArvoreBinaria;


namespace ConsoleApplication1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
           
            Console.WriteLine("Escreva o número que você deseja: \n 1 - Informar arquivo \n 2 - Pesquisar por uma palavra \n 3 - Imprimir índice em ordem alfabética \n 4 - Imprimir índice em pré - ordem \n 5 - Imprimir índice em pós - ordem \n 6 - Sair");
            int numero = 0;
            Arvore v = new Arvore();
            while (numero != 6)
            {
                numero = int.Parse(Console.ReadLine());
                if (numero == 1)
                {
                    string line;
                    OpenFileDialog theDialog = new OpenFileDialog();
                    theDialog.Title = "Open Text File";
                    theDialog.Filter = "TXT files|*.txt";
                    theDialog.InitialDirectory = @"c:\";
                    if (theDialog.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.StreamReader file = new System.IO.StreamReader(theDialog.FileName.ToString());
                        int count = 0;
                        while ((line = file.ReadLine()) != null)
                        {
                            string dadosDoCadastro = line;
                            string[] teste = dadosDoCadastro.Split(' ');
                            
                            foreach (string testes in teste)
                            {
                                v.inserir(testes);

                                string str = dadosDoCadastro;
                                int start;
                                int at;
                                string aux = "";
                                at = 0;
                                start = 0;
                                while ((start < str.Length) && (at > -1))
                                {
                                    at = str.IndexOf(testes, start);
                                    if (at == -1) break;
                                    aux = Convert.ToString(at);
                                    v.concatena("<"+ testes + ">;"+"("+aux+","+count+");");
                                    start = at + 1;
                                }
       
                            }
                            count++;
                        }

                    }
                }
                else if (numero == 2)
                {
                    Console.WriteLine("Escreva a palavra!");
                    string palavra = Console.ReadLine();
                    NoArvore resp = v.pesquisar(palavra, v.raiz);
                    if (resp == null)
                    {
                        Console.WriteLine("Palavra não encontrada!");
                    }
                    else
                    {
                        //Console.WriteLine("Palavra encontrada: " + resp.chave);
                        string aux2 = " <"+resp.chave+">";
                        string aux = v.stringona();
                       
                        string phrase = aux;
                        string[] words = phrase.Split(';');
                        int i = 0;
                        while (i < words.Length)
                        {
                            if(words[i] == aux2)
                            {
                                Console.WriteLine(words[i] + words[i+1]);
                            }

                            i++;
                        }
                    }
                }
                else if (numero == 3)
                {
                    v.emOrdem(v.raiz);
                }
                else if (numero == 4)
                {
                    v.preOrdem(v.raiz);
                }
                else if (numero == 5)
                {
                    v.posOrdem(v.raiz);
                }
                else
                {
                    Console.WriteLine("Opção não identificada!");
                }

            }


            
            
            Console.ReadLine();
        }
    }
}
