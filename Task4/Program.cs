int number = 0;
int ostatok = 0;
int N = 2;

Console.Write($"Введите число: ");
bool enter = int.TryParse(Console.ReadLine(), out number);
if (enter)
{ 
    if (number > 0) // проверим число больше нуля или нет:
    {
        if (ostatok != 0)
        { //если без остатка не делится, тогда найдем предыдущее число (оно будет четным):
            number = number - 1;
        }
        Console.WriteLine("Четные числа до вашего числа:");
        while (N <= number)
        {
            Console.Write($"{N} ");   
            N = N + 2;
        }
    }    
    else
    {
      Console.Write("Вы ввели число меньше нуля!");  
    }
}
else
{
    Console.WriteLine($"Вы неправильно ввели число");
}
Console.WriteLine();