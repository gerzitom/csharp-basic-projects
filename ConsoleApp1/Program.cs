internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello to calculator app.");
        bool end = false;
        int[] ints = { 1, 2, 3, 4, 0, 9, 7, 1, 4, 5, 0 };
        while (!end)
        {
            Console.WriteLine("Choose your operation:");
            Console.WriteLine("1: min max");
            Console.WriteLine("2: positive, negative and zero count");
            Console.WriteLine("3: odd, even and zeros count");
            Console.WriteLine("4: positive numbers mean");
            Console.WriteLine("end: End application");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    int max = findMax(ints);
                    int min = findMin(ints);
                    Console.WriteLine("Max from numbers is: " + max + " and min from numbers " + min + ".");
                    break;
                case "2":
                    int positive = findPositiveCount(ints);
                    int negative = findNegativeCount(ints);
                    int zeros = findZerosCount(ints);
                    Console.WriteLine("Positive count of numbers is: " + positive + " and negative count of numbers is:" + negative + " zeros count is " + zeros + ".");
                    break;
                case "3":
                    int odd = findOddCount(ints);
                    int even = findEvenCount(ints);
                    int zerosCount = findZerosCount(ints);
                    Console.WriteLine("Odd count of numbers is: " + odd + " and even count of numbers is: " + even + " zeros count is " + zerosCount + ".");
                    break;
                case "4":
                    int positiveNumbersMean = findPositiveMean(ints);
                    Console.WriteLine("Positive numbers mean is: " + positiveNumbersMean + ".");
                    break;
                case "end":
                    Console.WriteLine("Thank you for using my calculator.");
                    break;
            }
        }



        int findMax(int[] numbers)
        {
            if (numbers.Length == 0) throw new Exception("You must add numbers");
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        int findMin(int[] numbers)
        {
            if (numbers.Length == 0) throw new Exception("You must add numbers");
            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        int findZerosCount(int[] numbers)
        {
            if (numbers.Length == 0) throw new Exception("You must add numbers");
            int zeros = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    zeros++;
                }
            }
            return zeros;
        }

        int findPositiveCount(int[] numbers)
        {
            if (numbers.Length == 0) throw new Exception("You must add numbers");
            int zeros = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    zeros++;
                }
            }
            return zeros;
        }

        int findNegativeCount(int[] numbers)
        {
            if (numbers.Length == 0) throw new Exception("You must add numbers");
            int zeros = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    zeros++;
                }
            }
            return zeros;
        }

        int findEvenCount(int[] numbers)
        {
            if (numbers.Length == 0) throw new Exception("You must add numbers");
            int zeros = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    zeros++;
                }
            }
            return zeros;
        }

        int findOddCount(int[] numbers)
        {
            if (numbers.Length == 0) throw new Exception("You must add numbers");
            int zeros = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    zeros++;
                }
            }
            return zeros;
        }

        int findPositiveMean(int[] numbers)
        {           
            int meanNumbersSum = 0;
            int meanNumbersCount = 0;
            List<int> positiveNumbers = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    meanNumbersSum += numbers[i];
                    meanNumbersCount++;
                }
            }
            return meanNumbersSum / meanNumbersCount;
        }
    }
}