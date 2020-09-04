// Practica 2 Ejercicio 6. 
// Nota : Programa capaz de calcular la amortización de un préstamo utilizando
//        el sistema amortización frances mediante los meses, interes y monto
//        principal.
//
// Extra: El programa se encarga de calcular el interes real en base a la cap-
//        tura del interes anual, dividendolo entre 12 y luego multiplicando
//        ese valor por la cantidad N de meses registrados.
//
//
//                                                    © By Anthony Reyes Duran

using System;

class Program
{
    static void Main(string[] args)
    {
        char Bucle = 'y';
        string Lines = "_";
        double Cuota;
        double CapitalPrestado;
        double InteresAnual;
        double Interes;
        double DenominadorFormula;
        int CantidadMeses;
        
        // Elaboración de diseños de la parte superior.
        for (int i = 0; i < 32; i++)
        {
            Lines += "_";
        }
        Console.WriteLine("{0}\n\n SISTEMA DE AMORTIZACIÓN FRANCÉS\n{0}", Lines);

        // Lógica del Software.
        while (Bucle == 'y')
        {
            try
            {
                Console.Write("\nMonto a Prestar    : RD$");
                CapitalPrestado = Convert.ToDouble(Console.ReadLine());
                Console.Write("Cantidad de Meses  : ");
                CantidadMeses = Convert.ToInt32(Console.ReadLine());
                Console.Write("Interés Anual      : ");
                InteresAnual = Convert.ToDouble(Console.ReadLine()) / 100;

                Interes = (InteresAnual / 12) * CantidadMeses;
                DenominadorFormula = Math.Pow((1 + Interes), -(CantidadMeses));
                Cuota = CapitalPrestado * (Interes / (1 - DenominadorFormula));

                Console.WriteLine("\n{0}\n\nCuotas Mensuales : RD${1:n}\n{0}", Lines, Cuota);
                Console.ReadKey();
                Bucle = 'n';
            }
            catch (Exception e)
            {
                Console.WriteLine("\n{0}\n\nError : {1} ", Lines, e.Message.ToString());
                Console.ReadKey();
                Bucle = 'y';
            }
        }
    }
}
 