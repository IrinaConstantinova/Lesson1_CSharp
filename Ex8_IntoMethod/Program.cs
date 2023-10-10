// Задача на нахождение максимального числа с применением методов

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 15;
int b1 = 22;
int c1 = 332544;

int a2 = 11;
int b2 = 7;
int c2 = 33;

int a3 = 1;
int b3 = 225;
int c3 = 47;

// int max1 = Max(a1, b1, c1); 
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);

// int max = Max(max1, max2, max3);

int max = Max(              // Аналогично строкам 22, 23, 24 и 26. 
                            // Только более короткая запись, которую можно было записать в одну строку кода
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));


System.Console.WriteLine(max);