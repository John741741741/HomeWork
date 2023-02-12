// Задача 8: Напишите программу, которая на вход принимает 
// число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int i = 0 +1; 

while (i <= a)
{
    Console.WriteLine(i);
    i++;
}
// if (a % 2 == 0)
