// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16




System.Console.WriteLine("Ведите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine()); 

System.Console.WriteLine("Ведите второе число :");
int number2 = Convert.ToInt32(Console.ReadLine()); 

System.Console.WriteLine(Math.Pow(number1, number2));
