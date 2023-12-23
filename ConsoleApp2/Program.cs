using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("░█▀▄░█▀█░█▀█░█▀▄░█▀█░█▄█░▀█▀░█▀█░▀█▀\r\n░█▀▄░█▀█░█░█░█░█░█░█░█░█░░█░░█░█░░█░\r\n░▀░▀░▀░▀░▀░▀░▀▀░░▀▀▀░▀░▀░▀▀▀░▀░▀░░▀░");

            int value = 0;
            int userInput;
            int attempts = 0;
            int max_attempts = 0;
            int difficult;
            
            string difficultAnswer;

            bool userAnswer_attempts = false;
            

            while (true) {
                
                Console.Write("Вы готовы начать? Нажмите любую кнопку на клавиатуре для продолжения... ");
                Console.ReadKey();
                Console.Clear();
                while (true) { 
                    Console.WriteLine("░█▀▄░█▀█░█▀█░█▀▄░█▀█░█▄█░▀█▀░█▀█░▀█▀\r\n░█▀▄░█▀█░█░█░█░█░█░█░█░█░░█░░█░█░░█░\r\n░▀░▀░▀░▀░▀░▀░▀▀░░▀▀▀░▀░▀░▀▀▀░▀░▀░░▀░");
                    Console.Write($"\nДоступные сложности игры:\n" +
                        $"1 - Лёгкая    (Диапазон от 0 до 100)\n" +
                        $"2 - Средняя   (Диапазон от 0 до 1000)\n" +
                        $"3 - АРМАГЕДОН (Диапазон от 0 до 10000) \n" +
                        $"4 - Ты читер  (Диапазон от 0 до 15000 и ограничение в 10 попыток)\n\n" +
                        $"Введите код сложности: ");
                    difficultAnswer = Console.ReadLine();

                    if (!int.TryParse(difficultAnswer, out difficult) || difficultAnswer == null || difficult <= 0 || difficult > 4)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Ошибка: Неккоректно введено значение.");
                        Console.ResetColor();
                        Console.WriteLine("Нажмите на любую клавишу, для повторного ввода...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        break;
                    }
                }
                Console.Clear();


                
                switch (difficult)
                {
                    case 1:
                        Console.WriteLine("░█▀▄░█▀█░█▀█░█▀▄░█▀█░█▄█░▀█▀░█▀█░▀█▀\r\n░█▀▄░█▀█░█░█░█░█░█░█░█░█░░█░░█░█░░█░\r\n░▀░▀░▀░▀░▀░▀░▀▀░░▀▀▀░▀░▀░▀▀▀░▀░▀░░▀░");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n1 - Лёгкая    (Диапазон от 0 до 100)");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("2 - Средняя   (Диапазон от 0 до 1000)");
                        Console.WriteLine("3 - АРМАГЕДОН (Диапазон от 0 до 10000)");
                        Console.WriteLine("4 - Ты читер  (Диапазон от 0 до 15000 и ограничение в 10 попыток)");
                        Console.ResetColor();
                        value = rand.Next(0, 100);
                        break;

                    case 2:
                        Console.WriteLine("░█▀▄░█▀█░█▀█░█▀▄░█▀█░█▄█░▀█▀░█▀█░▀█▀\r\n░█▀▄░█▀█░█░█░█░█░█░█░█░█░░█░░█░█░░█░\r\n░▀░▀░▀░▀░▀░▀░▀▀░░▀▀▀░▀░▀░▀▀▀░▀░▀░░▀░");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("\n1 - Лёгкая    (Диапазон от 0 до 100)");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("2 - Средняя   (Диапазон от 0 до 1000)");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("3 - АРМАГЕДОН (Диапазон от 0 до 10000)");
                        Console.WriteLine("4 - Ты читер  (Диапазон от 0 до 15000 и ограничение в 10 попыток)");
                        Console.ResetColor();
                        value = rand.Next(0, 1000);
                        break;


                    case 3:
                        Console.WriteLine("░█▀▄░█▀█░█▀█░█▀▄░█▀█░█▄█░▀█▀░█▀█░▀█▀\r\n░█▀▄░█▀█░█░█░█░█░█░█░█░█░░█░░█░█░░█░\r\n░▀░▀░▀░▀░▀░▀░▀▀░░▀▀▀░▀░▀░▀▀▀░▀░▀░░▀░");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("\n1 - Лёгкая    (Диапазон от 0 до 100)");
                        Console.WriteLine("2 - Средняя   (Диапазон от 0 до 1000)");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("3 - АРМАГЕДОН (Диапазон от 0 до 10000)");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("4 - Ты читер  (Диапазон от 0 до 15000 и ограничение в 10 попыток)");
                        Console.ResetColor();
                        value = rand.Next(0, 10000);
                        break;

                    case 4:
                        Console.WriteLine("░█▀▄░█▀█░█▀█░█▀▄░█▀█░█▄█░▀█▀░█▀█░▀█▀\r\n░█▀▄░█▀█░█░█░█░█░█░█░█░█░░█░░█░█░░█░\r\n░▀░▀░▀░▀░▀░▀░▀▀░░▀▀▀░▀░▀░▀▀▀░▀░▀░░▀░");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("\n1 - Лёгкая    (Диапазон от 0 до 100)");
                        Console.WriteLine("2 - Средняя   (Диапазон от 0 до 1000)");
                        Console.WriteLine("3 - АРМАГЕДОН (Диапазон от 0 до 10000)");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("4 - Ты читер  (Диапазон от 0 до 15000 и ограничение в 10 попыток)\n");
                        Console.ResetColor();
                        value = rand.Next(0, 15000);
                        max_attempts = 10;
                        userAnswer_attempts = true;
                        break;
                }

                if (difficult != 4)
                {
                    Console.Write("\nХотите добавить рандомное ограничение попыток? (от 5 до 30) (Y - да, N - нет) ");
                    if (Console.ReadLine() == "y") 
                    {

                        
                        max_attempts = rand.Next(5, 30);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Ваше ограничение попыток - " + max_attempts);
                        Console.ResetColor();
                        userAnswer_attempts = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Игра без ограничения попыток.");
                        Console.ResetColor();
                        userAnswer_attempts = false;
                    }
                }

                Console.Write("Нажмите на любую клавишу для начала игры...");
                Console.ReadKey();
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Игра началась, удачи!");
                Console.ResetColor();
                while (true)
                {
                    Console.Write("Введите число: ");
                    if (int.TryParse(Console.ReadLine(), out userInput))
                    {

                        if (userInput > value)
                        {
                            Console.WriteLine("Рандомное число меньше.");
                            attempts++;

                            max_attempts--;



                            if (max_attempts > 0 && userAnswer_attempts == true)
                            {
                                Console.WriteLine($"Попыток осталось: {max_attempts}.");
                            }
                            else if (max_attempts <= 0 && userAnswer_attempts == true)
                            {
                                Console.Clear();
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Попытки закончились.");
                                Console.ResetColor();
                                Console.WriteLine($"Загаданное число — {value}");
                                break;
                            }

                        }


                        else if (userInput < value)
                        {
                            Console.WriteLine("Рандомное число больше.");
                            attempts++;
                            max_attempts--;
                            if (max_attempts > 0 && userAnswer_attempts == true)
                            {
                                Console.WriteLine($"Попыток осталось: {max_attempts}.");
                            }
                            else if (max_attempts <= 0 && userAnswer_attempts == true)
                            {
                                Console.Clear();
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Попытки закончились.");
                                Console.ResetColor();
                                Console.WriteLine($"Загаданное число — {value}");
                                break;
                            }
                        }

                        else if (userInput == value)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Вы выйграли, потратив {attempts} попыток.");
                            Console.ResetColor();
                            Console.WriteLine($"Загаданное число — {value}");
                            break;

                        }
                    } 
                    
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Неккоректно введено число!");
                        Console.ResetColor();

                        Console.Write("Нажмите любую клавишу для повторного ввода... ");
                        Console.ReadKey();
                        Console.Write("\n");
                        
                        
                    }

                    
                    
                }
            }

        }
          
    }
}
