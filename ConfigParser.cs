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
            var str = GetParameterValue(CreateLinesArr(), "path");
            var str2 = GetParameterValue(CreateLinesArr(), "number");
            int num;

            if (int.TryParse(str2, out num))
                return new Config(str, num);
            throw new InvalidCastException(nameof(str2));
        }
        private string[] CreateLinesArr()
        {
            var arr = _str.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            if (arr.Length < 2)
                throw new NullReferenceException(nameof(arr));
            else
                return _str.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }
        private string GetParameterValue(string[] lines, string paramName)
        {
            if (lines.FirstOrDefault(t => t.ToLower().StartsWith(paramName)).ToString().Split('=')[1].Trim() != null)
                return lines.FirstOrDefault(t => t.ToLower().StartsWith(paramName)).ToString().Split('=')[1].Trim();
            throw new NullReferenceException(nameof(lines));
        }
    }
}
