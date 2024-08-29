// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.


void Main()
{
    string str = PrintInt("Введите строку латинскими буквами и символами '\t' верхнего и нижнего регистров: ");
    string strToLower = ToLowerString(str);
    System.Console.WriteLine(strToLower);
}
// приведение в нижний регистр
string ToLowerString(string str)
{
    return str = str!.ToLower();
}

// запрос строки от пользователя
string PrintInt(string msg)
{
    System.Console.Write(msg);
    return Console.ReadLine()!;
} 
Main();