using System;

namespace VariousTypes
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Int variables
            int intA = 1;
            int intB = 0x10;
            uint uintC = 0x10U;
            int intD = 0b10110110;
            int intE = 0xFF_2B_4A;

            // char variables
             char copyrightSymbol = '\u00A9';
             char newLine = '\u000A';

            // reais
            float numeroReal1 = 3.14f;
            double numeroReal2 = 42.5678;

            // Write int variables on console
            Console.WriteLine("These are int types:");
            Console.WriteLine(intA);
            Console.WriteLine(intB);
            Console.WriteLine(uintC);
            Console.WriteLine(intD);
            Console.WriteLine(intE);

            // Write char variables on console
            Console.WriteLine("These are chat Types");
            Console.WriteLine(copyrightSymbol);
            Console.WriteLine(newLine);

            // Write real variables on console
            Console.WriteLine("These are real types");
            Console.WriteLine(numeroReal1);
            Console.WriteLine(numeroReal2);
        }
    }
}
