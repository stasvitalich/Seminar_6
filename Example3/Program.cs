//Задача 40
//Напишите программу, которая будет преобразовывать 
//десятичное число в двоичное

//Пишем метод переворачивания строки
string ReverseString(string s)
{
    char[] arr = s.ToCharArray();
    Array.Reverse(arr);
    return new string(arr);
}

//Пишем метод, принимающий на вход число, а возвращающий строку.
//Метод, который переводит полученное число в двоичную систему и в строку
string GetToInt2(int number)
{
    string result = string.Empty; //Мы могли бы написать что result = 0, но лучше писать empty
    while (number > 0)
    {
        result = result + (number % 2).ToString();
        number = number / 2;
    }
    result = ReverseString(result);
    return result;
}

//Инициируем ввод нашего числа
Console.WriteLine("Введите десятичное число: ");
int number = int.Parse(Console.ReadLine());

//Печатаем наш метод по переводу числа в двоичную систему
string result = GetToInt2(number);
Console.WriteLine(result);
