using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    internal class StaticUsing
    {
        private static void CSIX()
        {
            var config = new Dictionary<string, string>
            {
                ["FIRST"] = "hi",
                ["SECOND"] = "how are you",
                ["THIRD"] = "i am fine",
                ["FORTH"] = "good bye",
            };

            foreach (var item in config)
            {
                Console.WriteLine("{0} = {1}", item.Key, item.Value);
            }
        }
    }
}