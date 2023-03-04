// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Напишите программу, которая выводит случайное трёхзначное число 
и удаляет вторую цифру этого числа.
*/

int CutNumber(int num)
{ //  315 -> 35     / 100 * 10 + %10
    int hundr = num / 100;
    int ones =  num % 10;
    int res = hundr * 10 + ones;
    return res;
}  //  315 -> 35     //100 * 10 + %10

// int CutNumber_(int num)
// { //  315 -> 35     / 100 * 10 + %10
//     /*
//     int hundr = num / 100;
//     int ones =  num % 10;
//     int res = hundr * 10 + ones;
//     */
//     return (num / 100) * 10 + (num % 10);
// }  //  315 -> 35     //100 * 10 + %10

int randNumber = new Random().Next(100, 1000);
int res2 = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {res2} ");

// int test;

// bool IsDivided(int numb, int firstDiv, int secondDiv)
// {
//     // return  ((numb % firstDiv == 0) && (numb % secondDiv == 0));
//     if ((numb % firstDiv == 0) && (numb % secondDiv == 0))
//     //  if ((numb % (firstDiv * secondDiv) == 0))
//     {
//         return true;
//     } else 
//     {
//         return false;
//     }    
// }

// Console.Write($"New version of {randNumber} is {res2} ");
// // int num = 

// Console.WriteLine($"New version of {randNumber} is {res2} ");

/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] 
и показывает наибольшую цифру числа.
*/
int MaxNumber(int num)
{
    int i1 = num % 10;
    int i2 = num / 10;
    int max = i1; 
    if (i2 > i1) max = i2;
    return max;
} 

int rndNum = new Random().Next(10, 100);

res2 = MaxNumber(rndNum);
Console.WriteLine($"max digit of {rndNum} is {res2} ");

/*
Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
*/

bool IsSquar(int i1, int i2)
{
    return ((i1 * i1 == i2) || (i1 == i2 * i2));
}

Console.Write($" input i1 : ");
int i1 = Convert.ToInt32(Console.ReadLine());
Console.Write($" input i2 : ");
int i2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" {i1}  {i2}   is square  {IsSquar(i1, i2)}... ");


/*
https://gb.ru/lessons/305487/homework
Знакомство с языками программирования (семинары)
Урок 2. Базовые алгоритмы

Загрузите домашнее задание на проверку до 6 марта, 20:00 +03:00 UTC
Это задание для самостоятельной работы, без оценки преподавателя
*/

/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.  !!! второе справа
456 -> 5        782 -> 8        918 -> 1
*/

int ShowSecondDigit(int i3) 
{
    int res = -1; //  digit not in [100 .. 999]
    if ((i3 >= 100) && (i3 <= 999))
    {
        res =  (i3 / 100) % 10;
    }
    return res;
}

Console.Write($" input large number  [100 .. 999] : ");
int i10 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" {i10}  Show Second Digit  is : {ShowSecondDigit(i10)} ");


/*
Задача 13: Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.  третье слева
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

void ShowThirdDigit(int iN) 
{
    Console.Write($"  digit {iN} -> ");
    int res = -1; //  digit iN < 99  !!! iN > 0
    while (iN >= 1000)
    {
        iN /= 10;
    }
    res = iN % 10;

    if (res  > -1) 
        Console.WriteLine($" {res}");
    else 
        Console.WriteLine($" третьей цифры нет.");
}

Console.Write($" input large number  > 100 : ");
int i13 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" {i13}  third digit is :");
ShowThirdDigit(i13); 

/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да     7 -> да     1 -> нет
*/

bool IsHoliday(int dayOfWeek) // monday(понедельник)  = 1 .. sunday(воскресенье) = 7
{
    return (dayOfWeek > 5) && (dayOfWeek < 8); 
}

Console.Write($" input day of week [1..7] : ");
int i15 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" {i15}  is holiday  : {IsHoliday(i15)} ");
