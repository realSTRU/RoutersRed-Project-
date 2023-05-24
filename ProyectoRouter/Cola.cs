using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRouter
{
    class Cola
    {
        private NodoLista _head;
        private NodoLista _tail;

        public Cola()
        {
            _head = _tail = null;
        }
        public bool Esvacia()
        {
            return _head == null;
        }
        public void Push(PaqueteDato valor)
        {
            NodoLista dato = new NodoLista(valor);

            if (Esvacia())
            {
                _head = _tail = dato;
            }
            else
            {
                _tail.siguiente = dato;
                _tail = dato;
            }
        }
        public void Push(PaqueteDato valor, int prioridad)
        {
            NodoLista nuevo = new NodoLista(valor, prioridad);

            if (Esvacia())
            {
                _head = _tail = nuevo;
            }
            else
            {
                if (nuevo.prioridad < _head.prioridad)
                {
                    nuevo.siguiente = _head;
                    _head = nuevo;

                }
                else
                {
                    NodoLista aux = _head;

                    while (aux.siguiente != null && nuevo.prioridad >= aux.siguiente.prioridad)
                    {
                        aux = aux.siguiente;
                    }

                    nuevo.siguiente = aux.siguiente;
                    aux.siguiente = nuevo;

                    if (nuevo.siguiente == null)
                    {
                        _tail = nuevo;
                    }
                }
            }

        }
        public NodoLista Pop()
        {
            NodoLista aux = _head;

            _head = _head.siguiente;
            aux.siguiente = null;
            return aux;

        }
        public PaqueteDato PeekValor()
        {
            return _head.dato;
        }
        public NodoLista PeekNodo()
        {
            NodoLista aux = new NodoLista(_head.dato);

            return aux;
        }

        public void Imprimir()
        {

            NodoLista Aux = _head;

            if (Esvacia())
            {
                throw new Exception("La lista esta vacia");
            }
            else
            {

                while (Aux != null)
                {

                    Console.WriteLine(Aux.dato);
                    Aux = Aux.siguiente;

                }

            }
        }

        public PaqueteDato getDato(int pos)
        {
            NodoLista aux = _head;
            int i = 0;
            while (aux != null)
            {

                if (pos == i)
                {

                    return aux.dato;
                }
                i++;
                aux = aux.siguiente;
            }
            return null;

        }
    }
}
