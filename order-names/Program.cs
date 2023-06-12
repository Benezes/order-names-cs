using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Please provide a file path as an argument.");
            return;
        }

        var sorter = new NameSorter(args[0]);
        sorter.Sort();
        sorter.WriteToFile("./sorted-names-list.txt");
        sorter.PrintToConsole();
    }
}
