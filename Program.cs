// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);

// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);

// if (a > b) { System.Console.WriteLine($"max = {a}"); }
// else { System.Console.WriteLine($"max = {b}"); }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);

// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);

// Console.Write("Введите третье число: ");
// int c = int.Parse(Console.ReadLine()!);

// int max = a;

// if (a >= max) System.Console.WriteLine($"max = {a}"); 
// if (b > max) System.Console.WriteLine($"max = {b}");
// if (c > max) System.Console.WriteLine($"max = {c}");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка(number%2==0)).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// if (number % 2 == 0)
// {
//     System.Console.WriteLine($"Число {number} четное");
// }
// else
// {
//     System.Console.WriteLine($"Число {number} нечетное");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);
// int A = 1;
// while (A <= N)
// {
//     if (A % 2 == 0)
//     {
//         System.Console.Write($"{A} ");
//         A = A + 2;
//     }
//     else
//     {
//         A++;
//     }
// }

////////// Семинар 2 ///////////

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трехзначное число: ");
// string num = Console.ReadLine()!;

// if (num.Length == 3)
// {
//     Console.Write($"{num[1]} ");
// }
// else
// {
//     Console.Write("Число не является трехзначным");
// }
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите число: ");
string num = Console.ReadLine()!;

if (num.Length >= 3)
{
    Console.Write($"{num[2]} ");
}
else
{
    Console.Write("третьей цифры нет");
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет