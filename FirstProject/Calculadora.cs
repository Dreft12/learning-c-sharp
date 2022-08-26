using System;

namespace FirstProject
{
    public class Calculadora
    {
        private float _num1;
        private float _num2;
        
        public void Initialize()
        {
            Console.Write("Ingrese numero 1: ");
            _num1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese numero 2: ");
            _num2 = float.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine("Numeros ingresados: ");
            Console.Write("Numero 1: ");
            Console.WriteLine(_num1);
            Console.Write("Numero 2: ");
            Console.WriteLine(_num2);
        }

        public void Suma()
        {
            Console.Write("Suma es: ");
            Console.WriteLine(_num1 + _num2);
        }
        
        public void Resta()
        {
            Console.Write("Resta es: ");
            Console.WriteLine(_num1 - _num2);
        }
        
        public void Multiplicacion()
        {
            Console.Write("Multiplicacion es: ");
            Console.WriteLine(_num1 * _num2);
        }
        
        public void Division()
        {
            Console.Write("Division es: ");
            Console.WriteLine(_num1 / _num2);
        }

        /*public static void Main(string[] args)
        {
            var calculadora = new Calculadora();
            calculadora.Initialize();
            Console.WriteLine("------------------------------");
            calculadora.Imprimir();
            Console.WriteLine("------------------------------");
            calculadora.Suma();
            Console.WriteLine("------------------------------");
            calculadora.Resta();
            Console.WriteLine("------------------------------");
            calculadora.Multiplicacion();
            Console.WriteLine("------------------------------");
            calculadora.Division();
        }*/
    }
}