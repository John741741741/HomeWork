// Задача 2: Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число");
string example = Console.ReadLine();
int a = Convert.ToInt32(example);
Console.WriteLine("Введите второе число");
string example1 = Console.ReadLine();
int b = Convert.ToInt32(example1);
if (a > b)
{
    int max = a;
    int min = b;
    Console.Write(max);
    Console.Write(" больше чем ");
    Console.WriteLine(min);
}
else
{
    int max = b;
    int min = a;
    Console.Write(max);
    Console.Write(" больше чем ");
    Console.WriteLine(min);
}