// Задача 41. 
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Пример: 0, 7, 8, -2, -2 -> 2

// Определяем, из скольки элементов будет состоять массив.
// Принимаем на вход целые числа.
Console.WriteLine("Введите количество элементов массива: ");
int elementsCount = int.Parse(Console.ReadLine());
int[] NewArray = new int[elementsCount];

// Заполняем наш массив вручную.
for (int i = 0; i < NewArray.Length; i = i + 1)
{
    Console.WriteLine($"Введите элемент массива с индексом {i}");
    NewArray[i] = int.Parse(Console.ReadLine());
}

// Выводим введённый ранее массив.
Console.WriteLine();
Console.Write("Инициирован массив: [");
for (int i = 0; i < NewArray.Length; i = i + 1)
{
    if (i < elementsCount - 1) Console.Write($"{NewArray[i]}, ");
    else Console.Write($"{NewArray[i]}");
}
Console.Write("]");
Console.WriteLine("");

// Напишем метод, который будет счиать кол-во положительных чисел.
Console.WriteLine("");
Console.Write("Количество положительных чисел в массиве: ");

int GetPositiveNumbers(int[] NewArray)
{
    int sum = 0;
    for (int i = 0; i < NewArray.Length; i = i + 1)
    {
        if (NewArray[i] > 0) sum = sum + 1;
    }
    return sum;
}

// Через новую переменную выведем метод на печать.
int totalPositive = GetPositiveNumbers(NewArray);
Console.Write(totalPositive);
