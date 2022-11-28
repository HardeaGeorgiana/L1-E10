using System;

namespace L1_E10
{
    /* E.10 Scrieti un program care sa va afisa suma 
            cifrelor ununi numar intreg citit de la tastatura
            numarul are doua cifre
    */
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Introduceti un numar");
            x = int.Parse(Console.ReadLine());

            int suma = 0;
            suma = suma + (x % 10);
            x = x / 10;
            suma = suma + x;

            Console.WriteLine("Suma celor doua cifre din numarul ales este: " + suma);

        }
    }
}
