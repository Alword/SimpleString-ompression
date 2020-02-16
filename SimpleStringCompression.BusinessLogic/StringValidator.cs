using SimpleStringCompression.BusinessLogic.Abstractions;

namespace SimpleStringCompression.BusinessLogic
{
    public class StringValidator : IStringValidator
    {
        public bool IsTooShort(string text)
        {
            return string.IsNullOrEmpty(text);
        }

        public bool IsTooLong(string text)
        {
            return text != null && text.Length > 30;
        }
    }
}
