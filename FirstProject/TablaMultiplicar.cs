using System;

namespace FirstProject
{
    public class TablaMultiplicar
    {
       
        public void Initialize()
        {
            int _num;
            do
            {
                Console.Write("Ingrese numero: ");
                _num = int.Parse(Console.ReadLine());
                if (_num != -1)
                {
                    Tabla(_num);
                }
                else
                {
                    Console.WriteLine("Programa finalizado");
                }
            } while (_num != -1);
        }
        

        public void Tabla(int valor)
        {
            for (var i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * valor);
            }
        }

        /*public static void Main(string[] args)
        {
            var tabla = new TablaMultiplicar();
            tabla.Initialize();
        }*/
    }
}