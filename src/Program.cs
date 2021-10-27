using System;
using System.Threading.Tasks;

namespace src
{
    class Program
    {
        static async Task Main(string[] args)
        {
            while(true){
                Console.WriteLine($"Hello World! @ {DateTime.Now}");
                await Task.Delay(5000);
            }
        }
    }
}
