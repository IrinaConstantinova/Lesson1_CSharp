// Сортировка методом выбора
// Отсортировать заданный массив

// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 8, 55, 6, 9, 6 };

// void PrintArray(int[] array) // метод выведа массива в консоль
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
//     System.Console.WriteLine();
// }

// void SelectionSort(int[] array)  // метод сортировки массива методом выбора
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition])
//             minPosition = j;
//         }
//         int temporary = array[i]; // определяем переменную в которой будет храниться временное значение 
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;

//     }
// }
// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);


int[] arr = { 1, 5, 4, 3, 2, 6, 7, 8, 55, 6, 9, 6 };

void PrintArray(int[] array) // метод выведа массива в консоль
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array)  // метод сортировки массива методом выбора
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
            maxPosition = j;
        }
        int temporary = array[i]; // определяем переменную в которой будет храниться временное значение 
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;

    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);