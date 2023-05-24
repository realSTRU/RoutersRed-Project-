using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProyectoRouter
{
    class Arbol1
    {
        private NodoArbol1 Raiz;
        private NodoArbol1 Trabajo;
        private int i = 0;

        public Arbol1()
        {
            Raiz = new NodoArbol1();
        }

        public NodoArbol1 insertar(string Ndato, NodoArbol1 Nnodo)
        {
            if (Nnodo == null)
            {
                Raiz = new NodoArbol1();
                Raiz.dato = Ndato;
                Raiz.Hijo = null;
                Raiz.Hermano = null;

                return Raiz;
            }
            if (Nnodo.Hijo == null)
            {
                NodoArbol1 temp = new NodoArbol1();
                temp.dato = Ndato;
                Nnodo.Hijo = temp;

                return temp;
            }
            else
            {
                Trabajo = Nnodo.Hijo;
                while (Trabajo.Hermano != null)
                {
                    Trabajo = Trabajo.Hermano;
                }
                NodoArbol1 temp = new NodoArbol1();
                temp.dato = Ndato;
                Trabajo.Hermano = temp;
                return temp;

            }



        }

        public void PrintTranversaPreOrd(NodoArbol1 nodo, int Npuertos)
        {

            //Console.ForegroundColor = ConsoleColor.Red;
            if (nodo == null)
                return;
            for (int n = 0; n < i; n++)
            {

                Console.Write(" ");


            }

            if (nodo.Hermano != null)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (nodo.dato != Convert.ToString(Npuertos - 1))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine(nodo.dato);
            Thread.Sleep(200);



            if (nodo.Hijo != null)
            {

                i++;
                PrintTranversaPreOrd(nodo.Hijo, Npuertos);
                i--;

            }

            if (nodo.Hermano != null)
            {

                PrintTranversaPreOrd(nodo.Hermano, Npuertos);
            }
        }

        public void PrintTranversaPostOrd(NodoArbol1 nodo)
        {
            if (nodo == null)
                return;
            if (nodo.Hijo != null)
            {
                i++;
                PrintTranversaPostOrd(nodo.Hijo);
            }

            if (nodo.Hermano != null)
                PrintTranversaPostOrd(nodo.Hermano);
            for (int n = 0; n < i; n++)
            {
                Console.Write(" ");
            }

            Console.WriteLine(nodo.dato);


        }

        public NodoArbol1 Buscar(string dato, NodoArbol1 nodo)
        {
            NodoArbol1 encontrado = null;
            if (nodo == null)
                return encontrado;

            if (nodo.dato.CompareTo(dato) == 0)
            {
                encontrado = nodo;
                return encontrado;
            }

            if (nodo.Hijo != null)
            {
                encontrado = Buscar(dato, nodo.Hijo);

                if (encontrado != null)
                    return encontrado;
            }

            if (nodo.Hermano != null)
            {
                encontrado = Buscar(dato, nodo.Hermano);

                if (encontrado != null)
                    return encontrado;
            }

            return encontrado;


        }



    }
}
