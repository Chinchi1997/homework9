// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// using System;
// class RecExercise1
// {
//     static int printNatural(int ctr, int stval)
//     {
//         if(ctr < 1)
//         {
//             return stval;
//         }

//         Console.Write("{0}",ctr);
//         ctr--;
//         return printNatural(ctr,stval);
//     }
//     static void Main()
//     {
//     Console.Clear();
//     Console.Write("Введите число: "); 
//     int ctr = Convert.ToInt32(Console.ReadLine());
//     printNatural(ctr,1);
//     Console.WriteLine("\n\n");

//     }
// }



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

 int Ackermann(int m, int n) 
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
  
    Console.Clear();
    Console.Write("Введите число: "); 
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число: "); 
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Ackermann(m, n));
