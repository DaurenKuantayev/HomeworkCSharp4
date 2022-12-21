// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int DataSize(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void PrintArray(int[] charr)
{
    int i;
    for (i = 0; i < charr.Length - 1; i++)
    {
        Console.Write(charr[i] + ", ");
    }
    Console.Write(charr[i]);
}

void RandomIndex(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
}

Console.Clear();
int index = DataSize("Укажите размер массива ");
int[] array = new int[index];
RandomIndex(array);
PrintArray(array);