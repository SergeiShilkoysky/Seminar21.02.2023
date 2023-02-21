//Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28  / 4 -> 10  / 8 -> 36

Console.Clear();

Console.WriteLine("Введите число А:");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от 1 до {a} = {GetSumByNumber(a)}");

int GetSumByNumber(int limit)
{
    int result = 0;
    for (int i = 1; i <= limit; i++)
    {
        result += i; //=  result = result + i;
    }
    return result;
}
