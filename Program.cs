﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

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
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);

int max = a;

if (a >= max) System.Console.WriteLine($"max = {a}"); 
if (b > max) System.Console.WriteLine($"max = {b}");
if (c > max) System.Console.WriteLine($"max = {c}");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка(number%2==0)).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
