namespace ConsoleApplication1
{
    internal class ExpressionBodiesAndNewStringStuff
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public string Old
        {
            get
            {
                return string.Format("{0} is {1} years old", Name, Age);
            }
        }
    }
}