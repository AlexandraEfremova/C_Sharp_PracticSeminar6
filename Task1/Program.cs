// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

void Main()
{
    char[,] simbols = 
    {
        {'a', 'b', '!'},
        {'w', 'e', '3'},
        {'f', 'z', '0'}
    };
    PrintArray(simbols);
    System.Console.WriteLine($"'{TransformCharToString(simbols)}'");       
}

// преобразование массива в строку
string TransformCharToString(char[,] array)
{
    string str = "";
    foreach(char element in array)
    {
        str += element; 
    }
    return str;
}
// печать массива
void PrintArray(char[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}


Main();
