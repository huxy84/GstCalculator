using System;

namespace GstCalculator
{
    public static class GstCalculator
    {
        public static double CalculateGst(string input)
        {
            const double gst = 0.1;

            if (!input.IsNumeric())
            {
                throw new ArgumentException($"Input must be a numberic value - '{input}'");
            }

            var amount = double.Parse(input);

            if (amount <= 0)
                throw new Exception($"Amount must be greater than zero");
            
            var gstAmount =  amount * gst;

            var formattedGst = double.Parse(gstAmount.ToString("0.####"));

            return formattedGst;
        }

    }
}
