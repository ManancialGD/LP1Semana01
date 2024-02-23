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
            double xx = 1.23456;
            int ii = 19;

            string message = "Hello, World!";
            string s = "Um tab\t e um copyright \u03A9";
            string s2 = "Uma "+ "string " + "concatenada";
            string s3 = "Outros tipos autom. convertidos " + x + " e " + y; // x is int , y is float
            string s4 = $"{x} mais {y}  igual a {x + y}";


            // Write strings on console
            Console.WriteLine(message);
            Console.WriteLine(s);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);

            // Write xx
            Console.WriteLine($"Número real com duas casas decimais: {xx:F2}");
            Console.WriteLine($"Percentagem com uma casa decimal: {xx:P1}");

            // Write ii
            Console.WriteLine($"Hexadecimal: 0x{ii:X}");
            Console.WriteLine($"Moeda: {ii:C}");
        }
    }
}
