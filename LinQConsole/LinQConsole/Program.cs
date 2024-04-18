using System.Linq;

Console.WriteLine("Вариант 7");

int[] vectr = { -1, -2, -3, 5, 0, 3, 2, 1, 0 };

Console.WriteLine("Дан массив");

var selectedVectr = (from int i in vectr
                     select i).ToList();

foreach (int i in selectedVectr)
    Console.Write(i + " ");

Console.WriteLine(" ");

Console.WriteLine("Задание:");
Console.WriteLine("Найти среднее арифметическое отрицательных элементов массива,\r\nпредшествующих первому положительному элементу. Если по какой-либо" +
    "\r\nпричине вычислить среднее арифметическое не удается, выдать об этом" +
    "\r\nсообщение с указанием причины.");

Console.WriteLine("выполненное задание:");
var mission = from int i in vectr
              where i < 0
              select i;
              





int time = 0;
int count = 0;

foreach (int i in mission)
{
    time += i;
    count++;
}

time = time / count;
