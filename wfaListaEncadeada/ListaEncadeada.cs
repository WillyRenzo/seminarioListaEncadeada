using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaListaEncadeada
{
    class ListaEncadeada
    {
        public NohLista cabeca, cauda;

        //Inserir elemento no fim da lista
        public void insereFim(int elemento)
        {
            NohLista novoNoh = new NohLista();
            novoNoh.setData(elemento);

            if (cabeca == null)
            {
                cabeca = novoNoh;
            }
            else
            {
                cauda.setNext(novoNoh);
            }
            cauda = novoNoh;
        }

        //Inserir elemento no inicio da lista
        public void insereInicio(int elemento)
        {
            NohLista novo = new NohLista();
            novo.setData(elemento);

            if (cabeca == null)
            {
                cabeca = novo;
                cauda = novo;
            }
            else
            {
                novo.setNext(cabeca);
            }
            cabeca = novo;
        }

        //Retirar elemento do fim da lista
        public void retiraFim()
        {
            if (cabeca == null)
                return;

            if (cabeca.getNext() == null)
            {
                Console.WriteLine("Elemento retirado: " + cabeca.getData());
                cabeca = null;
            }
            else
            {
                NohLista ultimo = cabeca.getNext();
                NohLista penultimo = cabeca;

                while (ultimo.getNext() != null)
                {
                    penultimo = ultimo;
                    ultimo = ultimo.getNext();
                }
                penultimo.setNext(null);
                Console.WriteLine("Elemento retirado: " + ultimo.getData());
            }
            this.exibir();
        }

        //Retirar elemento do inicio da lista
        public void retiraInicio()
        {
            if (cabeca != null)
            {
                Console.WriteLine("Elemento retirado: " + cabeca.getData());
                cabeca = cabeca.getNext();
            }
            exibir();
        }

        //Exibir elementos da lista
        public void exibir()
        {

            if (cabeca != null)
            {
                NohLista temp = cabeca;
                while (temp != null)
                {
                    Console.Write(temp.getData() + " ");
                    temp = temp.getNext();
                }
            }
            else
            {
                Console.WriteLine("\nLista vazia");
            }
        }
    }
}