using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace ProjectManager.Mapping.Customs
{
    public class NullStringConverter : ITypeConverter<string, string>
    {
        public string Convert(string source)
        {
            return source ?? string.Empty;
        }

        public string Convert(string source, string destination, ResolutionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
