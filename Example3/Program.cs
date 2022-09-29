//Задача 40
//Напишите программу, которая будет преобразовывать 
//десятичное число в двоичное

string ReverseString(string s)
{
    char[] arr = s.ToCharArray();
    Array.Reverse(arr);
    return new string(arr);
}

string GetToInt2(int number)
{
    string result = null;
    while (number > 0)
    {
        result = result + (number % 2).ToString();
        number = number / 2;
    }
    result = ReverseString(result);
    return result;
}

Console.WriteLine("Введите десятичное число: ");
int number = int.Parse(Console.ReadLine());

string result = GetToInt2(number);
Console.WriteLine(result);
