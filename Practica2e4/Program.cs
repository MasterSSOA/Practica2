// Practica 2 Ejercicio 4. 
// Nota : Programa capaz de selecccionar una opción interactiva y realizar el tipo 
// operación seleccionada mediante dos números.
//
//
//                                                        © By Anthony Reyes Duran

using System;

class Program
{
    static void Main(string[] args)
    {
        char Bucle = 'y';

        while (Bucle == 'y')
        {
            Console.WriteLine("BIENVENIDO AL MENÚ\nSeleccione una opción\n" +
                              "[S - Sumar]\n[R - Restar]\n" +
                              "\nOTROS SERVICIOS...\n[C - Cerrar Programa]\n");

            if (!char.TryParse(Console.ReadLine(), out char Option))
            {
                Console.WriteLine("\nDato invalido. Intente de nuevo!\n");
            }
            else
            {
                double Value1;
                double Value2;
                double Total;
                string Validation1;
                string Validation2;

                if (Option == 'c')
                {
                    Bucle = 'n';
                }
                else if (Option == 's')
                {
                    Console.WriteLine("\nPrimer Número:  ");
                    Validation1 = Console.ReadLine();
                    
                    Console.WriteLine("Segundo Número: ");
                    Validation2 = Console.ReadLine();

                    if (!double.TryParse(Validation1, out Value1) || !double.TryParse(Validation2, out Value2))
                    {
                        Console.WriteLine("\nSolo se trabajan con números.\n");
                        Console.ReadKey();
                    }
                    else
                    {
                        Total = Value1 + Value2;
                        Console.WriteLine("\nTotal: {0}\n", Total);
                        Console.ReadKey();
                    }
                }
                else if (Option == 'r')
                {
                    Console.WriteLine("\nPrimer Número:  ");
                    Validation1 = Console.ReadLine();

                    Console.WriteLine("Segundo Número: ");
                    Validation2 = Console.ReadLine();

                    if (!double.TryParse(Validation1, out Value1) || !double.TryParse(Validation2, out Value2))
                    {
                        Console.WriteLine("\nSolo se trabajan con números.\n");
                        Console.ReadKey();
                    }
                    else
                    {
                        Total = Value1 - Value2;
                        Console.WriteLine("\nTotal: {0}\n", Total);
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("\nDato invalido. Intente de nuevo!\n");
                }
            }
        } 
    }
}

