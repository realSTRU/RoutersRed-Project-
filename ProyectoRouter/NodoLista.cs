using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRouter
{
    class NodoLista
    {

        public PaqueteDato dato { get; set; }
        public int prioridad { get; set; }
        public NodoLista siguiente { get; set; }

       
    public NodoLista(PaqueteDato valor)
        {
            dato = valor;
            siguiente = null;
            prioridad = int.MaxValue;
        }

     public NodoLista(PaqueteDato valor, int prioridad1)
        {
            dato = valor;
            siguiente = null;
            prioridad = prioridad1;
        }


    }
}
