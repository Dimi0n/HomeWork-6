// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

System.Console.WriteLine("Введите длинну массива ");
int lenght = int.Parse(Console.ReadLine());
int []myArray = new int [lenght];

for (int i = 0; i < myArray.Length; i++)
{
    System.Console.WriteLine($"Введите число под индексом {i}");
    myArray[i] =int.Parse(Console.ReadLine());

}
  int[] myArray2 = Array.FindAll(myArray, i=>i>0);
  int myArray3 = myArray2.Length;
  System.Console.WriteLine();

System.Console.WriteLine($"Вы ввели вот столько: {myArray3} чисел больше 0");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");