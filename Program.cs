//Seminar_1. Homework 1.
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input a first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) Console.WriteLine($"Max number = {num1} are Min number = {num2}");
else Console.WriteLine($"Max number = {num2} are Min number = {num1}");

if (num1 == num2) Console.WriteLine($"Max number {num1} = Min number {num1}");
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input a first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
Console.Write("Max number ");
Console.WriteLine(max);
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0){Console.Write(number + " is even number");}
else{Console.Write(number + " is not even number");}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 1;
if (number <= 1)
{
    Console.Write("We have no even numbers");
}
else
    while(current <= number)
    {
        if(current % 2 == 0)
        {
        Console.Write(current + " ");
        current = current + 2;
        }
        else
        {
        current = current + 1;
        }
    } 
    */