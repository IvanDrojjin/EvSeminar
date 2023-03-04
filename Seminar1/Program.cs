/*
22:10 23.02.2023

https://gb.ru/lessons/305486/homework
Сдайте задание до: 2 марта, 20:00 +03:00 UTC

Урок 1. Знакомство с языком программирования С#
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Задача 4: Напишите программу, которая принимает на вход три числа и 
выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("https://gb.ru/lessons/305486/homework");

Console.WriteLine(" # 2: ... на вход принимает два числа ... выдаёт большее.");
Console.Write("input int1  : "); 
int numb1  =  Convert.ToInt32(Console.ReadLine());

Console.Write("input int2  : "); 
int numb2  =  Convert.ToInt32(Console.ReadLine());

if (numb1 == numb2)
{
    Console.WriteLine ($"max  =  {numb1}  ,  {numb2} "); //; 
}
else if (numb1 > numb2)
{
    Console.WriteLine ($"max  =  {numb1}  "); //; 
}
else
{
    Console.WriteLine ($"max  =  {numb2}  "); //; 
}

 
/*
Задача 4: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Math.Max(Int32, Int32): Returns the larger of the two
*/

Console.WriteLine(" #4: .... на вход три числа ... выдаёт максимальное.");

Console.Write("input int1  : "); 
int numb41  =  Convert.ToInt32(Console.ReadLine());

Console.Write("input int2  : "); 
int numb42  =  Convert.ToInt32(Console.ReadLine());

Console.Write("input int3  : "); 
int numb43  =  Convert.ToInt32(Console.ReadLine());

int max40 = Math.Max( Math.Max(numb41, numb42), numb43 ) ;
Console.WriteLine($"  {numb41}  {numb42}  {numb43} -> {max40}");


/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка). // %2 ==0
 
4 -> да
-3 -> нет
7 -> нет
*/
Console.WriteLine(" #6: .... является ли число чётным ?");

Console.Write("input int1  : "); 
int numb61  =  Convert.ToInt32(Console.ReadLine());

string  str61 =""; //  "ДА" ; //  "НЕТ"
if (numb61 %2 == 0)
{
    str61 = "ДА";
}
else
{
     str61 = "НЕТ";
}
Console.WriteLine ($" {numb61} -> {str61} "); //; 


/*

Д73. C# для школьников: Учебное пособие 
/ М. Дрейер. Перевод с англ. под ред. В. Биллига—. 
М.: Интернет-Университет Информационных Технологий; БИНОМ.

https://download.microsoft.com/documents/rus/msdn/c_sharp2.pdf

Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

*/

Console.WriteLine(" #8 на выходе показывает все чётные числа от 1 до N.");
Console.Write("input int1  : "); 
int numb81  =  Convert.ToInt32(Console.ReadLine());

if (numb81 >= 0)
{
    Console.Write ($" {numb81} ->  "); //; 

    for(int k = 2; k < numb81 ; k += 2)
    {
        Console.Write($" {k},");  
    }
}
Console.WriteLine();

