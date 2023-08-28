// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*
int[] CreateArray(int m)
{
    int[] array = new int[m];

    for (int i = 0; i < m; i++)
    {
        Console.Write($"Element {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int PositiveElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Enter the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
int count = PositiveElements(myArray);
Console.WriteLine("Positive Elements: " + count);
*/


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// Вычисления для решения:
// x = (b2 - b1) / (k1 - k2)


void TheIntersectionOfTwoLines(double k1, double k2, double b1, double b2)
{
    if (k1 - k2 == 0 && b2 - b1 == 0)
        Console.WriteLine("Lines match.");
    else if (k1 - k2 == 0 && b2 - b1 != 0)
        Console.WriteLine("Lines are parallel.");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = x * k1 + b1;
        Console.WriteLine($"Lines intersect at a coordinate point ({x}; {y}).");
    }
}
Console.Write ("Input k1 of the first line: ");
double unknownK1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b1 of the first line: ");
double unknownB1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2 of the second line: ");
double unknownK2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2 of the second line: ");
double unknownB2 = Convert.ToInt32(Console.ReadLine());
TheIntersectionOfTwoLines(unknownK1, unknownK2, unknownB1, unknownB2);

// Доп. задача