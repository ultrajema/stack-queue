using Colas.Clases.Pila_Lista;
using Colas.ColaArreglo;
using System;
using System.Collections;

namespace Colas
{
    class Program
    {
        private static bool valido(String numero)
        {
            bool sw = true;
            int i = 0;
            while (sw && (i < numero.Length))
            {
                char c;
                c = numero[i++];
                sw = (c >= '0' && c <= '9');
            }
            return sw;
        }




        static void Main(string[] args)
        {

            // programa capicua

            bool capicua;
            string numero;
            Stack mistack = new Stack();
            Queue que = new Queue();
           

           

            try
            {
                capicua = false;
                while (!capicua)
                {
                    do
                    {
                        Console.WriteLine("\nTeclea un numero: ");
                        numero = Console.ReadLine();
                    } while (!valido(numero));

                    //pone en la cola y en la pila cada digito
                    for (int i = 0; i < numero.Length; i++)
                    {
                        Char c;
                        c = numero[i];
                       // circula_Cola.insertar(c);
                        que.Enqueue(c);
                       // pila.insertar(c);
                        mistack.Push(c);
                    }

                    //se retira de la cola y pila para comparar
                    do
                    {
                        Char d;
                        d = (Char)que.Dequeue();
                        capicua = d.Equals(mistack.Pop()); //compara la igualdad
                    } while (capicua &&  que.Count != 0); 

                    if (capicua)
                    {
                        Console.WriteLine($"El Numero {numero} es capicua");
                    }
                    else
                    {
                        Console.WriteLine($" El numero {numero} no es capicua");
                        Console.WriteLine("intente otro");
                    }

                    // vaciar estructuras
                    que.Clear();
                   
                    mistack.Clear();
                  


                }
            }
            catch (Exception errores)
            {
                Console.WriteLine($"Error en {errores.Message}");
            }


            /*Queue qt = new Queue();
            qt.Enqueue("hola");
            qt.Enqueue("esta");
            qt.Enqueue("es");
            qt.Enqueue("una");
            qt.Enqueue("prueba");

            Console.WriteLine($"la Cola tiene{qt.Count} elementos");

            Console.WriteLine($"Desencolando{qt.Dequeue()}");

            Console.WriteLine($"ahora la cola tiene {qt.Count} elementos");
            Console.WriteLine($"Desencolando{qt.Dequeue()}");
            Console.WriteLine($"Desencolando{qt.Dequeue()}");
            Console.WriteLine($"Desencolando{qt.Dequeue()}");
            Console.WriteLine($"ahora la cola tiene {qt.Count} elementos");*/
        }
    }
}

