using System;

namespace Algorithms
{
    public class Program
    {
        public static void Main()
        {
            var input = new int[] { 6, 1, 8, 19, 56, 23, 87, 41, 49, 53 };

            for (var i = 0; i < input.Length - 1; i++)
            {
                for (var j = 0; j < input.Length - 1 - i; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        var temp = input[j + 1];
                        input[j + 1] = input[j];
                        input[j] = temp;
                    }
                }
            }

            for (var k = 0; k < input.Length; k++)
            {
                Console.Write(input[k] + ", ");
            }
        }
    }
}
