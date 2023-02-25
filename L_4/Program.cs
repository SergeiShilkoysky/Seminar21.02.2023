// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
//  [1,0,1,1,0,1,0,0]

/*1 способ
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

        // в форе форматирование было бы сильно короче, но изначально
        // формативно не предусматривалось =) можно применить тернарник
        // но я их не люблю
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
*/

// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int N = 8;
int min = 0;
int max = 1;

int[] CreateArray(int N, int min, int max)
{
    int[] arr = new int[N];
    for (int i = 0; i < N; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

PrintArray(CreateArray(N, min, max));
