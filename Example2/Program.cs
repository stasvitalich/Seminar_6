//Задача 40
//Напишите программу, которая принимает на вход 3 числа
//и проверяет, может ли существовать треугольник
//со сторонами такой длины
Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число С: ");
int c = int.Parse(Console.ReadLine());

int ac = a * c;
int ab = a * b;
int bc = b * c;

if (ac <= ab + bc)
{
    Console.WriteLine("Да, такой треугольник может существовать");
}

else
{
    Console.WriteLine("Нет, такой треугольник не может существовать"); 
}
