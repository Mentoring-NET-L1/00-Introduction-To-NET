using System;

namespace Hello.Library
{
    public class HelloHelper
    {
        public static string SayHello(string name)
        {
            return $"{DateTime.Now} Hello, {name}!";
        }
    }
}
