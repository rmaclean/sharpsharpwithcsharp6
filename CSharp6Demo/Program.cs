namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var demo = new ExpressionBodied
            {
                Age = 43,
                Name = "Bio"
            };

            System.Console.WriteLine(demo.Super);
            System.Console.WriteLine($"{demo}");
        }
    }
}