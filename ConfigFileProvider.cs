using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_parser
{
    public class ConfigFileProvider : IStringProvider
    {
        private readonly string _filePath;
        public ConfigFileProvider(string filePath)
        {
            if (String.IsNullOrWhiteSpace(filePath))
                throw new ArgumentNullException(nameof(filePath));
            _filePath = filePath;
        }
        public string GetString()
        {
            using (var stringReader = File.OpenText(_filePath))
            {
                if(stringReader != null)
                    return stringReader.ReadToEnd();
                throw new NullReferenceException(nameof(stringReader));
            }
        }
    }
}
