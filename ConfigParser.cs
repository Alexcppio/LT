using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class ConfigParser : IParser<Config>
    {
        private readonly string _str;
        public ConfigParser(string s) => _str = s;
        public Config Parse() => new Config(GetParameterValue(CreateLinesArr(), "path"), Int32.Parse(GetParameterValue(CreateLinesArr(), "number")));
        private string[] CreateLinesArr() => _str.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        private string GetParameterValue(string[] lines, string paramName) => lines.FirstOrDefault(t => t.ToUpper().StartsWith(paramName)).ToString().Split('=')[1].Trim();
    }
}
