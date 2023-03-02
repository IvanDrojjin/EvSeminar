// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

Console.Write("Введи любое число X: ");
int nX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи любое число Y: ");
int nY = Convert.ToInt32(Console.ReadLine());
int nChetv = 1;

if (nX > 0 && nY > 0 ) { nChetv = 1;}
else if (nX < 0 && nY > 0 ) { nChetv = 2;}
else if (nX < 0 && nY < 0 ) { nChetv = 3;}
else if (nX > 0 && nY < 0 ) { nChetv = 4;}  
else  { // nChetv = -1;
      Console.WriteLine(" Точка лежит на оси1..");
      return;
}
Console.WriteLine($"Точка лежит в {nChetv} четверти..");





string[] quartes = {"X > 0 && Y > 0", "X < 0 && Y > 0",
                    "X < 0 && Y < 0", "X > 0 && Y < 0"};
Console.Write("Введи  номер четверти N: ");
int nQ = Convert.ToInt32(Console.ReadLine());
if (nQ < 5 && nQ > 0){
    Console.WriteLine($" {quartes[nQ-1]} ");
} else {

    Console.WriteLine($" {nQ}  неправильная четверть ... ");
}

/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21


double number = 5;

// double res = Math.Pow(number, 2); // возведение в степень
// System.Console.WriteLine(res);

double res = Math.Sqrt(number); // извлечение квадратного корня
res = Math.Round(res, 3); // округление
System.Console.WriteLine(res);
*/

Console.Write("Введи  целое  число X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введи  целое  число Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введи  целое  число X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введи  целое  число Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double  res  = Math.Pow((x1 - x2), 2) +   Math.Pow((y1 - y2), 2);
res =  Math.Sqrt(res);  // квадратный корень

res = Math.Round(res, 3);
Console.WriteLine($" расстояние между точками [{x1}, {y1}]  и  [{x2}, {y2}] : {res}");

 /*
 Напишите программу, которая принимает на вход число (N) и 
 выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
 */

Console.Write("Введи  целое  число N: ");
int nN = Convert.ToInt32(Console.ReadLine());


 Console.Write($" {nN} (квадраты) ->  ");
for (int i = 1; i < nN+1; i++)
{
    Console.Write($" {i * i}, ");
}

/*
double FindLengh (double x1,double x2,double y1,double y2)
{
  double result = Math.Sqrt(Math.Pow(x2 - x1,2)+ Math.Pow(y2 - y1,2));
  return result; 
}

Console.WriteLine("введите координату по оси Х первой точки");
double х1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату по оси y первой точки");
double y1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату по оси x второй точки");
double x2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату по оси y второй точки");
double y2=Convert.ToInt32(Console.ReadLine());

 double FindLengh2d=FindLengh(x1, x2, y1, y2);
System.Console.WriteLine ($"расстояние между точками = {FindLengh2d}");

*/



/*
https://gb.ru/lessons/305488/homework
Знакомство с языками программирования (семинары)
Урок 3. Базовые алгоритмы. Продолжение
Сдайте задание до: 9 марта, 20:00 +03:00 UTC

Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int promtI5()
{
    Console.Write( $"Введите пятизначное число :");
    int res = Convert.ToInt32 (Console.ReadLine());
    return res;
}

// int[] sepI5(int I5) {}

bool isPoliAndr(int[] digits, int nL)
{
    // bool res = false;
    for (int i = 0; i < nL / 2; i++)
    {
        if (digits[i] == digits[nL - 1 - i])
        { } else { 
            return false;
        }
    }
    return true;
}

Console.Write("Задача 21 ");
Console.WriteLine("");
int nL = 5;  // length of integer
int myInt = promtI5();

int myInt0 = myInt;

int[] digits =  new int[nL];  // int[] nums = new int[...];

for (int i = 0; i < nL; i++)
{
    digits[i] = myInt0 % 10;
    myInt0 /= 10;
}

Console.WriteLine($" {myInt}  полиандр : {isPoliAndr(digits, 5)}");



/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


double promtDbl(string str)
{
    Console.Write( $"Введите координату {str} :");
    double res = Convert.ToDouble(Console.ReadLine());
    return res;
}

double dist3(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double res = Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2);
    res =  Math.Sqrt(res);  // квадратный корень
    return res;
}

Console.Write("Задача 21 ");
Console.WriteLine("");

double x21 = promtDbl("X1");
double y21 = promtDbl("Y1");
double z21 = promtDbl("Z1");

double x22 = promtDbl("X2");
double y22 = promtDbl("Y2");
double z22 = promtDbl("Z2");

double  res21  = dist3( x21, y21, z21, x22, y22, z22);
res = Math.Round(res21, 3);
Console.WriteLine($" расстояние между точками [{x21}, {y21}, {z21}] и [{x22}, {y22}, {z22}] : {res}");
Console.WriteLine("");

/*
Задача 23
Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Задача 23 ");
Console.Write("Введи  целое  число N: ");
int nN23 = Convert.ToInt32(Console.ReadLine());

 Console.Write($" {nN23} (кубы) ->  ");
for (int i = 1; i < nN+1; i++)
{
    Console.Write($" {i * i * i}, ");
}
Console.WriteLine("");