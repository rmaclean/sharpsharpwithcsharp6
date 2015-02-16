using System.Collections.Generic;
using static System.Console;

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
                WriteLine("{0} = {1}", item.Key, item.Value);
            }
        }
    }
}