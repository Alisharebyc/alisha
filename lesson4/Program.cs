﻿//Напишите программу, которая принимает на вход три числа и 
//выдает максимальное из этих чисел.
//2, 3, 7 -> 7
//44, 5, 78 -> 78
//22, 3, 9 -> 22

Console.WriteLine("Введите три целых числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;
if(number2 > max) Console.WriteLine(max = number2);
if (number3 > max) Console.WriteLine(max = number3);
Console.Write("Максимальное число равно ");
Console.WriteLine(max);