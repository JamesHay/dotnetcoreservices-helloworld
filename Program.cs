using System;
using Microsoft.Extensions.Configuration;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddCommandLine(args)
                .Build();

            Console.WriteLine("Hello World!");
        }
    }
}
