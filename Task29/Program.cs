// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.WriteLine("Задайте размер массива");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next (0, 10);
    }
    return array;
}

void ShowArray(int[] createdArray)
{
    for(int i = 0; i < createdArray.Length; i++)
    {
        Console.Write(createdArray[i] + " ");
    }
}

ShowArray(CreateArray(sizeArray));