using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRouter
{
    class NodoArbol
    {
        public PaqueteDato dato { get; set; }
        public NodoArbol Hijo { get; set; }
        public NodoArbol Hermano { get; set; }

        public NodoArbol()
        {
            dato = new PaqueteDato();
            Hijo = null;
            Hermano = null;

        }
    }
}
