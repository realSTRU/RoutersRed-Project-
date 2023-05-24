using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRouter
{
    class TablaHash
    {
        private int _TamanoTabla;
        protected int NumElementos;
        protected double FactorDeCarga;
        protected Pila[] Tabla;

        public TablaHash(int Tam)
        {
            _TamanoTabla = Tam;
            Tabla = new Pila[_TamanoTabla];

            for (int j = 0; j < _TamanoTabla; j++)
            {
                Pila lista = new Pila();
                Tabla[j] = lista;
            }

            NumElementos = 0;
            FactorDeCarga = 0.0;
        }

        private long TransformacionCadena(string c)
        {
            long d = 0;


            for (int j = 0; j < c.Length; j++)
            {

                d = d * 27 + (int)c[j];


            }

            if (d < 0)
            {
                d = -d;
            }


            return d;
        }

        public int Direccion(string clave)
        {

            long p, d;


            d = TransformacionCadena(clave);

            p = d % _TamanoTabla;


            return (int)p;

        }

        public void insertar(PaqueteDato C)
        {


            int posicion;
            posicion = C.destinoPuerto;

            Pila Aux = Tabla[posicion];
            Aux.Push(C);



        }
        public bool Esvacia(int pos)
        {

            if (Tabla[pos].Esvacia())
                return true;
            else
                return false;
        }

        public void Buscar(int clave)
        {



            int posicion = clave;
            Pila Aux = Tabla[posicion];


            if (Aux.Esvacia())
            {

            }
            else
            {

                Aux.Imprimir();

            }




        }

    }
}
