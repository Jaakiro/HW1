// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


// bool Week (int num)
// {
//     if (num >=6 && num <=7)
//     {
//         return true;        
//     }
//     else
//     {
//         return false;
//     }    
// }
// System.Console.WriteLine ("Input num: ");
// int num = Convert.ToInt32(Console.ReadLine());
// bool result = Week(num);
// System.Console.WriteLine(result);


// Задача 13:Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string x = Convert.ToString(num);
// if (num >= 100 && num <=99999999)
// {
// System.Console.WriteLine($"{x[2]}");
// }
// else
// {
//     Console.WriteLine("No third number");
// }




// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// System.Console.WriteLine ("Input first num: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string x = Convert.ToString(num); // что бы найти искомую цифру в числе по index нужен string
// System.Console.WriteLine($"{x[1]}");
