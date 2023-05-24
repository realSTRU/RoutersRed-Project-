using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRouter
{
    class Pila
    {
        private NodoLista _cima;

        public Pila()
        {
            _cima = null;
        }
        public bool Esvacia()
        {
            return _cima == null;
        }
        public void Push(PaqueteDato valor)
        {
            NodoLista dato = new NodoLista(valor);

            if (Esvacia())
            {
                _cima = dato;
            }
            else
            {
                dato.siguiente = _cima;
                _cima = dato;
            }
        }
        public void Push(PaqueteDato valor, int prioridad)
        {
            NodoLista nuevo = new NodoLista(valor, prioridad);

            if (Esvacia())
            {
                _cima = nuevo;
            }
            else
            {
                if (nuevo.prioridad < _cima.prioridad)
                {
                    nuevo.siguiente = _cima;
                    _cima = nuevo;

                }
                else
                {
                    NodoLista aux = _cima;

                    while (aux.siguiente != null && nuevo.prioridad >= aux.siguiente.prioridad)
                    {
                        aux = aux.siguiente;
                    }

                    nuevo.siguiente = aux.siguiente;
                    aux.siguiente = nuevo;

                    if (nuevo.siguiente == null)
                    {
                        _cima = nuevo;
                    }
                }
            }

        }
        public NodoLista Pop()
        {
            NodoLista aux = _cima;

            _cima = _cima.siguiente;
            aux.siguiente = null;
            return aux;

        }
        public PaqueteDato PeekValor()
        {
            return _cima.dato;
        }
        public NodoLista PeekNodo()
        {
            NodoLista aux = new NodoLista(_cima.dato);

            return aux;
        }

        public void Imprimir()
        {

            NodoLista Aux = _cima;

            if (Esvacia())
            {
                throw new Exception("La lista esta vacia");
            }
            else
            {

                while (Aux != null)
                {

                    Console.WriteLine(Aux.dato);
                    Console.WriteLine();
                    Aux = Aux.siguiente;

                }

            }
        }
    }
}
