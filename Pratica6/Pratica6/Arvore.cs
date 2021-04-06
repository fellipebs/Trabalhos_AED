using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinaria
{
    class Arvore
    {
        public NoArvore raiz = null;
        public static string posicoes;

        public string stringona()
        {
            return posicoes;
        }

        public void concatena(string str)
        {
            posicoes = posicoes + " " + str;
        }
        public void inserir(string chave)
        {
            if (raiz == null)
            {
                raiz = new NoArvore(chave);
            }
            else
            {
                raiz.inserir(chave);
            }
        }

        public void emOrdem(NoArvore x)
        {
            if (x != null)
            {
                emOrdem(x.esq);
                Console.Write(x.chave + " ");
                emOrdem(x.dir);
            }
        }

        public void preOrdem(NoArvore x)
        {
            if (x != null)
            {
                Console.Write(x.chave + " ");
                preOrdem(x.esq);
                preOrdem(x.dir);
            }
        }

        public void posOrdem(NoArvore x)
        {
            if (x != null)
            {
                posOrdem(x.esq);
                posOrdem(x.dir);
                Console.Write(x.chave + " ");
            }
        }

        public NoArvore pesquisar(string c, NoArvore x)
        {
            int var = 0;
            if (x != null)
            {
             var = c.CompareTo(x.chave);
            }
            if (x == null || x.chave == c)
                return x;
            else if (var < 0)
                return pesquisar(c, x.esq);
            else
                return pesquisar(c, x.dir);

        }
    }

    public class NoArvore
    {
        public string chave;
        public NoArvore esq, dir;

        public NoArvore(string c)
        {
            chave = c;
            esq = dir = null;
        }

        public void inserir(string c)
        {
            int var = c.CompareTo(chave);
            if (var < 0)
            {
                if (esq == null)
                    esq = new NoArvore(c);
                else
                    esq.inserir(c);
            }
            else if (var > 0)
            {
                if (dir == null)
                    dir = new NoArvore(c);
                else
                    dir.inserir(c);
            }
            else
                Console.Write("Chave duplicada. Impossível inserir!");
        } // fim do metodo inserir
    }
}

