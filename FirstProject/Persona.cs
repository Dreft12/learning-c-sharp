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
            Console.Write(_edad);
        }

        public static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.Initialize();
            Console.WriteLine("------------------------");
            p1.Imprimir();
        }
    }
}