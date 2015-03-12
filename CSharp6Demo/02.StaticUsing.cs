namespace ConsoleApplication1
{
    using System;

    internal class StaticUsing
    {
        private void BrokenFlow()
        {
            Console.WriteLine(Math.Cos(5) * Math.Tan(20) + Math.PI);
        }
    }
}