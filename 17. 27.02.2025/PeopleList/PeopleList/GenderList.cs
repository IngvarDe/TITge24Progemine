namespace PeopleList
{
    public class GenderList
    {
        public static readonly List<Gender> genderList = new List<Gender>
        {
            new Gender()
            {
                Id = Guid.Parse("9df54680-4f76-4c26-a55a-92cf012fa71b"),
                GenderName = "male"
            },
            new Gender()
            {
                Id = Guid.Parse("fe7f4110-d1b9-4ebc-8219-b48c852be3e6"),
                GenderName = "female"
            }
        };
    }
}
