﻿// Найти кубы чисел от 1 до N.
Console.WriteLine("enter a number");
int number = int.Parse(Console.ReadLine() ?? "0");
int count = 1;
int number2 = 1;
	while (count<= number)  
{
int result = number2 * number2 * number2;
Console.WriteLine($" {number2} in cube is {result} ");
number2++;
count++;
}

