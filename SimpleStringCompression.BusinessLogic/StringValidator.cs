using System;
namespace SimpleStringCompression.BusinessLogic
{
    public static class StringValidator
    {
        public static bool IsTooShort(string text)
        {
            return string.IsNullOrEmpty(text) || text.Length < 2;
        }

        public static bool IsTooLong(string text)
        {
            return text != null && text.Length > 30;
        }

        public static bool IsValid(string text)
        {
            if (IsTooShort(text))
                throw new ArgumentOutOfRangeException($"{nameof(text)} is tooShort");
            if (IsTooLong(text))
                throw new ArgumentOutOfRangeException($"{nameof(text)} is tooLong");
            return true;
        }
    }
}
