using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_parser
{
    public class Config
    {
        public string FilePath { get; }
        public int Number { get; }
        public Config(string path, int number) { FilePath = path; Number = number;}
        public override string ToString() => "Path: " + FilePath + "\n" + "Number: " + Number;
    }
}
