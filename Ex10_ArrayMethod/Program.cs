// Данн одномерный массив array из n элементов, 
// требуется найти элемент массива равный find

int[] array = { 18, 12, 35, 51, 44, 51, 6, 79, 81, 12 };

int n = array.Length;
int find = 51;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;                             // оператор break нужин для того,
                                           // чтобы программа нашла find и выдала первый найденый индекс этого элемента,
                                           // если в массиве таках чисел много
    }
    index++;
}