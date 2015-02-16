using System;

namespace ConsoleApplication1
{
    internal class ExpressionBodied
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public string Old()
        {
            return string.Format("{0} is {1} years old", Name, Age);
        }  
        
        public string New => string.Format("{0} is {1} years old", Name, Age);

        public string Super => $"{Name} is {Age} years old";
    }
}