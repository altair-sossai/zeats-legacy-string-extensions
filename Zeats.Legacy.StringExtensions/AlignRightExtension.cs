namespace Zeats.Legacy.StringExtensions
{
    public static class AlignRightExtension
    {
        public static string AlignRight(this string source, char paddingChar = ' ')
        {
            return string.IsNullOrEmpty(source) ? source : source.Trim().PadLeft(source.Length, paddingChar);
        }
    }
}