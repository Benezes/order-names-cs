using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace NameSorterProject.Tests;

public class UnitTest1
{
    public class NameSorterTests
    {
        [Fact]
        public void Sort_ShouldSortNamesByLastNameAndGivenNames()
        {

            var sorter = new NameSorter("sorted-names-list.txt");

            sorter.Sort();

            var expectedOrder = new List<string> { "Marin Alvarez",
                "Adonis Julius Archer",
                "Beau Tristan Bentley",
                "Hunter Uriah Mathew Clarke",
                "Leo Gardner",
                "Erling Haaland",
                "Neymar Junior",
                "Vaughn Lewis",
                "London Lindsey",
                "Mikayla Lopez",
                "Gabriel Menezes de Oliveira",
                "Janet Parsons",
                "Frankie Conner Ritter",
                "Shelby Nathan Yoder"
             };
            Assert.Equal(expectedOrder, sorter.People.Select(p => p.ToString()).ToList());
        }
    }
}