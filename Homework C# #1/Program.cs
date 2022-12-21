// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();
int DataNumber(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int numberA = DataNumber("Введите число А ");
int numberB = DataNumber("Введите число В ");
double exp = numberA;
if(numberB > 0)
{
    for (int i = 1; i < numberB; i++)
    {
     exp = exp*numberA;
    }
    Console.WriteLine($"Степень числа {numberA} в {numberB} -> {Math.Round(exp, 2)}");
}
else if(numberB == 0) exp = 1;
else
{
    numberB = -numberB;
    for (int i = 1; i < numberB; i++)
    {
    exp = exp*numberA;
    }
    exp = 1/exp;
    Console.WriteLine($"Степень числа {numberA} в -{numberB} -> {Math.Round(exp, 2)}");
}