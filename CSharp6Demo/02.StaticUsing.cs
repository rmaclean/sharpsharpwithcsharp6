namespace ConsoleApplication1
{
    using System;
    using static System.Math;

    internal class StaticUsing
    {
        private void BrokenFlow()
        {
            Console.WriteLine(Cos(5) * Tan(20) + PI);
        }
    }
}