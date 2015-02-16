using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    internal static class IndexedMembers
    {
        public static void GO()
        {
            CTWO();
            CTHREE();
            CSIX();
            CSIX_TWO();
        }

        private static void CSIX()
        {
            var config = new Dictionary<int, string>
            {
                [1] = "hi",
                [2] = "how are you",
                [3] = "i am fine",
                [4] = "good bye",
            };

            foreach (var item in config)
            {
                Console.WriteLine("{0} = {1}", item.Key, item.Value);
            }
        }

        private static void CSIX_TWO()
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

        private static void CTHREE()
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

        private static void CTWO()
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
    }
}