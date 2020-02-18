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
    }
}
