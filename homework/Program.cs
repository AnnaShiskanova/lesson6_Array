
static void Task41()
{
    // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел
    // больше 0 ввёл пользователь.
    // 0, 7, 8, -2, -2 -> 2
    // 1, -7, 567, 89, 223-> 3
   Console.WriteLine("enter some numbers: ");
   string[] msg = Console.ReadLine().Split(" ");
   int[] numbers = Array.ConvertAll(msg, s => int.Parse(s));
  
   
   int count = 0;
   foreach (int el in numbers)
   {
   if (el > 0)
   count++;
   }
   Console.WriteLine($"{(String.Join(" ", numbers))} -> {count} > 0");
   


}



















Task41();

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)