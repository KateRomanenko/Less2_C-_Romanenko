﻿// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int n = new Random().Next(100, 1000);

Console.WriteLine(n);
int c1 = n / 100;
int c2 = n % 10;
int N = c1*10+c2;

Console.WriteLine(N);