// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число, обозночающее день недели: ");
int num = int.Parse(Console.ReadLine());
if(num == 1) Console.Write("не является");
if(num == 2) Console.Write("не является");
if(num == 3) Console.Write("не является");
if(num == 4) Console.Write("не является");
if(num == 5) Console.Write("не является");
if(num == 6) Console.Write(" является");
if(num == 7) Console.Write(" является");

if(num > 7) Console.Write("число не подходит по условию задачи");