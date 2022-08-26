using System;

namespace FirstProject
{
    public class PromedioNotaGeneral
    {
        private float[] _notas1;
        private float[] _notas2;

        public void Cargar()
        {
            _notas1 = new float[5];
            _notas2 = new float[5];
            Console.WriteLine("Ingrese las notas del curso A: ");
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese nota alumno " + (i + 1) + ": ");
                _notas1[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese las notas del curso B: ");
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese nota alumno " + (i + 1) + ": ");
                _notas2[i] = float.Parse(Console.ReadLine());
            }
        }

        public void PromedioGeneral()
        {
            float promedioA = 0, promedioB = 0, suma = 0;
            for (var i = 0; i < 5; i++)
            {
                suma = suma + _notas1[i];
            }

            promedioA = suma / 5;
            suma = 0;
            for (var i = 0; i < 5; i++)
            {
                suma = suma + _notas2[i];
            }

            promedioB = promedioB + suma;

            if (promedioA > promedioB)
            {
                Console.WriteLine("El curso A tiene mejor promedio.");
            }
            else
            {
                if (promedioB > promedioA)
                {
                    Console.WriteLine("El curso B tiene mejor promedio");
                }
                else
                {
                    Console.WriteLine("Los cursos tienen el mismo promedio");
                }
            }
        }

        public static void Main(string[] args)
        {
            var promedioNotaGeneral = new PromedioNotaGeneral();
            promedioNotaGeneral.Cargar();
            Console.WriteLine("---------------------------");
            promedioNotaGeneral.PromedioGeneral();
        }
    }
}