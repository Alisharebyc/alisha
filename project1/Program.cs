// Демонстрация решения.
// Напишите программу, которая на вход принимает 
// число и выдает его квадрат(число, умноженное на само себя).
// например:
// 4 --> 16
// -3 --> 9
// -7 --> 49

//int num = 4;
//int square = num * num;
//Console.WriteLine(square);

//Console.Write("Введите целое число ");
//int num = Convert.ToInt32(Console.ReadLine());
//int square = num * num;
//Console.Write($"Квадрат числа {num} = {square}");

//Напишите программу, которая на вход принимает два числа
//и проверяет, является ли первое число квадратом второго.

Console.WriteLine("Эта программа проверяет, является ли первое число квадратом второго. \nВведите два целых числа ");
int first = Convert.ToInt32(Console.ReadLine());
int second =Convert.ToInt32(Console.ReadLine());
if(second * second == first)
{
    Console.WriteLine($"Да, {first} является квадратом {second}.");
}
else
{
    Console.WriteLine($"Нет, {first} не является квадратом {second}.");
}