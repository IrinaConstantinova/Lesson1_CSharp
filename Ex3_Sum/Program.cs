// Задание 3. Лекция 1 по CSharp
// Написать программу которая будет 
//случайным образом выбирать 2 числа от 1 до 10 и 
// выводить их сумму

int numberA = new Random().Next(1, 10); // 1 2 3 4 .... 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int sum = numberA + numberB;
Console.WriteLine(sum);