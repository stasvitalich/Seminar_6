//Задача 39
//Напишите программу, которая перевернёт одномерный массив.

//Определяем, из скольки элементов будет состоять массив.
//Принимаем на вход целые числа как показано в примере.
Console.WriteLine("Введите количество элементов массива: ");
int elementsCount = int.Parse(Console.ReadLine());
int [] NewArray = new int [elementsCount];

//Заполняем наш массив вручную
for(int i = 0; i < NewArray.Length; i = i + 1)
{
    Console.WriteLine($"Введите элемент массива с индексом {i}");
    NewArray[i] = int.Parse(Console.ReadLine());
}

//Выводим введённый ранее массив
Console.WriteLine();
Console.Write("Инициирован массив: [");
for (int i = 0; i < NewArray.Length; i = i + 1)
{   
    if (i < elementsCount - 1)
        {
            Console.Write($"{NewArray[i]}, ");
        }
    else
        {
            Console.Write($"{NewArray[i]}");
        }   
}
Console.Write("]");
Console.WriteLine("");


//Выводим перевёрнутый массив
Console.WriteLine();
Console.Write("Перевёрнутая версия массива: [");
for (int i = NewArray.Length - 1; i >= 0; i = i - 1)
{   
    if (i > 0)
        {
            Console.Write($"{NewArray[i]}, ");
        }
    else
        {
            Console.Write($"{NewArray[i]}");
        }   
}
Console.Write("]");
Console.WriteLine("");
