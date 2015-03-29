using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    internal static class IndexedMembers
    {
        public static void C_Sharp_Two_Dictionary()
        {
            var config = new Dictionary<int, string>();
            config.Add(1, "hi");
            config.Add(2, "how are you");
            config.Add(3, "i am fine");
            config.Add(4, "good bye");
            foreach (var item in config)
            {
                Console.WriteLine("{0} = {1}", item.Key, item.Value);
            }
        }

        public static void C_Sharp_Three_Dictionary()
        {
            var config = new Dictionary<int, string>
            {
                { 1, "hi" },
                { 2, "how are you" },
                { 3, "i am fine" },
                { 4, "good bye" },
            };

            foreach (var item in config)
            {
                Console.WriteLine("{0} = {1}", item.Key, item.Value);
            }
        }        
    }
}