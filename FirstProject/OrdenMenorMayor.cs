using System;

namespace FirstProject
{
    public class OrdenMenorMayor
    {
        private int[] _numeros;

        public void Cargar()
        {
            _numeros = new int[10];
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero " + (i + 1) + ": ");
                _numeros[i] = int.Parse(Console.ReadLine());
            }
        }

        public void EstaOrdenadoMenorMayor()
        {
            var orden = 1;
            for (int i = 0; i < 9; i++)
            {
                if (_numeros[i + 1] < _numeros[i])
                {
                    orden = 0;
                }
            }

            if (orden == 1)
            {
                Console.WriteLine("Está ordenada");
            }
            else
            {
                Console.WriteLine("No está ordenada");
            }
        }

        /*public static void Main(string[] args)
        {
            var ordenMenorMayor = new OrdenMenorMayor();
            ordenMenorMayor.Cargar();
            Console.WriteLine("---------------------------");
            ordenMenorMayor.EstaOrdenadoMenorMayor();
        }*/
    }
}