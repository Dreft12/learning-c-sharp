using System;

namespace FirstProject
{
    public class Empleado
    {
        private string _nombre;
        private float _sueldo;
        
        public void Initialize()
        {
            Console.Write("Ingrese nombre del empleado: ");
            _nombre = Console.ReadLine();
            Console.Write("Ingrese sueldo del empleado: ");
            _sueldo = float.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine("Datos del Empleado: ");
            Console.Write("Nombre: ");
            Console.WriteLine(_nombre);
            Console.Write("Sueldo: ");
            Console.WriteLine(_sueldo);
        }

        public void PagarImpuestos()
        {
            if (_sueldo > 3000)
            {
                Console.WriteLine("Debe pagar impuestos");
            }
        }

        public static void Main(string[] args)
        {
            var empleado1 = new Empleado();
            empleado1.Initialize();
            Console.WriteLine("-------------------");
            empleado1.Imprimir();
            Console.WriteLine("-------------------");
            empleado1.PagarImpuestos();
        }
    }
}