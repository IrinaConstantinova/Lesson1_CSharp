// Написание более сложной программы с методами и массивами

void FillArray(int[] collection)    // метод который заполняет массив
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)         // метод который выводит элементы массива в консоль
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // метод который находит заданный элемент find
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];    // задали массив из 10 элементов

FillArray(array);             // вызвали метод который заполнил наш массив генератором случайных чисел от 1 до 10
PrintArray(array);            // вызвали метод который распечатал наш массив в консоли
System.Console.WriteLine();

int pos = IndexOf(array, 2);
System.Console.WriteLine(pos);