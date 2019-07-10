using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosterTools
{
    class Program
    {
        static void Main(string[] args)
        {
            string outputFile = "output.xlsx";

            Generator.Headers[] headers = { Generator.Headers.NameLast, Generator.Headers.NameFirst };

            Generator roster = new Generator(outputFile, headers);
            roster.Write();

            Console.WriteLine(roster.ToString());

            Console.ReadKey();

        }
    }
}
