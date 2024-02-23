using System;

namespace ManyStrings
{
    /// <summary>
    /// This is a program that will show different types of strings!
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // var

            int x = 5;
            float y = 2.2f;

            string message = "Hello, World!";
            string s = "Um tab\t e um copyright \u03A9";
            string s2 = "Uma "+ "string " + "concatenada";
            string s3 = "Outros tipos autom. convertidos " + x + " e " + y; // x is int , y is float
            string s4 = $"{x} mais {y} é igual a {x + y}";


            // Write on console
            Console.WriteLine(message);
            Console.WriteLine(s);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
        }
    }
}
