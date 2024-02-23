using System;

namespace VariousTypes
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int intA = 1;
            int intB = 0x10;
            uint uintC = 0x10U;
            int intD = 0b10110110;
            int intE = 0b1011_0110;
            int intF = 0xFF_2B_4A;
            Console.WriteLine(intA);
            Console.WriteLine(intB);
            Console.WriteLine(uintC);
            Console.WriteLine(intD);
            Console.WriteLine(intE);
            Console.WriteLine(intF);
        }
    }
}
