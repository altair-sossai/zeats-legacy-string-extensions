namespace Zeats.Legacy.StringExtensions
{
    public static class PadBothExtension
    {
        public static string PadBoth(this string source, char paddingChar = ' ')
        {
            return string.IsNullOrEmpty(source) ? source : source.Trim().PadBoth(source.Length, paddingChar);
        }

        public static string PadBoth(this string source, int length, char paddingChar = ' ')
        {
            if (string.IsNullOrEmpty(source))
                return source;

            var spaces = length - source.Length;
            var padLeft = spaces / 2 + source.Length;

            return source.PadLeft(padLeft, paddingChar).PadRight(length, paddingChar);
        }
    }
}