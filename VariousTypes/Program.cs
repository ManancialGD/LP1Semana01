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

            Console.WriteLine("These are int types:");
            Console.WriteLine(intA);
            Console.WriteLine(intB);
            Console.WriteLine(uintC);
            Console.WriteLine(intD);
            Console.WriteLine(intE);

            Console.WriteLine("These are chat Types");
            Console.WriteLine(copyrightSymbol);
            Console.WriteLine(newLine);
        }
    }
}
