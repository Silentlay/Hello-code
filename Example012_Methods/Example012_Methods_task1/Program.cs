/*
Задача 1
Дан текст. В тексте нужно все пробелы заменить черточками,
маленькие буквы "к" заменить большими "К", а большие "С"
заменить маленькими "с".
*/

// Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбыясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы юы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
// strung s = "qwerty"
//             012     - номер символа
// s[3]  // r

string Replace(string text, char oldValue, char newValue)// указываем символ который мы будем менять и charValue символ на который мы будем менять
{
    string result = String.Empty;// инициализация (создание) пустой строки
    int length = text.Length;// указываем колличество символов в данной строке, в данном случае выдаст 6
    for (int i = 0; i < length; i++)// от начального символа до конца строки
        {
            if (text[i] == oldValue) result = result + $"{newValue}";// если текущий символ - text[i] совпал с тем символом который мы хотим заменить, то в результат кладем новое значение в виде строки newValue
            else result = result + $"{text[i]}"; // если совпадений не обнаружено добавить в резалт значение
        }
            return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

newText = Replace(newText, 'C', 'c');
Console.WriteLine(newText);

