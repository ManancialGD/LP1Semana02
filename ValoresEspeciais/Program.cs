﻿using System;

namespace SpecialValues
{
    class Program
    {
        static void Main()
        {
            // Write all min and max values of different types
            Console.WriteLine($"Integer: Min = {int.MinValue}, Max = {int.MaxValue}");
            Console.WriteLine($"Unsigned Integer: Min = {uint.MinValue}, Max = {uint.MaxValue}");
            Console.WriteLine($"Long: Min = {long.MinValue}, Max = {long.MaxValue}");
            Console.WriteLine($"Unsigned Long: Min = {ulong.MinValue}, Max = {ulong.MaxValue}");
            Console.WriteLine($"Short: Min = {short.MinValue}, Max = {short.MaxValue}");
            Console.WriteLine($"Unsigned Short: Min = {ushort.MinValue}, Max = {ushort.MaxValue}");
            Console.WriteLine($"Float: Min = {float.MinValue}, Max = {float.MaxValue}");
            Console.WriteLine($"Double: Min = {double.MinValue}, Max = {double.MaxValue}");
            Console.WriteLine($"Decimal: Min = {decimal.MinValue}, Max = {decimal.MaxValue}");

            // Values for positive infinity, negative infinity, and NaN for float and double
            double positiveInfinityDouble = double.PositiveInfinity;
            float positiveInfinityFloat = float.PositiveInfinity;

            double negativeInfinityDouble = double.NegativeInfinity;
            float negativeInfinityFloat = float.NegativeInfinity;

            double nanDouble = double.NaN;
            float nanFloat = float.NaN;

            Console.WriteLine($"Positive Infinity (double): {positiveInfinityDouble}");
            Console.WriteLine($"Positive Infinity (float): {positiveInfinityFloat}");

            Console.WriteLine($"Negative Infinity (double): {negativeInfinityDouble}");
            Console.WriteLine($"Negative Infinity (float): {negativeInfinityFloat}");

            Console.WriteLine($"NaN (double): {nanDouble}");
            Console.WriteLine($"NaN (float): {nanFloat}");

            // Example of NaN
            double result1 = positiveInfinityDouble / positiveInfinityDouble;
            float result2 = nanFloat;

            Console.WriteLine($"Result of positive infinity / positive infinity (double): {result1}"); // Results in NaN
            Console.WriteLine($"Result of NaN (float): {result2}"); // Direct NaN assignment

            // Test and display the result of overflow in uints
            uint maxValue = uint.MaxValue;

            try
            {
                // Try to cause an overflow
                uint overflowResult = checked(maxValue + 1);
                Console.WriteLine($"Overflow result: {overflowResult}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Overflow Exception: {ex.Message}");
            }

            // Test and display the result of two types of overflow in floats
            float maxValueFloat = float.MaxValue;

            // Positive overflow
            float positiveOverflow = maxValueFloat * 2;
            Console.WriteLine($"Positive Overflow result: {positiveOverflow}");

            // Negative overflow
            float negativeOverflow = -maxValueFloat * 2;
            Console.WriteLine($"Negative Overflow result: {negativeOverflow}");

            // Test and display the result of underflow in floats
            float minValueFloat = float.MinValue;

            // Underflow
            float underflowResult = minValueFloat / 2;
            Console.WriteLine($"Underflow result: {underflowResult}");
        }
    }
}
