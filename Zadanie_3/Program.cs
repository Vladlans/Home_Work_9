//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Clear();

uint InputNumber(string message)
{
    while (true)
    {
        Console.Write(message);
        bool result = uint.TryParse(Console.ReadLine() ?? "0", out uint number);
        if (!result)
        {
            Console.WriteLine($"Ввод некорректный! Попробуйте ещё раз.");
            Thread.Sleep(1500);
            continue;
        }
        return number;
    }
}

// функция Аккермана
uint A(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}

uint n = InputNumber("Задайте число: ");
uint m = InputNumber("Задайте число: ");
Console.WriteLine($"A(n, m) = {A(n, m)}");