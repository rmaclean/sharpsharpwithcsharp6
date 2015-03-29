namespace ConsoleApplication1
{
    using System.Linq;

    internal class StringInterpolation
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public string[] AnimalsOrderedByFavourite()
        {
            //pretend this is in a DB
            return new[] {
                "Cat",
                "Dog",
                "Goat",
                "Horse"
            };
        }

        public string Info
        {
            get
            {
                return $"{Name} is {Age} years old and their favourite animal is {AnimalsOrderedByFavourite().First()}";
            }
        }

        public string DisplayPrice
        {
            get
            {
                return $"Hamsters cost {14.22:0.00}";
            }
        }
    }
}