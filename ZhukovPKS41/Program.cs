using System;

public class MyProgram
{
    static void Main()
    {
        // Условия
        CompareNumbers();
        Minimum5Maximum10();
        Bank();
        Calculate();

        // Циклы
        BankLoop();
        MultiplicationTable();
        Multiplicate();

        // Массивы
        NotEven();
        FindString();
        CalculateArray();

        Console.ReadLine(); // Чтобы консоль не закрывалась сразу
    }

    /* ============
       Условия
       ============ */
    public static void CompareNumbers()
    {
        Console.WriteLine("Введите первое число:");
        if (double.TryParse(Console.ReadLine(), out double number1))
        {
            Console.WriteLine("Введите второе число:");
            if (double.TryParse(Console.ReadLine(), out double number2))
            {
                if (number1 == number2)
                {
                    Console.WriteLine("Введенные числа равны.");
                }
                else if (number1 > number2)
                {
                    Console.WriteLine("Первое число больше второго.");
                }
                else
                {
                    Console.WriteLine("Первое число меньше второго.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода второго числа.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода первого числа.");
        }
    }

    public static void Minimum5Maximum10()
    {
        Console.WriteLine("Введите число:");
        if (double.TryParse(Console.ReadLine(), out double number))
        {
            if (number >= 5 && number <= 10)
            {
                Console.WriteLine("Число больше 5 и меньше 10.");
            }
            else
            {
                Console.WriteLine("Неизвестное число.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода числа.");
        }
    }

    public static void Bank()
    {
        Console.WriteLine("Введите сумму вклада:");

        double depositAmount = Convert.ToDouble(Console.ReadLine());

        double interestRate;

        if (depositAmount < 100)
        {
            interestRate = 0.05;
        }
        else if (depositAmount >= 100 && depositAmount <= 200)
        {
            interestRate = 0.07;
        }
        else
        {
            interestRate = 0.10;
        }

        double interest = depositAmount * interestRate;
        double totalAmount = depositAmount + interest;

        Console.WriteLine($"Сумма вклада с начисленными процентами: {totalAmount:C}");
    }

    public static void Calculate()
    {
        Console.WriteLine("Введите номер операции:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");

        if (int.TryParse(Console.ReadLine(), out int operationNumber))
        {
            string operationName;

            switch (operationNumber)
            {
                case 1:
                    operationName = "Сложение";
                    break;
                case 2:
                    operationName = "Вычитание";
                    break;
                case 3:
                    operationName = "Умножение";
                    break;
                default:
                    operationName = "Операция неопределена";
                    break;
            }

            Console.WriteLine($"Выбранная операция: {operationName}");
        }
        else
        {
            Console.WriteLine("Ошибка ввода номера операции.");
        }
    }

    /* ============
       Циклы
       ============ */
    public static void BankLoop()
    {
        Console.WriteLine("Введите сумму вклада:");

        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Введите количество месяцев:");
        if (int.TryParse(Console.ReadLine(), out int numberOfMonths) && numberOfMonths > 0)
        {
            decimal interestRate = 0.07M; // 7% процентная ставка

            for (int i = 1; i <= numberOfMonths; i++)
            {
                depositAmount += depositAmount * interestRate;
            }

            Console.WriteLine($"Сумма вклада после {numberOfMonths} месяцев с начисленными процентами: {depositAmount:C}");
        }
        else
        {
            Console.WriteLine("Ошибка ввода количества месяцев.");
        }
    }

    public static void MultiplicationTable()
    {
        Console.WriteLine("Таблица умножения:");

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i} * {j} = {i * j}\t");
            }
            Console.WriteLine(); // Переход на новую строку для следующего множителя
        }
    }

    public static void Multiplicate()
    {
        while (true)
        {
            Console.WriteLine("Введите два числа (в диапазоне от 0 до 10):");

            double number1, number2;

            Console.Write("Первое число: ");
            if (!double.TryParse(Console.ReadLine(), out number1) || number1 < 0 || number1 > 10)
            {
                Console.WriteLine("Ошибка! Введенное число не в допустимом диапазоне.");
                continue;
            }

            Console.Write("Второе число: ");
            if (!double.TryParse(Console.ReadLine(), out number2) || number2 < 0 || number2 > 10)
            {
                Console.WriteLine("Ошибка! Введенное число не в допустимом диапазоне.");
                continue;
            }

            double result = number1 * number2;
            Console.WriteLine($"Результат умножения: {result}");

            break;
        }
    }

    /* ============
       Массивы
       ============ */
    public static void NotEven()
    {
        int[] numbers = { 2, 7, 10, 15, 8, 3, 6, 1, 5, 9 };

        Console.WriteLine("Нечетные числа из массива:");
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.Write(number + " ");
            }
        }
    }

    public static void FindString()
    {
        string[] words = { "apple", "banana", "orange", "grape", "kiwi" };

        Console.WriteLine("Введите строку для поиска:");
        string userInput = Console.ReadLine();

        bool found = false;
        foreach (string word in words)
        {
            if (word.Equals(userInput, StringComparison.OrdinalIgnoreCase))
            {
                found = true;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine("Строка найдена!");
        }
        else
        {
            Console.WriteLine("Строка не найдена!");
        }
    }

    public static void CalculateArray()
    {
        int[] array = { 10, 5, 20, 8, 15 };

        int sum = 0;
        foreach (int number in array)
        {
            sum += number;
        }

        double average = (double)sum / array.Length;

        Console.WriteLine($"Сумма элементов массива: {sum}");
        Console.WriteLine($"Среднее арифметическое: {average}");
    }
}
