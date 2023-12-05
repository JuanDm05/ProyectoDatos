using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDatos
{
    using System;

    namespace ProyectoDatos
    {
        public class Pilav2
        {
            private int[] items;
            private int top; // Índice del elemento superior de la pila
            private int capacity; // Capacidad máxima de la pila

            public Pilav2(int capacidad)
            {
                capacity = capacidad;
                items = new int[capacity];
                top = -1; // Inicialmente la pila está vacía
            }

            public Pilav2()
            {
            }

            public bool EstaVacia()
            {
                return top == -1;
            }

            public bool EstaLlena()
            {
                return top == capacity - 1;
            }

            public void Apilar(int elemento)
            {
                if (EstaLlena())
                {
                    throw new InvalidOperationException("La pila está llena");
                }
                top++;
                items[top] = elemento;
            }

            public int Desapilar()
            {
                if (EstaVacia())
                {
                    throw new InvalidOperationException("La pila está vacía");
                }
                int elementoDesapilado = items[top];
                top--;
                return elementoDesapilado;
            }

            public int VerTope()
            {
                if (EstaVacia())
                {
                    throw new InvalidOperationException("La pila está vacía");
                }
                return items[top];
            }

            public void MostrarElementos()
            {
                if (EstaVacia())
                {
                    Console.WriteLine("La pila está vacía");
                    return;
                }
                Console.WriteLine("Elementos de la pila:");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(items[i]);
                }
            }

            public void VaciarPila()
            {
                top = -1;
                Console.WriteLine("La pila ha sido vaciada");
            }
        }

      
        
    }
}