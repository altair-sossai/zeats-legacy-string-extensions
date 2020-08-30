using System.Linq;

namespace Zeats.Legacy.StringExtensions
{
    public static class FirstCharToUpperExtension
    {
        public static string FirstCharToUpper(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return input.First().ToString().ToUpper() + input.Substring(1);
        }
    }
}