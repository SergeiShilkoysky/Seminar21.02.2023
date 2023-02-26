// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
//  [1,0,1,1,0,1,0,0]



void WriteBinRandValue(int[] arr)
{
    int arrLenght = arr.Length;
    for (int i = 0; i < arrLenght; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}

void PrintArr(int[] arr)
{
    Console.Write($"[");
    int count = 0;
    int arrLenght = arr.Length;
    foreach (int num in arr)
    {
        count++;
        Console.Write($"{num}");
        if (count == arrLenght)
        {
            Console.Write($"]");
        }
        else
        {
            Console.Write($", ");
        }
    }

    Console.WriteLine($"");
}

const int arrLenght = 8;
int[] arrBinNumRand = new int[arrLenght];

WriteBinRandValue(arrBinNumRand);
PrintArr(arrBinNumRand);

Console.WriteLine($"");
Console.WriteLine($"Вывод способом древней школы шаолинь");
Console.WriteLine($"Вывод №2! [{string.Join(", ", arrBinNumRand)}]");
