// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using static System.Console;
using System.IO;
using System.Net.Sockets;

namespace Education
{
    class Program
    {
        public static void Main(string[] args)
        {
            var c = new PrimeFactors();
           var s = c.GetPrimeFactors(1000);
        }
        
    }
}