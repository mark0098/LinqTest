using System;
using System.Linq;

int[] numbers = { -3, -7, -2, -5, 8, 4, 9, 6 };

// Находим индекс первого положительного элемента
int firstPositiveIndex = Array.FindIndex(numbers, x => x > 0);

if (firstPositiveIndex == -1)
{
    Console.WriteLine("В массиве нет положительных элементов.");
    return;
}

// Выбираем только отрицательные элементы до первого положительного и вычисляем их среднее
var average = numbers.Take(firstPositiveIndex)
                    .Where(x => x < 0)
                    .Select(x => (double)x) // Преобразуем int в double
                    .DefaultIfEmpty(double.NaN) // Если нет отрицательных элементов, вернуть NaN
                    .Average();

if (double.IsNaN(average))
{
    Console.WriteLine("Отрицательных элементов перед первым положительным элементом нет.");
}
else
{
    Console.WriteLine($"Среднее арифметическое отрицательных элементов: {average}");
}