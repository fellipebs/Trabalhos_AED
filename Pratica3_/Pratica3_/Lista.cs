using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposAbstratosDeDados
{
    class NoLista
    {
        public int chave;
        public string nome;
        // Posso colocar quantos atributos eu quiser
        public NoLista prox;
        public NoLista(int c, string n)
        {
            chave = c;
            nome = n;
            prox = null;
        }
    }

    class Lista
    {
        private NoLista prim, ult;

        public Lista()
        {
            prim = ult = null;
        }

        public void inserir(NoLista item)
        {
            if (prim == null)
                prim = item;
            else
                ult.prox = item;
            ult = item;
        }

        public void imprimir()
        {
            NoLista aux = prim;
            while (aux != null)
            {
                Console.WriteLine(aux.chave + " " + aux.nome);
                aux = aux.prox;
            }
        }

        public NoLista pesquisar(int c)
        {
            NoLista aux = prim;
            while (aux != null && aux.chave != c)
            {
                aux = aux.prox;
            }
            return aux;
        }

        public bool remover(int c)
        {
            NoLista aux = prim, ant = null;
            while (aux != null && aux.chave != c)
            {
                ant = aux;
                aux = aux.prox;
            }
            if (aux != null)
            {
                if (ant != null) // não é o primeiro 
                    ant.prox = aux.prox;
                else // é o primeiro
                    prim = aux.prox;
                if (aux == ult) // é o último
                    ult = ant;
                aux.prox = null; // desconecta o nó da lista
                return true;
            }
            return false;
        }

        public NoLista getMaior()
        {
            NoLista aux = prim;
            NoLista maior = prim;
             
            while (aux != null)
            {
                if (aux.chave > maior.chave)
                {
                    maior = aux;
                }
                aux = aux.prox;  
            }
            return maior;
        }


        public void TrocarChaves()
        {
            NoLista aux = prim;
            prim = prim.prox;
            ult.prox = aux;
            aux.prox = null;
        }

        public Lista Interseccao(Lista b)
        {
            Lista r = new Lista();
            NoLista aux = prim;
            while (aux != null)
            {
                if (b.pesquisar(aux.chave) != null)
                {
                    r.inserir(new NoLista(aux.chave, aux.nome));
                }
                aux = aux.prox;

            }

            return r;
        }

    }
}
