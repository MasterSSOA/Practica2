// Practica 2 Ejercicio 3. 
// Nota : Programa capaz de evaluar si el primer número almacenado es mayor que el segundo.

using System;

class Program
{
    static void Main(string[] args)
    {
        int Value1 = 23;
        int Value2 = 94;

        if (Value1 > Value2)
        {
            Console.WriteLine("Primer número:  {0}\nSegundo número: {1}\n\n" +
                              "El primer número ES MAYOR que el segundo.\n", Value1, Value2);
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Primer número:  {0}\nSegundo número: {1}\n\n" +
                              "El primer número NO ES MAYOR que el segundo.\n", Value1, Value2);
            Console.ReadKey();
        }
    }
}
