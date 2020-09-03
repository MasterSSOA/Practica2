// Practica 2 Ejercicio 2. 
// Nota : Programa capaz de evaluar edad del usuario y clasificarlo.
//      TABLA DE CLASIFICACIÓN
// ******************************
// *	Niños (0 – 10)		*
// *	Adolescentes (11 – 17)	*
// *	Adulto joven (18 – 38)	*
// *	Mediana Edad (39 - 59)	*
// *	Adulto mayor (60 – 99)	*
// *				*
// ******************************

using System;

class Program
{
    static void Main(string[] args)
    {
        string Validation = "";
        
        while (!int.TryParse(Validation, out int Age))
        {
            Console.WriteLine("Digite la edad:");
            Validation = Console.ReadLine();

            if (int.TryParse(Validation, out Age))
            {
                if (Age <= 10)
                {
                    Console.WriteLine("{0} año(s) es la edad de un niño.", Age);
                    Console.ReadKey();
                }
                else if (11 <= Age && Age <= 17)
                {
                    Console.WriteLine("{0} año(s) es la edad de un adolescente.", Age);
                    Console.ReadKey();
                }
                else if (18 <= Age && Age <= 38)
                {
                    Console.WriteLine("{0} año(s) es la edad de un adulto joven.", Age);
                    Console.ReadKey();
                }
                else if (39 <= Age && Age <= 59)
                {
                    Console.WriteLine("{0} año(s) pertenece a la mediana Edad.", Age);
                    Console.ReadKey();
                }
                else if (60 <= Age && Age <= 99)
                {
                    Console.WriteLine("{0} año(s) es la edad de un adulto mayor.", Age);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Esta edad no esta contemplada dentro de nuestros registros.");
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
