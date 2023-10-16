// Задача с использованием цикла for. 
// Необходимо вывести таблицу умножения в консоль

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <=10; j++)
//     {
//         System.Console.Write($"{j} x {i} = {i*j}  \t"); // интерполяция строк или форматированная строка
//     }
//     System.Console.WriteLine();
// }


// Зазача с методами. Метод номер 4
// ======Работа с текстом
// Условие: данн текст. В тексте нужно все пробелы заменить чёрточками
// маленькие буквы "к" заменить на большие "К", а большие "С" на маленькие "с"

string text = "- Я думал, - сказал князь, улыбаясь, - что, "
            + "ежали бы вас послали вместо нашего милого Винценгероде," 
            + "вы бы взяли приступом согласие прусского короля." 
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "Любая сторка"
//             0123.......11 строка представляет собой массив симфолов и по индексу можно обратьться к любому символуу строки
// s[3] -> а

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; // изначально нужно инициализировать пустую строку

    int length = text.Length; // во торых определить длину строки
    for (int i = 0; i < length; i++) // пробежимся по всем символам строки
    {
        if (text[i] == oldValue)
         result = result + $"{newValue}"; // и если символ [i] совпадёт со старым значанием, то запишем в него новое значение 
        else 
         result = result + $"{text[i]}";
    }   
    return result; // вернуть результат
}
string newText = Replace(text, ' ', '|');
System.Console.WriteLine(newText);

System.Console.WriteLine();

newText = Replace(text, 'к', 'К');
System.Console.WriteLine(newText);

System.Console.WriteLine();

newText = Replace(text, 'с', 'С');
System.Console.WriteLine(newText);