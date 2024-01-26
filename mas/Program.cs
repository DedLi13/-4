// Задача 1: Напишите программу, которая бесконечно 
// запрашивает целые числа с консоли. 
// Программа завершается при вводе 
// символа ‘q’ или при вводе числа, 
// cумма цифр которого чётная.

// using System;
// class Program
// {
//     static bool IsEvenDigitSum(int number)
//     {
//         int digitSum = 0;
//         while (number != 0)
//         {
//             digitSum += number % 10;
//             number /= 10;
//         }
//         return digitSum % 2 == 0;
//     }

//     static void Main()
//     {
//         while (true)
//         {
//             Console.Write("Введите целое число или 'q' для выхода: ");
//             string userInput = Console.ReadLine();

//             if (userInput.ToLower() == "q")
//             {
//                 Console.WriteLine("Выход из программы.");
//                 break;
//             }

//             if (int.TryParse(userInput, out int num))
//             {
//                 if (IsEvenDigitSum(num))
//                 {
//                     Console.WriteLine($"Сумма цифр числа {num} чётная. Завершение программы.");
//                     break;
//                 }
//                 else
//                 {
//                     Console.WriteLine("Сумма цифр числа нечётная. Продолжайте ввод.");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Ошибка! Введите целое число или 'q' для выхода.");
//             }
//         }
//     }
// }

// Задача 2: Задайте массив заполненный случайными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Создаем массив случайных трехзначных чисел
//         int[] array = new int[10]; // Используем 10 элементов в качестве примера
//         Random random = new Random();

//         for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = random.Next(100, 1000);
//         }

//         // Выводим массив для наглядности
//         Console.WriteLine("Исходный массив:");
//         foreach (int num in array)
//         {
//             Console.Write(num + " ");
//         }
//         Console.WriteLine();

//         // Находим и выводим количество четных чисел в массиве
//         int evenCount = 0;
//         foreach (int num in array)
//         {
//             if (num % 2 == 0)
//             {
//                 evenCount++;
//             }
//         }

//         Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
//     }
// }

// Задача 3: Заполните массив на N 
// (вводится с консоли, не более 8) случайных целых 
// чисел от 0 до 9. Сформируйте целое число, которое 
// будет состоять из цифр из массива. Старший разряд 
// числа находится на 0-м индексе, младший – на последнем.
// Пример вы найдете в конце презентации к семинару.

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите размер массива (не более 8): ");
//         int n;

//         // Проверка корректности ввода размера массива
//         while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 8)
//         {
//             Console.WriteLine("Ошибка! Введите корректное число от 1 до 8.");
//             Console.Write("Введите размер массива (не более 8): ");
//         }

//         int[] array = new int[n];
//         Random random = new Random();

//         // Заполнение массива случайными целыми числами от 0 до 9
//         for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = random.Next(0, 10);
//         }

//         // Вывод массива для наглядности
//         Console.WriteLine("Исходный массив:");
//         foreach (int num in array)
//         {
//             Console.Write(num + " ");
//         }
//         Console.WriteLine();

//         // Формирование целого числа из цифр массива
//         int formedNumber = 0;
//         for (int i = 0; i < array.Length; i++)
//         {
//             formedNumber = formedNumber * 10 + array[i];
//         }

//         Console.WriteLine($"Сформированное целое число: {formedNumber}");
//     }
// }
