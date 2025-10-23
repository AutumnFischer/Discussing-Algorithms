namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = [-33, 43, 355, 308, -150, -184, 109, 216, 72, 45, 255, 386, 288, -2, -206, 325, 204, -2, 352, -252, 469, -88, 145, -214, 203, -102, -250, 368, 25, 398, -223, -222, 363, -81];
            int length = numbers.Length;

            //Mean
            double sum = 0;
            foreach (int num in numbers) { 
                sum += num;
            }
            double mean = Math.Round(sum / length);
            Console.WriteLine($"The mean of this dataset is: {mean}!");

            //Median
            Array.Sort(numbers);
            double median = 0;
            //if even
            if (length % 2 == 0)
            {
                int mid1 = (length / 2) - 1;
                int mid2 = length / 2;
                median = (double)(numbers[mid1] + numbers[mid2]) / 2;
            }
            //if odd
            else {
                int mid = length / 2;
                median = numbers[mid];
            }
            Console.WriteLine($"The median of this dataset is: {median}!");

            //Min
            int min = numbers[0];
            for (int i = 1; i < length; i++)
            {
                if (numbers[i] < min)
                {
                    min = num;
                }
            }
            Console.WriteLine($"The minimum value of this dataset is: {min}!");

            //Max
            int max = numbers[0];
            for (int i = 1; i < length; i++)
            {
                if (numbers[i] > max)
                {
                    max = num;
                }
            }
            Console.WriteLine($"The maximum value of this dataset is: {max}!");
        }
    }
}
