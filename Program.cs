// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Console.Write("Введите трехзначное число: ");
int NumberA = int.Parse(Console.ReadLine());
int result1 = NumberA / 10;
int result = result1 % 10;
if (NumberA < 100 || NumberA > 1000)
Console.WriteLine("Введенное число не трехзначное");   
else
Console.WriteLine($"Вторая цифра {result}");
