// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//  1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]  /    6, 1, 33 -> [6, 1, 33]


int[] FillArray(int[] arr)
{
    int arrLenght = arr.Length;
    for (int i = 0; i < arrLenght; i++)
    {
        arr[i] = new Random().Next(1, 99);
    }
    return arr; 
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

Console.Write($"Введите размер массива: ");
int arrLenght = Convert.ToInt32(Console.ReadLine());

int[] arrNum = new int[arrLenght];
PrintArray(FillArray(arrNum));

