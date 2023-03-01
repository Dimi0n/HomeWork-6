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
