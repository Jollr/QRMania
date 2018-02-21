using System;
using Microsoft.Owin.Hosting;

namespace Server
{
    public class Program
    {
        static void Main(string[] args)
        {
            var baseAddress = "http://127.0.0.1:9000/";
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.ReadKey();
            }
        }
    }
}