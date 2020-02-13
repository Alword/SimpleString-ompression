using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStringCompression.BusinessLogic.Abstractions
{
    public interface IStringCompressor
    {
        string Compress(string text);
    }
}
