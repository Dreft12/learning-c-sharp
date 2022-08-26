using System;

namespace FirstProject
{
    public class Cuadrado
    {
        private int _lado;
        
        public void Initialize()
        {
            Console.Write("Ingrese lado del cuadrado: ");
            _lado = int.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine("Datos del Cuadrado: ");
            Console.Write("Lado: ");
            Console.WriteLine(_lado);
        }

        public void Perimetro()
        {
            Console.Write("El perimetro es: ");
            Console.WriteLine(_lado * 4);
        }

        public void Superficie()
        {
            Console.Write("La superficie es: ");
            Console.WriteLine(_lado * _lado);
        }

        /*public static void Main(string[] args)
        {
            var cuadrado1 = new Cuadrado();
            cuadrado1.Initialize();
            Console.WriteLine("-------------------");
            cuadrado1.Imprimir();
            Console.WriteLine("-------------------");
            cuadrado1.Perimetro();
            Console.WriteLine("-------------------");
            cuadrado1.Superficie();
        }*/
    }
}