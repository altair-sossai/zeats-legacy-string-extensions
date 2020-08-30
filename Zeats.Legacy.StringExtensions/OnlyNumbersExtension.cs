using System.Linq;

namespace Zeats.Legacy.StringExtensions
{
    public static class OnlyNumbersExtension
    {
        public static string OnlyNumbers(this string s)
        {
            return string.IsNullOrEmpty(s) ? s : string.Join(string.Empty, s.Where(char.IsDigit));
        }
    }
}