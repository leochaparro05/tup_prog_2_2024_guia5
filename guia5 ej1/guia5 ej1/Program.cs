using System;

namespace Guia5_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prom_menor = double.MaxValue;
            double mayor_apostador = 0;
            string nom_mayor_apostador = "";
            string nom_prom_menor = "";
            int verif1 = 1;
            

            
            while (verif1 != 0)
            {
                int cont_apuestas = 0;
                double acum_monto = 0;
                double promedio = 0;

                Console.WriteLine("Ingrese el NOMBRE del apostador ");
                string nom_apostador = Console.ReadLine();
                int verif2 = 1;
                while (verif2 != 0)
                {
                    Console.WriteLine("Ingrese el MONTO de la apuesta");
                  double  monto_apostado = Convert.ToDouble(Console.ReadLine());
                    cont_apuestas++;
                    acum_monto += monto_apostado;

                    Console.WriteLine("ingrese 1 para ingresar otra apuesta o 0 para salir");
                   verif2 = Convert.ToInt16(Console.ReadLine());

                }

                if (cont_apuestas == 0)
                {
                    promedio = 0;
                }
                else
                {
                    promedio = acum_monto / cont_apuestas;
                }


                if (cont_apuestas > mayor_apostador)
                {
                    nom_mayor_apostador = nom_apostador;
                    mayor_apostador = cont_apuestas;
                }

                if (promedio < prom_menor)
                {
                    nom_prom_menor = nom_apostador;
                    prom_menor = promedio;
                }

                Console.WriteLine("Ingrese 1 para ingresar otro apostador o '0' para salir: ");
               verif1 = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("\nMAYOR APOSTADOR");
            Console.WriteLine($"NOMBRE: {nom_mayor_apostador}");
            Console.WriteLine($"APUESTAS: {mayor_apostador}");
            Console.WriteLine("\nAPOSTADOR CON MENOR PROMEDIO");
            Console.WriteLine($"NOMBRE: {nom_prom_menor}");
            Console.WriteLine($"PROMEDIO: {prom_menor}");
            Console.ReadKey();
        }
    }
}
