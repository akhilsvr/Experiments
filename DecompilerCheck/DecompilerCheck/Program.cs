using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomLibrary;

namespace DecompilerCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomStringSeq = "abcdefghijklmnopqrstuvwxyz".GenerateRandStringSeq(10).Take(10);
            foreach(var str in randomStringSeq)
                Console.WriteLine(str);

            string readLine = Console.ReadLine();

            Console.WriteLine("Check");
        }
    }
}
