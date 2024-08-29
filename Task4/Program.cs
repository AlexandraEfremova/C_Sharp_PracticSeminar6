// Обратный порядок слов в строке

void Main()
{
    string str = "one two three four five";
    string newStr =  ReversString(str);
    System.Console.WriteLine(str);
    System.Console.WriteLine(newStr);
}
// метод реверсии
string ReversString(string str)
{
    string[] array = str.Split(' ');
    Array.Reverse(array);
    return string.Join(", ", array);
}





Main();