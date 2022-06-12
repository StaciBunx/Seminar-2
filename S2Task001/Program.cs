//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

using System;
using static System.Console;

Clear();

Write("Введите трехзначное число: ");
int number = Convert.ToInt32(ReadLine());
if (number > 99 & number <= 999)
{
    int answer = number / 10 - number / 100 * 10;
    WriteLine(answer);
}
else
{
    WriteLine("Неверно! Нужно ввести трехзначное число!");
}
