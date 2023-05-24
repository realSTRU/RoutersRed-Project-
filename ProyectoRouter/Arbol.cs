using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProyectoRouter
{
    class Arbol
    {
        private NodoArbol Raiz;
        private NodoArbol Trabajo;
        private int i = 0;
        public TablaHash[] tabla;
        public Arbol(int R, int P)
        {
            Raiz = new NodoArbol();

            TablaHash[] T = new TablaHash[R + 1];
            for (int i = 0; i <= R; i++)
            {
                T[i] = new TablaHash(P);
            }
            tabla = T;

        }

        public NodoArbol insertar(PaqueteDato Ndato, NodoArbol Nnodo)
        {
            if (Nnodo == null)
            {
                Raiz = new NodoArbol();
                Raiz.dato = Ndato;
                Raiz.Hijo = null;
                Raiz.Hermano = null;

                return Raiz;
            }
            if (Nnodo.Hijo == null)
            {
                NodoArbol temp = new NodoArbol();
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
                NodoArbol temp = new NodoArbol();
                temp.dato = Ndato;
                Trabajo.Hermano = temp;
                return temp;

            }



        }

        public void PrintTranversaPreOrd(NodoArbol nodo)
        {


            if (nodo == null)
                return;
            for (int n = 0; n < i; n++)
            {
                Console.Write(" ");
            }

            Console.WriteLine(nodo.dato.destinoPuerto);

            if (nodo.Hijo != null)
            {
                i++;
                PrintTranversaPreOrd(nodo.Hijo);
                i--;
            }

            if (nodo.Hermano != null)
            {
                PrintTranversaPreOrd(nodo.Hermano);
            }
        }

        public NodoArbol InsertarP(PaqueteDato dato, NodoArbol nodo)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            NodoArbol encontrado = null;
            if (nodo == null)
                return encontrado;

            if (nodo.dato.destinoPuerto == dato.destinoPuerto && nodo.dato.destinoRouter == dato.destinoRouter)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                nodo.dato = dato;
                tabla[nodo.dato.destinoRouter].insertar(nodo.dato);
                Console.WriteLine($"\n{dato} recibido con exito en la terminal {nodo.dato.destinoPuerto} del router {nodo.dato.destinoRouter}");
                Thread.Sleep(200);
                Console.WriteLine("¡Añadido con Exito!");
                encontrado = nodo;
                Console.ForegroundColor = ConsoleColor.White;
                return encontrado;
                
            }
            else if(nodo.dato.destinoRouter!=-1)
            {
                Console.WriteLine($"{dato} no pertenece a la terminal {nodo.dato.destinoPuerto} del router {nodo.dato.destinoRouter}");
                Thread.Sleep(200);
            }

            if (nodo.Hijo != null)
            {
                encontrado = InsertarP(dato, nodo.Hijo);

                if (encontrado != null)
                    return encontrado;
            }

            if (nodo.Hermano != null)
            {
                encontrado = InsertarP(dato, nodo.Hermano);

                if (encontrado != null)
                    return encontrado;
            }

            return encontrado;


        }

        public NodoArbol Buscar(int dato, NodoArbol nodo)
        {
            NodoArbol encontrado = null;
            if (nodo == null)
                return encontrado;

            if (nodo.dato.destinoPuerto.CompareTo(dato) == 0)
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
