using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaListaEncadeada
{
    class NohLista
    {
        // atributos
        private NohLista prev;
        private int data;
        private NohLista next;

        // metodos

        public NohLista()
        {
            this.prev = null;
            this.data = 0;
            this.next = null;

        }

        public NohLista(NohLista _prev, int _data)
        {
            this.prev = _prev;
            this.data = _data;
            this.next = null;
        }

        public NohLista(NohLista _prev, int _data, NohLista _next)
        {
            this.prev = _prev;
            this.data = _data;
            this.next = _next;
        }

        public void setPrev(NohLista _prev)
        {
            this.prev = _prev;
        }

        public NohLista getPrev()
        {
            return this.prev;
        }

        public void setData(int _data)
        {
            this.data = _data;
        }

        public int getData()
        {
            return this.data;
        }

        public void setNext(NohLista _next)
        {
            this.next = _next;
        }

        public NohLista getNext()
        {
            return this.next;
        }
    }
}
