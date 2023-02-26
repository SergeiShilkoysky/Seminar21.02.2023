// Задача 28: Напишите программу, которая принимает на вход число M и N и выдаёт произведение чисел от M до N.
//2,4 -> 24 / 1,5 -> 120

/*
// 1 способ

int MultNum(int a, int b)
{
    int result;
    int i;
    result = 1;
    for (i = a; i <= b; i++)
    {
        result = i * result;
    }

    return result;
}
int n;
int m;
Console.Clear();
Console.Write("введите число n ");
n = int.Parse(Console.ReadLine());
Console.Write("введите число m ");
m = int.Parse(Console.ReadLine());
Console.WriteLine($"произведение чисел от {Math.Min(n, m)} до {Math.Max(n, m)} = {MultNum(Math.Min(n, m), Math.Max(n, m))}");
*/


// 2 способ
int GetMultNum(int value, int mult)
{
    // если что то 0 то все ноль
    if (mult == 0 || value == 0)
    {
        return 0;
    }
    // Как обработать ошибку диапазона????!
    if (mult < value)
    {
        Console.Write("Ошибка диапазона! ");
        return -1;
    }
    // вычисляет произведение в диапазоне от М до N
    int spamValue = 1;
    for (int i = value; i <= mult; i++)
    {
        spamValue *= i;
    }
    return spamValue;
}

Console.WriteLine($"Произведение чисел равно {GetMultNum(2, 4)}");
Console.WriteLine($"Произведение чисел равно {GetMultNum(1, 5)}");


// эксперементы
Console.WriteLine($"");
Console.WriteLine($"Произведение чисел равно {GetMultNum(-1, 5)}");
Console.WriteLine($"Произведение чисел равно {GetMultNum(-5, -1)}");
Console.WriteLine($"Произведение чисел равно {GetMultNum(-1, -5)}");


