using System;
using Hello.Library;

namespace Hello.CoreConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var name = (args.Length > 0) ? args[0] : string.Empty;

            Console.WriteLine(HelloHelper.SayHello(name));
        }
    }
}
