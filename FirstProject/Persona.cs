using System;

namespace FirstProject
{
    public class Persona
    {
        private string _nombre;
        private int _edad;

        public void Initialize()
        {
            Console.Write("Ingrese nombre: ");
            _nombre = Console.ReadLine();
            Console.Write("Ingrese la edad: ");
            _edad = int.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine("Datos de la persona: ");
            Console.Write("Nombre: ");
            Console.WriteLine(_nombre);
            Console.Write("Edad: ");
            Console.WriteLine(_edad);
        }

        public void EsMayorDeEdad()
        {
            if (_edad >= 18)
            {
                Console.Write("Es mayor de edad la persona");
            }
            else
            {
                Console.Write("No es mayor de edad");
            }
        }

        public static void Main(string[] args)
        {
            var p1 = new Persona();
            p1.Initialize();
            Console.WriteLine("------------------------");
            p1.Imprimir();
            Console.WriteLine("------------------------");
            p1.EsMayorDeEdad();
        }
    }
}