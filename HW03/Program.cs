Console.WriteLine("Введите 3 числа для сравнения:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

if ((number1>number2) & (number1>number3))
{
    
    Console.WriteLine ("Вывод: Первое число наибольшее");
}
if ((number2>number1) & (number2>number3))
{
    
    Console.WriteLine ("Вывод: Второе число наибольшее");
}
if ((number3>number1) & (number3>number2))
{
    
    Console.WriteLine ("Вывод: Третье число наибольшее");
}
