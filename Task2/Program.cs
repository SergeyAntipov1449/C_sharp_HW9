// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int AkkerFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AkkerFunction(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return AkkerFunction(m - 1, AkkerFunction(m, n - 1));
    }
    return AkkerFunction(m, n);
}

////////////////////////////////////////////////////////////

int firstNum = ReadInt("Введите первое целое положительное число: ");
int secondNum = ReadInt("Введите второе целое положительное число: ");
if (firstNum < 0 || secondNum < 0) { System.Console.WriteLine("Оба числа должны быть положительными"); return; }
System.Console.WriteLine();
System.Console.WriteLine($"Akkerman Function ({firstNum},{secondNum}) = {AkkerFunction(firstNum, secondNum)}");