using System;

namespace FirstProject
{
    public class SumaElementosVector
    {
        private int[] _vector;

        public void Cargar()
        {
            Console.WriteLine("Ingrese cantidad del numeros: ");
            var cantidad = int.Parse(Console.ReadLine());
            _vector = new int[cantidad];

            for (int i = 0; i < _vector.Length; i++)
            {
                Console.WriteLine("Ingrese numero " + (i + 1) + ": ");
                _vector[i] = int.Parse(Console.ReadLine());
            }
        }

        public int SumaElementos()
        {
            var suma = 0;
            for (int i = 0; i < _vector.Length; i++)
            {
                suma = suma + _vector[i];
            }

            return suma;
        }

        /*public static void Main(string[] args)
        {
            var sumaElementosVector = new SumaElementosVector();
            sumaElementosVector.Cargar();
            Console.WriteLine("---------------------------");
            Console.WriteLine("La suma de todos los elementos es de: "+sumaElementosVector.SumaElementos());
        }*/
    }
}