// Напишите программу, которая на вход
//принимает число и выдаёт, является ли число чётным
//(делится ли оно на два без остатка).

Console.WriteLine("Введите число для проверки:");
int number1 = Convert.ToInt32(Console.ReadLine());
int result1;

if (number1 % 2 ==0)
{
    Console.WriteLine ("Число четное");
}

else
{
   Console.WriteLine ("Число не четное"); 
}
