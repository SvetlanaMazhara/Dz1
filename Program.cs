/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Input first nomber");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second nomber");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1>num2)
{
   Console.WriteLine("num1 more then num2");
}
else
{
    Console.WriteLine("num2 more then num1");
}

Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Input first nomber");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second nomber");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input therd nomber");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
Console.WriteLine("Наибольшее из введённых чисел " + max);

Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Input nomber:");
int num = Convert.ToInt32(Console.ReadLine());
if ( num % 2 ==0)
{
   Console.WriteLine("Num is chetnoe"); 
}
else
{
Console.WriteLine("Num is nechetnoe");
};*/


