using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class ExceptionFilters
    {
        public static void OldPain()
        {            
            try
            {
                throw new MyException { Id = 200 };
            }
            catch (MyException ex)
            {
                if (ex.Id == 200)
                {
                    // do something
                }
                else
                {
                    throw;
                }
            }
        }

        public static void Yay()
        {
            try
            {
                throw new MyException { Id = 200 };
            }
            catch (MyException ex)
                if (ex.Id == 200)
            {
                // do something
            }
        }
    }


    [Serializable]
    public class MyException : Exception
    {
        public int Id { get; set; }
        public MyException() { }
        public MyException(string message) : base(message) { }
        public MyException(string message, Exception inner) : base(message, inner) { }
        protected MyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}