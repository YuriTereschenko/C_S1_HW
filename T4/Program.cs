// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Ввеите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a>1)
for (int i=1; i<=a; i++)
{
    if (i%2== 0)
    {
        Console.Write(i+" "); 
    }
}
else
    Console.WriteLine("Нет чисел в указаном диапазоне");
