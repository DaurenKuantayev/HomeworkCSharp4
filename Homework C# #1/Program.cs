// ## Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

int EntryNumber(string str)
{
    System.Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] AddArrayWithRundomNumbers(int lenght, int min, int max)
{
    int[] arr = new int[lenght];
    Random rand =  new Random();
    for (int i = 0; i < lenght; i++)
    {
        arr[i] = rand.Next(min, max + 1);
    }
    return arr;
}

int EvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) 
        {
            count++;
        }
    }
    return count;
}


const int BOTLIMIT = 100;
const int TOPLIMIT = 999;
int lenghtArr = EntryNumber("Введите размер массива");
int[] arrey = AddArrayWithRundomNumbers(lenghtArr, BOTLIMIT, TOPLIMIT);
System.Console.WriteLine('[' + string.Join(", ", arrey) + ']');
int even = EvenNumbers(arrey);
System.Console.WriteLine($"Четных чисел в массиве - {even}");