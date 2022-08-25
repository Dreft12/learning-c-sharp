
using System;

namespace FirstProject
{
    public class Triangulo
    {
        private int _lado1, _lado2, _lado3;
        
        public void Initialize()
        {
            Console.Write("Ingrese primer lado: ");
            _lado1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese segundo lado: ");
            _lado2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese tercer lado: ");
            _lado3 = int.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine("Datos del Triangulo: ");
            Console.Write("Lado 1: ");
            Console.WriteLine(_lado1);
            Console.Write("Lado 2: ");
            Console.WriteLine(_lado2);
            Console.Write("Lado 3: ");
            Console.WriteLine(_lado3);
        }

        public void EsEquilatero()
        {
            if (_lado1 == _lado2 && _lado2 == _lado3)
            {
                Console.WriteLine("Es un Triangulo equilatero");
            }
            else
            {
                Console.WriteLine("No es un triangulo equilatero");
            }
        }

        public void LadoMayor()
        {
            if (_lado1 > _lado2 && _lado1 > _lado3)
            {
                Console.Write("Lado 1 es el mayor");
            }
            else
            {
                if (_lado2 > _lado3)
                {
                    Console.Write("Lado 2 es el mayor");
                }
                else
                {
                    Console.Write("Lado 3 es el mayor");
                }
            }
        }

       /* public static void Main(string[] args)
        {
            var triangulo1 = new Triangulo();
            triangulo1.Initialize();
            Console.WriteLine("--------------------");
            triangulo1.Imprimir();
            Console.WriteLine("--------------------");
            triangulo1.EsEquilatero();
            Console.WriteLine("--------------------");
            triangulo1.LadoMayor();
        }*/
    }
}