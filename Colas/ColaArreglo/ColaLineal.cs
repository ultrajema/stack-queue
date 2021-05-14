using System;
using System.Collections.Generic;
using System.Text;

namespace Colas.ColaArreglo
{
    class ColaLineal
    {
        protected int fin;
        private static int MAXTAMQ = 39;
        protected int frente;

        protected Object[] listaCola;

        public ColaLineal() {
            frente = 0;
            fin = -1;
            listaCola = new object[MAXTAMQ];
        }

        public bool colaVacia() 
        {
            return frente > fin;
        }

        public bool colaLLena() 
        {
            return fin == MAXTAMQ - 1;
        }

        //operaciones para trabajar con datos en la cola
        public void insertar(Object elemento) 
        {
            if (!colaLLena()) 
            {
                listaCola[++fin] = elemento;
            }
            else 
            {
                throw new Exception("Overflow de la cola");
            }
        }

        //quitar elementos de la cola

        public Object quitar() 
        {
            if (!colaVacia()) 
            {
                return listaCola[frente++];
            }
            else 
            {
                throw new Exception("Cola Vacia");
            }
        }

        //limpiar toda la cola

        public void borrarCola() 
        {
            frente = 0;
            fin = -1;
        }

        //acceso a la cola
        public Object frenteCola() 
        {
            if (!colaVacia()) 
            {
                return listaCola[frente];
            }
            else 
            {
                throw new Exception("cola vacia");
            }
        }

        //

    }//fin clase
}
