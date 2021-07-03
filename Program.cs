using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new ConfigParser(File.ReadAllText("config.txt"));
            parser.Parse();
        }
    }

}
