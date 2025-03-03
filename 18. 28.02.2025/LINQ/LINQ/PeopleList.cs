using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class PeopleList
    {
        public static readonly List<People> people = new List<People>
        {
            new People()
            {
                Id = 1,
                Name = "Joonas",
                Age = 33,
                GenderId = Guid.Parse("438ab9c9-b7a5-4fa7-be53-8bac6f7dd14e")
            },
            new People()
            {
                Id = 2,
                Name = "Moona",
                Age = 21,
                GenderId = Guid.Parse("c991bde5-dade-4b34-8acc-39381c95a1a7")
            },
            new People()
            {
                Id = 3,
                Name = "Ron",
                Age = 18,
                GenderId = Guid.Parse("438ab9c9-b7a5-4fa7-be53-8bac6f7dd14e")
            },
            new People()
            {
                Id = 4,
                Name = "Jane",
                Age = 20,
                GenderId = Guid.Parse("c991bde5-dade-4b34-8acc-39381c95a1a7")
            },
            new People()
            {
                Id = 5,
                Name = "Mari",
                Age = 17,
                GenderId = Guid.Parse("c991bde5-dade-4b34-8acc-39381c95a1a7")
            },
            new People()
            {
                Id = 6,
                Name = "Mari",
                Age = 19,
                GenderId = Guid.Parse("c991bde5-dade-4b34-8acc-39381c95a1a7")
            },
        };
    }
}
