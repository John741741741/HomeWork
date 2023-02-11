// Задача 4: Напишите программу, которая принимает
//  на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число");
string example = Console.ReadLine();
int a = Convert.ToInt32(example);
Console.WriteLine("Введите второе число");
string example1 = Console.ReadLine();
int b = Convert.ToInt32(example1);
Console.WriteLine("Введите третье число");
string example2 = Console.ReadLine();
int c = Convert.ToInt32(example2);
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write(max);
Console.Write(" <-----максимальное");