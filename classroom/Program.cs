Console.Clear();
Console.WriteLine("1 - Task 39");
Console.WriteLine("2 - Task 40");
Console.WriteLine("3 - Task 42");
Console.WriteLine("4 - Task 35");
Console.WriteLine("5 - Task 37");
int NumberOfTask = Prompt("Введите номер задачи");
switch(NumberOfTask)
{
    case 1:
    Console.Clear();
    Task39();
    break;

    case 2:
    Console.Clear();
    //Task40();
    break;

    case 3:
    Console.Clear();
    Task42();
    break;

    // case 4:
    // Console.Clear();
    // Task35();
    // break;

    // case 5:
    // Console.Clear();
    // Task37();
    // break;

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

// static void Task40()
// {
//     //     Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
//     // может ли существовать треугольник с сторонами такой длины.
//     // Теорема о неравенстве треугольника: 
//     // каждая сторона треугольника меньше суммы двух других сторон.

//     int a;
//     int b;
//     int c;
//     int Sum1 = a + b;
//     int Sum2 = b + c;
//     int Sum3 = a + c;
//     if (Sum1<Sum2 && Sum1<Sum3 && Sum2<Sum3)
//     true;



// }

static void Task42()
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
