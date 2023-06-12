using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Person
{
    public string LastName { get; set; }
    public List<string> GivenNames { get; set; }

    public Person(string name)
    {
        var nameParts = name.Split(' ');
        LastName = nameParts[^1];
        GivenNames = nameParts.Take(nameParts.Length - 1).ToList();
    }

    public override string ToString()
    {
        return $"{string.Join(' ', GivenNames)} {LastName}";
    }
}
