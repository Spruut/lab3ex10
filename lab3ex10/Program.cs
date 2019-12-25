using System;

namespace lab3ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of matrix ");
            int N = Int32.Parse(Console.ReadLine());
            Console.Clear();
            int[] array = new int[N];
            Random random = new Random();

            RandomMatrix(array, random);
            WriteMatrix(array);

            Console.WriteLine($"Max element = {MaxElement(array, out int max)}");
        }
        static void RandomMatrix(int[] array, Random random)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(-9, 9);
            }
        }
        static void WriteMatrix(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}  ");
            }
            Console.WriteLine();
        }
        static int MaxElement(int[] array, out int max)
        {
            max = Int32.MinValue;
            for (int i = 0; i < array.Length; i += 2)
            {
                if (max < array[i] && array[i] % 2 != 0)
                    max = array[i];
            }
            return max;
        }
    }
}
