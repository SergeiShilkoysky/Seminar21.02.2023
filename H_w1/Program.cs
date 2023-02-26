// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)   /  2, 4 -> 16

Console.WriteLine("input A: ");
double numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input B: ");
double numB = Convert.ToInt32(Console.ReadLine());

int GetPow(int value)
{
    int b = numB;
    for (int i = 0; i <= b; i++)
        double pow = Math.Pow(numA, numB);
}
Console.WriteLine($"число {numA} ^ {numB} --> {GetPow(pow)}");


/* Напишите (функцию) цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа ");
int b = Convert.ToInt32(Console.ReadLine());
int count = 1;
int result =a;
 while (count < b)
{
    result = result * a;
    count++;
}

Console.Write($"Если число {a} возвести в степень {b} получим {result}");
*/




int GetPowValue(int value, int pow)
{
    int spamValue = value;
    for (int i = 1; i < pow; i++)
    {
        value *= spamValue;
    }
    return value;
}

int value = 3;
int powValue = 5;
Console.WriteLine($"Если возвести число {value} в степень {powValue} = {GetPowValue(value, powValue)}");

value = 2;
powValue = 4;
Console.WriteLine($"Если возвести число {value} в степень {powValue} = {GetPowValue(value, powValue)}");

