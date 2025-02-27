namespace PeopleList
{
    public class PeopleList
    {
        public static readonly List<People> peoples = new List<People>
        {
            new People()
            {
                Id = 1,
                Name = "Joonas",
                Age = 33,
                GenderId = Guid.Parse("9df54680-4f76-4c26-a55a-92cf012fa71b")
            },
            new People()
            {
                Id = 2,
                Name = "Moona",
                Age = 18,
                GenderId = Guid.Parse("fe7f4110-d1b9-4ebc-8219-b48c852be3e6")
            },
            new People()
            {
                Id = 3,
                Name = "Ron",
                Age = 21,
                GenderId = Guid.Parse("9df54680-4f76-4c26-a55a-92cf012fa71b")
            },
            new People()
            {
                Id = 4,
                Name = "Mary",
                Age = 20,
                GenderId = Guid.Parse("fe7f4110-d1b9-4ebc-8219-b48c852be3e6")
            },
            new People()
            {
                Id = 5,
                Name = "Mari",
                Age = 17,
                GenderId = Guid.Parse("fe7f4110-d1b9-4ebc-8219-b48c852be3e6")
            },
            new People()
            {
                Id = 6,
                Name = "Mari",
                Age = 19,
                GenderId = Guid.Parse("fe7f4110-d1b9-4ebc-8219-b48c852be3e6")
            },
        };
    }
}
