// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//  1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]  /    6, 1, 33 -> [6, 1, 33]

int[] FillArray(int array)
{
    array = int [array.Length];
        Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = rnd.Next(0, 100);
    }
    return result;
}
void PrintArray(){
     Console.WriteLine($"[{string.Join(",",array)}]");
}
 Console.WriteLine($"Введите размер массива:");
int size = int.Parse(Console.ReadLine());

int[] array = FillArray(array);
print(array);




