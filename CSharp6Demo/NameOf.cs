using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class NameOf
    {
        public static void OldPain()
        {
            Console.WriteLine("Track");
        }

        public static void NewCool()
        {
            Console.WriteLine(nameof(Track));
        }
    }
}
