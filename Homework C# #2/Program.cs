// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int DataNumber(string msg)
{
    Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Decay(int number)
{
    int sum;
    for (sum = 0; number != 0; number = number/10)
    {
        int count = number % 10;
        sum = sum + count;
    }
    return sum;
}

int num = DataNumber("Введите число ");
if(num > 0)
{
    int sum = Decay(num);
    Console.WriteLine(sum);
}
else Console.WriteLine("Введено неверное число");