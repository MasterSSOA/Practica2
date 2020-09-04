// Practica 2 Ejercicio 5. 
// Nota : Programa capaz de realizar retiros a partir de un monto dado.
// Monto disponible iniciar de RD$18,765.43 pesos dominicanos.
//
//
//                                            © By Anthony Reyes Duran

using System;

class Program
{
    static void Main(string[] args)
    {
        char Bucle = 'y';
        double MontoDisponible = 18765.43;
        double Retiro;
        string Line = "";

        for (int i = 0; i < 55; i++)
        {
            Line += "_";
        }

        Console.WriteLine("{0}\n\n\t\tSISTEMA BALANCE Y RETIROS\n{0}", Line);

        while (Bucle == 'y')
        {
            Console.WriteLine("\nMonto Disponible :\tRD${0:n}\n", MontoDisponible);
            Console.Write("Digite el Monto \nque Desea Retirar: \tRD$");
            try
            {
                Retiro = Convert.ToDouble(Console.ReadLine());
                if (Retiro < 0)
                {
                    Console.WriteLine("\n{0}\n\n   **ERROR : No se Aceptan Variables Negativas.**\n{0}", Line);
                    Console.ReadKey();
                    break;
                }
                else
                {
                    if (Retiro > MontoDisponible)
                    {
                        Console.WriteLine("\n{0}\n\n\t **ERROR : Insuficiencia de Fondos.**\n{0}", Line);
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        MontoDisponible -= Retiro;

                        Console.WriteLine("\nMonto Actual :\t\tRD${0:n}\n", MontoDisponible);
                        Console.Write("Realizar Otro Retiro? \n[s - si | n - no]\t");

                        Bucle = Convert.ToChar(Console.ReadLine());

                        if (Bucle == 's')
                        {
                            Bucle = 'y';
                            Console.WriteLine("\n{0}", Line);
                        }
                        else
                        {
                            Console.WriteLine("\nSaliendo del Sistema...");
                            Console.ReadKey();
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n{0}\n\n **ERROR : {1}**\n{0}", Line, e.Message.ToString());
                Console.ReadKey();
            }
        }








    }
}
