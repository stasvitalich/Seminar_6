//Задача 40
//Напишите программу, которая будет преобразовывать 
//десятичное число в двоичное
Console.WriteLine("Введите десятичное число: ");
int number = int.Parse(Console.ReadLine());


if (number % 2 == 1)
{
    Console.Write(1);
    while (number > 1)
    {
        number = number / 2;
        if (number % 2 == 1)
        {
            Console.Write(1);
        }
        else
        {
            Console.Write(0);
        }
    }
}






if (number % 2 == 0)
{
    Console.Write(0);
    while (number > 1)
    {
        number = number / 2;
        if (number % 2 == 1)
        {
            Console.Write(1);
        }
        else
        {
            Console.Write(0);
        }
    }
}


