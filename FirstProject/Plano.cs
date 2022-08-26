using System;

namespace FirstProject
{
    public class Plano
    {
        private int _x;
        private int _y;
        
        public void Initialize()
        {
            Console.Write("Ingrese X: ");
            _x = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Y: ");
            _y = int.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine("Datos del Plano: ");
            Console.Write("X: ");
            Console.WriteLine(_x);
            Console.Write("Y: ");
            Console.WriteLine(_y);
        }

        public void Cuadrante()
        {
            if (_x > 0 && _y > 0)
            {
                Console.WriteLine("Cuadrante 1");
            }
            else
            {
                if (_x < 0 && _y > 0)
                {
                    Console.WriteLine("Cuadrante 2");
                }
                else
                {
                    if (_x < 0 && _y < 0)
                    {
                        Console.WriteLine("Cuadrante 3");
                    }
                    else
                    {
                        if (_x > 0 && _y < 0)
                        {
                            Console.WriteLine("Cuadrante 4");
                        }
                        else
                        {
                            Console.WriteLine("Se encuentra en el 0,0");
                        }
                    }
                }
            }
        }

        /*public static void Main(string[] args)
        {
            var plano1 = new Plano();
            plano1.Initialize();
            Console.WriteLine("----------------------");
            plano1.Imprimir();
            Console.WriteLine("----------------------");
            plano1.Cuadrante();
        }*/
    }
}