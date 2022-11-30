//Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1.
int InputNumber(string message)
{
    while (true)
    {
        Console.Write(message);
        bool result = int.TryParse(Console.ReadLine() ?? "0", out int number);
        if (!result)
        {
            Console.WriteLine($"Ввод некорректный! Попробуйте ещё раз.");
            Thread.Sleep(1500);
            continue;
        }
        return number;
    }
}

void PrintNumbers(int min, int max)
{
    if (max % 2 != 0) max = max - 1;
    if (max == min)
    {
        Console.WriteLine("{0,4}", max);
        return;
    }
    else
    {
        Console.WriteLine("{0,4}", min);
    }
    PrintNumbers(min + 2, max);
}

int n = 2;
int m = InputNumber("Задайте число: ");
PrintNumbers(n, m);
