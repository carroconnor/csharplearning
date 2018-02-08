using System;

namespace StringType
{
    class Program
    {
        static void Main(string[] args)
        {
            //escape sequence
            string Name = "One\nTwo\nThree";
            Console.WriteLine(Name);

            //Verbatim Literal
            string File = @"C:\Program\DotNet\Training\CSharp";
            Console.WriteLine(File);
            Console.ReadLine();

        }
    }
}
