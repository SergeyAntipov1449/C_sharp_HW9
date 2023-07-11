// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int Recursion(int M, int N)
{
    if (M == N)
    {
        return N;
    }
    return M + Recursion(M + 1, N);
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


////////////////////////////////////////////////////////////

int firstNum = ReadInt("Введите начальное число: ");
int lastNum = ReadInt("Введите конечное число: ");
if (firstNum > lastNum) { System.Console.WriteLine("Начальное число не должно быть больше конечного"); return; }
System.Console.WriteLine(Recursion(firstNum, lastNum));