// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();

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

int SumElements(int min, int max)
{
    if (min == max) return min;

    return min + SumElements(min+1, max);
}

int m = InputNumber("Задайте число: ");
int n = InputNumber("Задайте число: ");
Console.WriteLine($"Сумма элементов от {m} до {n} равна {SumElements(m, n)}");