using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRouter
{
    class PaqueteDato
    {
        public char dato { get; set; }
        public int prioridad { get; set; }
        public int destinoRouter { get; set; }
        public int destinoPuerto { get; set; }

        public PaqueteDato()
        {
            dato = ' ';
            prioridad = int.MaxValue;
            destinoRouter = 0;
            destinoPuerto = 0;
        }
        public PaqueteDato(int _destinoRouter, int _destinoPuerto)
        {
            dato = ' ';
            prioridad = int.MaxValue;
            destinoRouter = _destinoRouter;
            destinoPuerto = _destinoPuerto;
        }

        public PaqueteDato(char _dato, int _prioridad, int _destinoRouter, int _destinoPuerto)
        {
            dato = _dato;
            prioridad = _prioridad;
            destinoRouter = _destinoRouter;
            destinoPuerto = _destinoPuerto;
        }

        public PaqueteDato(PaqueteDato N)
        {
            dato = N.dato;
            prioridad = N.prioridad;
            destinoRouter = N.destinoRouter;
            destinoPuerto = N.destinoPuerto;
        }

        public override string ToString()
        {
            //return $"<PR:{prioridad}|Valor:{dato}|{destinoRouter},{destinoPuerto}>";
            return @$"╔═════════════════════╗
║ |PR:{prioridad}|Valor:{dato}|{destinoRouter}|{destinoPuerto}|  
╚═════════════════════╝";
        }

    }
}
