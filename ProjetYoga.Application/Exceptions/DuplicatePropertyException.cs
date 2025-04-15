using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Application.Exceptions
{
    public class DuplicatePropertyException(string propertyName): Exception($"La propriété {propertyName} doit être unique")
    {
    }
}
