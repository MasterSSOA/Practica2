// Practica 2 Ejercicio 1. 
// Nota : Programa capaz de evaluar un numero y decir si es par o no.

using System;

class Program
{
    static void Main(string[] args)
    {
        string Validation = "";

        while (!int.TryParse(Validation, out int Value))
        {
            Console.WriteLine("Digite un Número: ");
            Validation = Console.ReadLine();

            if (int.TryParse(Validation, out Value))
            {
                Value = Convert.ToInt32(Validation);
                if (Value % 2 == 0)
                {
                    Console.WriteLine("El número {0} es par.", Value);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El número {0} es impar.", Value);
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Digite un caracter de tipo númerico!\n");

            }
        }
    }
}
