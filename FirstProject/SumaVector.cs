using System;

namespace FirstProject
{
    public class SumaVector
    {
        private int[] _elementos;

        public void Cargar()
        {
            _elementos = new int[8];
            for (var i = 0; i < 8; i++)
            {
                Console.WriteLine("Ingrese un valor en la posicion " + (i + 1) + ": ");
                _elementos[i] = int.Parse(Console.ReadLine());
            }
        }

        public int SumaElementos()
        {
            var suma = 0;
            for (var i = 0; i < 8; i++)
            {
                suma = suma + _elementos[i];
            }

            return suma;
        }

        public int MayoresA36()
        {
            var suma = 0;
            for (var i = 0; i < 8; i++)
            {
                if (_elementos[i] >= 36)
                {
                    suma = suma + _elementos[i];
                }
            }

            return suma;
        }

        public int CantidadMayores50()
        {
            var cantidad = 0;
            for (var i = 0; i < 8; i++)
            {
                if (_elementos[i] > 50)
                {
                    cantidad++;
                }
            }

            return cantidad;
        }

        /*public static void Main(string[] args)
        {
            var sumaVector = new SumaVector();
            sumaVector.Cargar();
            Console.WriteLine("-------------------------");
            Console.WriteLine("La suma de los elementos es de: " + sumaVector.SumaElementos());
            Console.WriteLine("-------------------------");
            Console.WriteLine("La suma de elementos mayores a 36 es: " + sumaVector.MayoresA36());
            Console.WriteLine("-------------------------");
            Console.WriteLine("La cantidad de elementos mayores a 50: " + sumaVector.CantidadMayores50());
        }*/
    }
}