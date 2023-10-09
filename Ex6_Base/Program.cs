// Задание 6. Лекция 1 по CSharp
// Даны 5 часел и нужно найти максимальное число

int a = 1;
int b = 2;
int c = 60;
int d = 10;
int e = 4;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);