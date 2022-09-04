using System.Linq;

namespace GstCalculator
{
    public static class StringExtensions
    {
        public static bool IsNumeric(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            const char decimalPoint = '.';
            const int allowedDecimals = 1;

            int decimalCount = input
                .Count(c => c == decimalPoint);

            if (decimalCount > allowedDecimals)
                return false;

            var charsMinusDots = input
                .Where(w => w != decimalPoint);

            return charsMinusDots.All(a => char.IsNumber(a));
        }
    }
}
