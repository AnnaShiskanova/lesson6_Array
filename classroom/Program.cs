Console.Clear();
Console.WriteLine("1 - Task 39");
Console.WriteLine("2 - Task 40");
Console.WriteLine("3 - Task 42_var1");
Console.WriteLine("4 - Task 42_var2");
Console.WriteLine("5 - Task 44");
Console.WriteLine("6 - Task 45");
int NumberOfTask = Prompt("Введите номер задачи");
switch(NumberOfTask)
{
    case 1:
    Console.Clear();
    Task39();
    break;

    case 2:
    Console.Clear();
    Task40();
    break;

    case 3:
    Console.Clear();
    Task42_var1();
    break;

    case 4:
    Console.Clear();
    Task42_var2();
    break;

    case 5:
    Console.Clear();
    Task44();
    break;

    case 6:
    Console.Clear();
    Task45();
    break;
    default:
    Console.WriteLine("Номер задачи введен неверно");
    break;
    
}

static int Prompt(string massage)//метод запроса числа
{
    Console.WriteLine(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


static void Task39()

{//Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

int[] GenerateArray(int Lenght)
{
    int[] array = new int[Lenght];
    for (int i = 0; i < Lenght; i++)
    {
        array[i] = new Random().Next(-10,11);//берем любой интервал, потому что иное не сказанов задании
        
    }
    return array;
}

 int[] ReverseArray(int[] array)//берем массив, который вернулис первой функции
 {
    for (int i = 0; i < array.Length /2; i++)// /2 чтобы сравнивать попарно элементы
    {
        int tmp = array[i];
        array[i] = array[array.Length - 1 - i];// длина всегда возвращает больше индекса на 1
       array[array.Length - 1 - i] = tmp;
    }
    return array;
 }  

 int[] AnotherReverseArray(int[] array)
{
int[] tmpArray = new int[array.Length];
for (int i = 0; i < array.Length; i++)
tmpArray[i] = array[array.Length - 1 - i];
return tmpArray;
} 
 

 void PrintArray(int[]array)
 {
    Console.WriteLine(String.Join(" ", array));
 }

    int[] array = GenerateArray(10);
    PrintArray(array);
    PrintArray(ReverseArray(array));
    PrintArray(AnotherReverseArray(array));
}

static void Task40()
{
    //     Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
    // может ли существовать треугольник с сторонами такой длины.
    // Теорема о неравенстве треугольника: 
    // каждая сторона треугольника меньше суммы двух других сторон.
    Console.WriteLine("Input number a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number b: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number c: ");
    int c = Convert.ToInt32(Console.ReadLine());
    
    if (a + b > c && a + c > b && b +c >a)
    Console.WriteLine("the triangle exists");
    else   
    Console.WriteLine("the triangle does not exist");



}

static void Task42_var1()
{
    // Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
    Console.WriteLine("Input number: ");
    int numb = Convert.ToInt32(Console.ReadLine());
    string numbs = string.Empty;

    while (numb > 0)
    {
        numbs = numb % 2 + numbs;
        numb = numb / 2;
    }

    System.Console.WriteLine(numbs);

}

static void Task42_var2()
{
    Console.WriteLine("Input number: ");
    int numb = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    int tmpNumb = numb;

    while (tmpNumb > 0)
    {
        tmpNumb = tmpNumb / 2;
        count++;
    }

    string[] numbs = new string[count];
    for (int i = 0; i < count; i++, numb = numb / 2)
    {
        numbs[i] += numb % 2; 
    }

    string[] RevertArray(string[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            string tmp = array[i];
            array[i] = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = tmp;
        }

        return array;
    }
    string[] trueNumb = RevertArray(numbs);
    Console.WriteLine(String.Join("", trueNumb));
}


static void Task44()
{
    // Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
    //Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

    Console.Write("Enter the number of Fibonacci numbers: ");
    int n = int.Parse(Console.ReadLine());

    int a = 0;
    int b = 1;
    int c;

    Console.Write(a + " " + b + " ");

    for (int i = 2; i < n; i++)
    {
    c = a + b;
    a = b;
    b = c;

    Console.Write(c + " ");
    }

    Console.WriteLine();
     
}

static void Task45()
{
    // Задача 45: Напишите программу, которая будет создавать копию заданного массива 
    //с помощью поэлементного копирования.

    int[] array = GenerateArray(10);

    int[] GenerateArray(int Lenght)
    {
    int[] array = new int[Lenght];
    for (int i = 0; i < Lenght; i++)
    {
        array[i] = new Random().Next(-10,11);//берем любой интервал, потому что иное не сказанов задании
        
    }
    return array;
    }   

    int[] CopyArray (int[] array )
    {
        int[] arrayCopy = new int [array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            arrayCopy[i] = array[i];
        }
        return arrayCopy;
    }

    void PrintArray(int[]array)
 {
    Console.WriteLine(String.Join(" ", array));
 }

 PrintArray(array);
 PrintArray(CopyArray(array));
 Console.WriteLine(array == array);
 Console.WriteLine(array == CopyArray(array));
 

// int[] copyArray = new int[array.Length];

// for (int i = 0; i < array.Length; i++)
// {
// copyArray[i] = array[i];
// }

// Console.WriteLine("Original array:");
// foreach (int num in array)
// {
// Console.Write(num + " ");
// }

// Console.WriteLine("\nCopied array:");
// foreach (int num in copyArray)
// {
// Console.Write(num + " ");
// }

// Console.WriteLine();


}
