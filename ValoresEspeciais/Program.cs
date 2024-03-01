using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"Integer: Min = {int.MinValue}, Max = {int.MaxValue}");
            Console.WriteLine($"Unsigned Integer: Min = {uint.MinValue}, Max = {uint.MaxValue}");
            Console.WriteLine($"Long: Min = {long.MinValue}, Max = {long.MaxValue}");
            Console.WriteLine($"Unsigned Long: Min = {ulong.MinValue}, Max = {ulong.MaxValue}");
            Console.WriteLine($"Short: Min = {short.MinValue}, Max = {short.MaxValue}");
            Console.WriteLine($"Unsigned Short: Min = {ushort.MinValue}, Max = {ushort.MaxValue}");
            Console.WriteLine($"Float: Min = {float.MinValue}, Max = {float.MaxValue}");
            Console.WriteLine($"Double: Min = {double.MinValue}, Max = {double.MaxValue}");
            Console.WriteLine($"Decimal: Min = {decimal.MinValue}, Max = {decimal.MaxValue}");
        }
    }
}
