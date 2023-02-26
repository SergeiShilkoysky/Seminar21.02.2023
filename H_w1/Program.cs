// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)   /  2, 4 -> 16



Console.Write("input A: ");
int value = Convert.ToInt32(Console.ReadLine());
Console.Write("input B: ");
int exponent = Convert.ToInt32(Console.ReadLine());

int GetPow(int value, int exponent)
{
    int pow = 1;
    for (int i = 0; i < exponent; i++)
    {
        pow *= value;
    }
    return pow;
}

bool ValidExponent(int exponent)
{
    if (exponent < 0)
    {
        Console.WriteLine("Показатель степени не может быть < 0!");
        return false;
    }
    return true;
}

if (ValidExponent(exponent))
{
  Console.WriteLine($"число {value} ^ {exponent} --> {GetPow(value, exponent)}");  
}
