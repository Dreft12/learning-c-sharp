using System;

namespace FirstProject
{
    public class SumaDosVectores
    {
        private int[] _vector1;
        private int[] _vector2;

        public void Cargar()
        {
            _vector1 = new int[4];
            _vector2 = new int[4];
            Console.WriteLine("Ingrese los datos del primer vector");
            for (var i = 0; i < 4; i++)
            {
                Console.Write("Ingrese elemento " + (i + 1) + ": ");
                _vector1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese los datos del segundo vector");
            for (var i = 0; i < 4; i++)
            {
                Console.Write("Ingrese elemento " + (i + 1) + ": ");
                _vector2[i] = int.Parse(Console.ReadLine());
            }
        }

        public int[] SumarElementos()
        {
            var vector3 = new int[4];
            for (var i = 0; i < 4; i++)
            {
                vector3[i] = _vector1[i] + _vector2[i];
            }

            return vector3;
        }

        public void ImprimirSuma()
        {
            Console.WriteLine("Los elementos sumados por posicion son: ");
            for (var i = 0; i < SumarElementos().Length; i++)
            {
                Console.WriteLine("Posicion " + (i + 1) + ": " + SumarElementos()[i]);
            }
        }

        /*public static void Main(string[] args)
        {
            var sumaDosVectores = new SumaDosVectores();
            sumaDosVectores.Cargar();
            Console.WriteLine("---------------------------------");
            sumaDosVectores.ImprimirSuma();
        }*/
    }
}