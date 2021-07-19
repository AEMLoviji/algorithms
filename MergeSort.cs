using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 6, 1, 8, 19, 56, 23, 87, 41, 49, 53 };

            SortMerge(input);

            for (int i = 0; i < input.Length; i++)
                Console.WriteLine(input[i]);
        }

        static public void SortMerge(int[] numbers)
        {
            if (numbers.Length <= 1)
            {
                return;
            }

            var arrayMiddle = numbers.Length / 2;
            var leftArray = numbers[..arrayMiddle];
            var rightArray = numbers[arrayMiddle..];

            SortMerge(leftArray);
            SortMerge(rightArray);

            var i = 0; // index of the left array
            var j = 0; // index of the right array
            var k = 0; // index of merged array

            // while both arrays have content
            while (i < leftArray.Length && j < rightArray.Length)
            {
                numbers[k++] = leftArray[i] < rightArray[j]
                    ? leftArray[i++]
                    : rightArray[j++];
            }

            // if the left array still has values, add them
            while (i < leftArray.Length)
            {
                numbers[k] = leftArray[i];
                k++; i++;
            }

            // if the right array still has values, add them
            while (j < rightArray.Length)
            {
                numbers[k] = rightArray[j];
                k++; j++;
            }
        }
    }
}
