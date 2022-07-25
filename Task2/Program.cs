int number1 = 0;
int number2 = 0;
int number3 = 0;
int max = 0; //здесь будем хранить максимальное значение
Console.Write($"Введите первое число: ");
bool enter1 = int.TryParse(Console.ReadLine(), out number1);
//проверим какое из первых двух чисел больше:
if (enter1)
{ // если правильно ввели первое число, тогда
    Console.Write($"Введите второе число: ");
    bool enter2 = int.TryParse(Console.ReadLine(), out number2);
    if (enter2)
    { //если правильно ввели второе число, тогда:
        // проверяем, какое из чисел больше
        if(number1 > number2)
        {
            max = number1;
        }
        else 
        {
            max = number2;
        }    
    }
    else
    {
        Console.WriteLine($"Вы неправильно ввели второе число");
    }    
}
else   
{
    Console.WriteLine($"Вы неправильно ввели первое число");
}    

// теперь проверим больше ли третье число max
Console.Write($"Введите третье число: ");
bool enter3 = int.TryParse(Console.ReadLine(), out number3);
//проверим какое из первых двух чисел больше:
if (enter3)
{
    if (number3 > max)
    {
        max = number3;
    }
}
else
{
    Console.WriteLine($"Вы неправильно ввели третье число");
}  
 Console.WriteLine($"max = {max}");