using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_parser
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = "config.txt";
            var parser = new ConfigParser(new ConfigFileProvider(filePath));
            Console.WriteLine(parser.Parse());
        }
    }
}
