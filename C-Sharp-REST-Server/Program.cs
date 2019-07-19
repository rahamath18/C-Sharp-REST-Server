using System;
using Nancy.Hosting.Self;


namespace C_Sharp_REST
{
    class Program
    {
        static void Main(string[] args)
        {
          using (var host = new NancyHost(new Uri("http://localhost:8080")))
            {
                host.Start();

                Console.WriteLine("NancyFX Stand alone test application.");
                Console.WriteLine("Press enter to exit the application");
                Console.ReadLine();
            }
        }
    }
}
