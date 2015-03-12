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
                return string.Format("{0} is {1} years old and their favourite animal is {2}", Name, Age, AnimalsOrderedByFavourite().First());
            }
        }

        public string DisplayPrice
        {
            get
            {
                return string.Format("Hamsters cost {0:0.00}", 14.22);
            }
        }
    }
}