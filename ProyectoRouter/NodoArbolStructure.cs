using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRouter
{
    class NodoArbol1
    {
        public string dato { get; set; }
        public NodoArbol1 Hijo { get; set; }
        public NodoArbol1 Hermano { get; set; }

        public NodoArbol1()
        {
            dato = "";
            Hijo = null;
            Hermano = null;

        }
    }
}
