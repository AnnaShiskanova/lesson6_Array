
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

static void Task43()
{
    // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
    //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
    //задаются пользователем.
    // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

    Console.Write("Введите k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    
    
    var x = -(b1 - b2) / (k1 - k2);
    var y = k1 * x + b1;
    
    x = Math.Round(x, 3);//округление до 3 знаков после ","
    y = Math.Round(y, 3);
    
    Console.WriteLine($"Пересечение в точке: ({x};{y})");
}



















//Task41();
Task43();

