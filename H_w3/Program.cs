// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//  1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]  /    6, 1, 33 -> [6, 1, 33]

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
       arr[i] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write($"{array[i]} ");
    }
}

Console.WriteLine($"Введите размер массива:");
int line = int.Parse(Console.ReadLine());

PrintArray(FillArray(arr));

