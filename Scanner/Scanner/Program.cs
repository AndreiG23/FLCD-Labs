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

            Console.WriteLine(symbolTable.Find("x"));
            Console.WriteLine(symbolTable.Find("y"));
            Console.WriteLine(symbolTable.Find("xy"));
            Console.WriteLine(symbolTable.Find("yx"));
            Console.WriteLine(symbolTable.Find("w"));
        }
    }
}
