using System;

class Program5
{
    static void Main()
    {
        // Пример использования функций
        int sumResult = Sum(12, 7);
        Console.WriteLine($"Сумма: {sumResult}");

        double circleArea = CalculateCircleArea(3.5);
        Console.WriteLine($"Площадь окружности: {circleArea}");

        string inputString = "Hello, World!";
        int stringLength = GetStringLenght(inputString);
        Console.WriteLine($"Длина строки: {stringLength}");

        int[] numbersArray = { 4, 8, 2, 10, 5 };
        int maxNumber = GetMaxValue(numbersArray);
        Console.WriteLine($"Наибольшее значение в массиве: {maxNumber}");

        int factorialResult = CalculateFactorial(5);
        Console.WriteLine($"Факториал: {factorialResult}");

        string palindromeString = "level";
        bool isPalindrome = IsPalindrome(palindromeString);
        Console.WriteLine($"Является ли строка палиндромом: {isPalindrome}");

        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };
        int[] mergedArray = MergeArrays(array1, array2);
        Console.WriteLine($"Объединенный массив: [{string.Join(", ", mergedArray)}]");

        int primeNumber = 11;
        bool isPrime = IsPrime(primeNumber);
        Console.WriteLine($"{primeNumber} - простое число: {isPrime}");

        string reversedString = ReverseString("Hello, World!");
        Console.WriteLine($"Обратная строка: {reversedString}");

        int[,] twoDArray = { { 1, 2, 3 }, { 4, 5, 6 } };
        int sumOfElements = SumOfTwoDArray(twoDArray);
        Console.WriteLine($"Сумма элементов двумерного массива: {sumOfElements}");
    }

    static int Sum(int a, int b)
    {
        return a + b;
    }

    static double CalculateCircleArea(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    static int GetStringLenght(string input)
    {
        return input.Length;
    }

    static int GetMaxValue(int[] array)
    {
        return array.Max();
    }

    static int CalculateFactorial(int number)
    {
        if (number == 0 || number == 1)
            return 1;

        return number * CalculateFactorial(number - 1);
    }

    static bool IsPalindrome(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);

        return input.Equals(reversedString, StringComparison.OrdinalIgnoreCase);
    }

    static int[] MergeArrays(int[] array1, int[] array2)
    {
        return array1.Concat(array2).ToArray();
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static int SumOfTwoDArray(int[,] array)
    {
        int sum = 0;
        foreach (int element in array)
        {
            sum += element;
        }
        return sum;
    }
}
