using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class NameSorter
{
    public List<Person> People { get; set; }

    public NameSorter(string filePath)
    {
        People = File.ReadAllLines(filePath)
            .Select(line => new Person(line))
            .ToList();
    }

    public void Sort()
    {
        People = People.OrderBy(p => p.LastName)
            .ThenBy(p => string.Join(' ', p.GivenNames))
            .ToList();
    }

    public void WriteToFile(string filePath)
    {
        File.WriteAllLines(filePath, People.Select(p => p.ToString()));
    }

    public void PrintToConsole()
    {
        foreach (var person in People)
        {
            Console.WriteLine(person);
        }
    }
}
