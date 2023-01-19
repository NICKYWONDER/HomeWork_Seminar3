// Задача 1

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Проверка на пятизначность обязательна

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Решение:

// Console.Write("Введите пятизначное число: ");
// int number = int.Parse(Console.ReadLine()!);
// string StrNumber = number.ToString();
//     if(StrNumber.Length ==5){
//         if(StrNumber[0] == StrNumber[4] && StrNumber[1] == StrNumber[3] ){
//             Console.WriteLine("Да! Палиндром");
//         }
//         else{
//             Console.WriteLine("Нет! Не Палиндром");
//         }
//     }
//     else{
//         Console.WriteLine("Неверное число, введите пятизначное!");
//     }
// // __________________________________________________________________________________________________________________________________
// Задача 2

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Решение:

// Console.WriteLine("Введите X1: ");
// int Xa = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите Y1: ");
// int Ya = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите Z1: ");
// int Za = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите X2: ");
// int Xb = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите Y2: ");
// int Yb = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите Z2: ");
// int Zb = int.Parse(Console.ReadLine()!);
// double c = Math.Sqrt(Math.Pow(Xa - Xb, 2) + Math.Pow(Ya - Yb, 2) + Math.Pow(Za - Zb, 2));

//     Console.WriteLine($"c={c:f3}");

// __________________________________________________________________________________________________________________________________
// Задача 3

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// // Решение:

// Console.WriteLine ("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);
//     for(int i = 1; i < N; i++){
//         Console.WriteLine($"{Math.Pow(i, 3)} ");
//     }