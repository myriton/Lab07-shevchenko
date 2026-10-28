//Задание 1.1
// string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт",};

// days[]
// for (int i = 0; i < days.Length; i++)
// {
//     Console.WriteLine($"{i}: {days[i]}");
// }
//Задание 1.2
// double[] temps = {0, 11, 3, 5, -2, 7, 15};
// foreach (double i in temps)
// {
//     Console.Write($"{i} ");
// }
// Console.WriteLine();
//Задание 2
// int sum = 0;
// int sr = 0;
// int sto = 0;
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// foreach (int i in prices)
// {
//     sum += i;
//     sr++;
//     if (i > 100)
//     {
//         sto++;
//     }
// }
// Console.WriteLine($"{sum}, {sum/sr}, {sto}");
//Задание 3
// int ind = 0;
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int min = prices[0];
// for (int i = 1; i < prices.Length; i++)
// {
//     if (prices[i] < min) 
//     {
//         min = prices[i];
//     } 
//     if (prices[i] > prices[ind])
//     {
//         ind = i;
//     }
// }
// Console.WriteLine($"{min}, {ind}");
//Задание 4
// int[] balance = { 100, -50, 20, -5, 0, 75 };
// for (int i = 0; i < balance.Length; i++)
// {
//     if (balance[i] < 0)
//     {
//         balance[i] = 0;
//     }
// }
// foreach (int n in balance)
// {
//     Console.Write(n + " ");
// }
//Задание 5
// int[] numb = new int[5];
// int chet = 0;
// Console.WriteLine("Введите 5 целых чисел:");
// for (int i = 0; i < numb.Length; i++) 
// {
//     int a = int.Parse(Console.ReadLine());
//     numb[i] = a;
// }
// for (int i = numb.Length - 1; i >= 0; i--)
// {
//     Console.Write(numb[i] + " ");
//     if (numb[i] % 2 == 0)
//     {
//         chet++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine(chet);
//Задание 6
// string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };
// Console.WriteLine("Введите имя");
// string a = Console.ReadLine();
// bool naiden = false;
// for (int i = 0; i < names.Length; i++)
// {
//     if (a == names[i]) {
//         Console.WriteLine(i);
//         naiden = true;
//         break;
//     } 
// }
// if (!naiden)
//     {
//         Console.WriteLine("Не найдено");
//     }
//«Журнал оценок»
using System.Data;

int[] grades = {2, 3, 4, 5, 2, 3, 4, 5};

int sum = 0;
int colvo = 0;

int min = 0;
int max = 0;

int dv = 0;
int pt = 0;
foreach (int n in grades)
{
    Console.Write(n + " ");
    sum += n;
    colvo++;
    if (n > max)
    {
        max = n;
    }
    if (n < min)
    {
        min = n;
    }
    if (n == 2)
    {
        dv++;
    }
    if (n == 5)
    {
        pt++;
    }
}

Console.WriteLine();
double sr = sum / colvo;
Console.WriteLine($"Средняя {sr}");

Console.WriteLine($"Мин: {min}, Макс: {max}");

Console.WriteLine($"Двойки: {dv}, Пятерки: {pt}");

if (sr >= 4.5)
{
    Console.WriteLine("Отличник");
} 
else if (sr >= 3.5)
{
    Console.WriteLine("Хорошист");
} else
{
    Console.WriteLine("Есть над чем поработать");
}
