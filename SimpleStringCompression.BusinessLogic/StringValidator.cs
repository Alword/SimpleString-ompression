using System;
namespace SimpleStringCompression.BusinessLogic
{
    public static class StringValidator
    {
        public const string TOO_SHORT_EXCEPTION = "Строка должна содержать минимум 2 символа";
        public const string TOO_LONG_EXCEPTION = "Длина строки не должна превышать 30 символов";

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
                throw new ArgumentOutOfRangeException(TOO_SHORT_EXCEPTION);
            if (IsTooLong(text))
                throw new ArgumentOutOfRangeException(TOO_LONG_EXCEPTION);
            return true;
        }
    }
}
