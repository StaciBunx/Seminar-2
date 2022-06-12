//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 6
//78 -> третьей цифры нет
//32679 -> 6

using System;
using static System.Console;

Clear();

int number = new Random().Next(10,100000);

WriteLine($"Заданное число: {number}");

string answer = number < 100
? "третьей цифры нет": $"{(number%1000-number%100)/100}";

WriteLine(answer);
