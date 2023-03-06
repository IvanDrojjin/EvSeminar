// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Загрузите домашнее задание на проверку до 13 марта, 20:00 +03:00 UTC
Это задание для самостоятельной работы, без оценки преподавателя
https://gb.ru/lessons/305489/homework

Урок 4. Функции
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

double promtDbl(string str)
{
    Console.Write( $"Введите {str} :");
    double res = Convert.ToDouble(Console.ReadLine());
    return res;
}

int promtInt(string str)
{
    Console.Write( $"Введите {str} :");
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

string str25 = " Задача 25: Напишите цикл, который принимает на вход \n"+
"два числа (A и B) и возводит число A в натуральную степень B.\n" ;
Console.WriteLine($" {str25} ");

int iA = promtInt("число A");
int iB = promtInt("число B");

double iAB = Math.Pow(iA, iB);
Console.WriteLine($" A^B  {iA}^{iB} = {iAB} \n\n");


/* 
Задача 27: Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int  SummDigit(int iIn)
{
    int iSumm = 0,   iCount = 1;
    while (iIn > 0)
    {
        iSumm += iIn % 10;
        iIn /= 10;
    }
    return iSumm;
}

string str27 = "Задача 27: Напишите программу, которая принимает на вход \n"
 +"число и выдаёт сумму цифр в числе. \n";
Console.WriteLine($" {str27} ");
int iC = promtInt(" число ");
Console.WriteLine($" {iC}  сумма чисел : {SummDigit(iC)}");

/* 
Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
!!! ввод длины массива с клавиатуры
*/

int[] FillArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}

int[] FillArray0(int size)
{
    int[] arr = new int[size];

    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = promtInt($" элемент массива [{i}]");
    }
    return arr;
}

string str29 = "Задача 29: Напишите программу, которая задаёт массив \n " 
    + " из N элементов и выводит их на экран. \n";
Console.WriteLine($"\n\n {str29} ");
int iN = promtInt("длину массива N");
int[] arr29 = new int[iN];

arr29 = FillArray0(iN);
Console.WriteLine($"[{string.Join(", ", arr29)}]  \n");

Console.WriteLine("Hello, World!  https://gb.ru/lessons/305489/homework");
