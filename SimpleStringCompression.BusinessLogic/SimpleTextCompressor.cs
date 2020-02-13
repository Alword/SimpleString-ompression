using SimpleStringCompression.BusinessLogic.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStringCompression.BusinessLogic
{
    public class SimpleTextCompressor : IStringCompressor
    {
        public string Compress(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            if (text.Length < 2)
                return text;

            StringBuilder stringBuilder = new StringBuilder();

            char currentSimbol = text[0];
            int count = 1;
            for (int i = 1; i < text.Length; i++)
            {
                if (currentSimbol.Equals(text[i]))
                {
                    count++;
                }
                else
                {
                    HandleSimbol(count,currentSimbol, stringBuilder);
                    count = 1;
                    currentSimbol = text[i];
                }
            }
            HandleSimbol(count, currentSimbol, stringBuilder);
            return stringBuilder.ToString();
        }

        private void HandleSimbol(int count, char currentSimbol, StringBuilder stringBuilder)
        {
            if (count > 1)
            {
                stringBuilder.Append($"({count}){currentSimbol}");
            }
            else
            {
                stringBuilder.Append($"{currentSimbol}");
            }
        }
    }
}
