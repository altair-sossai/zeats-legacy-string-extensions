using System.Linq;

namespace Zeats.Legacy.StringExtensions
{
    public static class OnlyNumbersOrWhiteSpaceExtension
    {
        public static string OnlyNumbersOrWhiteSpace(this string s)
        {
            return string.IsNullOrEmpty(s) ? s : string.Join(string.Empty, s.Where(c => c == ' ' || char.IsDigit(c)));
        }
    }
}