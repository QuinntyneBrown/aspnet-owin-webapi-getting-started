using System;
using Microsoft.Owin.Hosting;

namespace Chloe.SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9006/";

            WebApp.Start<Chloe.Api.Startup>(url: baseAddress);

            Console.ReadLine();
        }
    }
}
