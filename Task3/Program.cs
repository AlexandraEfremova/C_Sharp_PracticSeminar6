// Задайте произвольную строку. Выясните, является ли она палиндромом.

void Main()
{
    string str = ReadInt("Введите строку, узнаем является ли она полиндромом \n(полиндром - строка, которая в обе стороны читается одинаково): ");
    char[] normChar = StringToChar(str); 
    char[] revChar = ReverChar(normChar);
    Answer(normChar);
}
// вывод результата
void Answer(char[] array)
{
    if(IsPalindrom(array))
    {
        System.Console.WriteLine($"Данная строка это палиндром");
    }
    else
    {
        System.Console.WriteLine($"Данная строка НЕ является палиндромом");
    }
}

// проверка на палиндромизм
bool IsPalindrom(char[] array)
{
    for (int i = 0; i < array.Length / 2; ++i)
        if (array[i] != array[array.Length - 1 - i]) 
            return false;
    return true;
}

// реверсия массива
char[] ReverChar(char[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        char temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
    return array;
}
// преобразование строки в массив
char[] StringToChar(string str)
{
    char[] normalChar = str.ToCharArray();
    return normalChar;
}
string ReadInt(string msg)
{
    System.Console.Write(msg);
    return Console.ReadLine()!.ToLower();
}

Main();

