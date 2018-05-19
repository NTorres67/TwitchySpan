using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchySpan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var data = new[] { 1, 2, 3, 4, 5, 6 };
            Span<int> span = data.AsSpan().Slice(2, 2);

            var result = Sum(data);
            Console.WriteLine(result);
        }

        static int Sum(Span<int> numbers) // Span is like an array like a window into an array
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result;
        }
    }
}
