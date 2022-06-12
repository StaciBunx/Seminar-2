// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

using System;
using static System.Console;

Clear();

Write("Введите цифру дня недели: ");
int dayNumber = Convert.ToInt32(ReadLine());

string answer = dayNumber == 6 || dayNumber == 7 ? "да" : "нет";
WriteLine(answer);