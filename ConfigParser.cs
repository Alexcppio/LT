using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_parser
{
    public class ConfigParser : IParser<Config>
    {
        private readonly string _str;
        public ConfigParser(IStringProvider stringProvider)
        {
            if (String.IsNullOrWhiteSpace(stringProvider.GetString()))
                throw new ArgumentNullException(nameof(_str));
            _str = stringProvider.GetString();
        }
        public Config Parse()
        {
            var str = getParameterValue(createLinesArr(), "path");
            var str2 = getParameterValue(createLinesArr(), "number");
            int num;

            if (int.TryParse(str2, out num))
                return new Config(str, num);
            throw new InvalidCastException();
        }

        private string[] createLinesArr()
        {
            var arr = _str.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            if (arr.Length < 2)
                throw new NullReferenceException();
            else
                return _str.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }
        private string getParameterValue(string[] lines, string paramName)
        {
            if (lines.FirstOrDefault(t => t.ToLower().StartsWith(paramName)).ToString().Split('=')[1].Trim() != null)
                return lines.FirstOrDefault(t => t.ToLower().StartsWith(paramName)).ToString().Split('=')[1].Trim();
            throw new NullReferenceException();
        }
    }
}
