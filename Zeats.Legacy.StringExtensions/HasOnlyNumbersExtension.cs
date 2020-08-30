using System.Linq;

namespace Zeats.Legacy.StringExtensions
{
    public static class HasOnlyNumbersExtension
    {
        public static bool HasOnlyNumbers(this string s)
        {
            return !string.IsNullOrEmpty(s) && s.All(char.IsDigit);
        }
    }
}