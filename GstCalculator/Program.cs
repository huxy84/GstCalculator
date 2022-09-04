using System;

namespace GstCalculator
{
    internal class Program
    {
        private static string _input = string.Empty;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter an amount in which to calculate GST");
                _input = Console.ReadLine();

                var isExitCode = !string.IsNullOrEmpty(_input)
                    && _input.ToLower() == "exit";

                if(isExitCode)
                    return;

                var calculatedGst = GstCalculator.CalculateGst(_input);
                Console.WriteLine($"GST is: {calculatedGst}");
            }
        }
    }
}
