using Microsoft.Owin.Hosting;
using System;

namespace KatanaCustomSelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://localhost:8090"))
            {
                Console.WriteLine("Servidor Katana (vNext) online !!!");

                Console.ReadLine();

            }
        }
    }
}