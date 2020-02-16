using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStringCompression.BusinessLogic.Abstractions
{
    public interface IStringValidator
    {
        bool IsTooShort(string text);

        bool IsTooLong(string text);
    }
}
