int number = 0;
int ostatok = 0;

Console.Write($"Введите число: ");
bool enter = int.TryParse(Console.ReadLine(), out number);
if (enter)
{ // если правильно ввели число, тогда проверим, делиться ли оно на 2 без отстака:
    ostatok = number % 2;
    if (ostatok == 0)
    {
        Console.WriteLine($"Число является четным");
    }
    else
    {
        Console.WriteLine($"Число является нечетным");
    }
}
else
{
    Console.WriteLine($"Вы неправильно ввели число");
}