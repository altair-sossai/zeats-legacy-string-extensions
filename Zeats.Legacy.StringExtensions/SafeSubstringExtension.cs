namespace Zeats.Legacy.StringExtensions
{
    public static class SafeSubstringExtension
    {
        public static string SafeSubstring(this string text, int start, int length)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            return text.Length <= start ? ""
                : text.Length - start <= length ? text.Substring(start)
                : text.Substring(start, length);
        }
    }
}