using System;

namespace Scanner
{
    class Program
    {
        static void Main(string[] args)
        {
            ST symbolTable = new ST(10);

            Console.WriteLine(symbolTable.Add("x"));
            Console.WriteLine(symbolTable.Add("y"));
            Console.WriteLine(symbolTable.Add("xy"));
            Console.WriteLine(symbolTable.Add("yx"));
            Console.WriteLine(symbolTable.Add("yx"));
            Console.WriteLine(symbolTable.Add("xyz"));

            Console.WriteLine(symbolTable.Search("x"));
            Console.WriteLine(symbolTable.Search("y"));
            Console.WriteLine(symbolTable.Search("xy"));
            Console.WriteLine(symbolTable.Search("yx"));
            Console.WriteLine(symbolTable.Search("w"));
        }
    }
}
