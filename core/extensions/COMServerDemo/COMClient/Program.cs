using System;
using System.Runtime.InteropServices;

namespace COMClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new Activation.Server();

            var pi = server.ComputePi();
            Console.WriteLine($"\u03C0 = {pi}");
        }
    }
}
