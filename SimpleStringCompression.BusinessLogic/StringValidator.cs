using SimpleStringCompression.BusinessLogic.Abstractions;

namespace SimpleStringCompression.BusinessLogic
{
    public static class StringValidator
    {
        public static bool IsTooShort(string text)
        {
            return string.IsNullOrEmpty(text);
        }

        public static bool IsTooLong(string text)
        {
            return text != null && text.Length > 30;
        }
    }
}
