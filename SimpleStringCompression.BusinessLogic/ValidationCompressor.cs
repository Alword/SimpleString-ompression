using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStringCompression.BusinessLogic
{
    public class ValidationCompressor : SimpleTextCompressor
    {
        private readonly Func<string, bool> validationFunction;
        private Func<string, bool> ValidationFunction => validationFunction;
        public ValidationCompressor(Func<string, bool> validationFunction)
        {
            this.validationFunction = validationFunction;
        }

        public override string Compress(string text)
        {
            if (ValidationFunction.Invoke(text))
            {
                return base.Compress(text);
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
