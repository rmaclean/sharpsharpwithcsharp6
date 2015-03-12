using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class AsyncExceptions
    {
        public static async Task Logger(string message)
        {
            var fileStream = new FileStream("log.txt", FileMode.OpenOrCreate, FileAccess.Write);
            fileStream.Position = fileStream.Length;
            using (var writer = new StreamWriter(fileStream))
            {
                await writer.WriteLineAsync(message);
            }
        }

        public static async Task OldPain()
        {
            var client = new HttpClient();
            var success = true;
            try
            {
                var result = await client.GetStringAsync("http://www.sadev.co.za");
            }
            catch (Exception)
            {
                success = false;
            }

            if (!success)
            {
                await Logger("OMG");
            }
        }
    }
}