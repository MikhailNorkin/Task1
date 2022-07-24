int number1 = 0;
int number2 = 0;
Console.Write($"Введите первое число: ");
bool enter1 = int.TryParse(Console.ReadLine(), out number1);
if (enter1)
{ // если правильно ввели первое число, тогда
    Console.Write($"Введите второе число: ");
    bool enter2 = int.TryParse(Console.ReadLine(), out number2);
    if (enter2)
    { //если правильно ввели второе число, тогда:
        // проверяем, какое из чисел больше
        if(number1 > number2)
        {
            Console.WriteLine($"max = {number1}");
        }
        else 
        {
            Console.WriteLine($"max = {number2}");
        }    
    }
    else
    {
        Console.WriteLine($"Вы неправильно ввели второе число");
    }    
}
else   
{
    Console.WriteLine($"Вы неправильно ввели перове число");
}    
