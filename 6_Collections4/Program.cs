using System;
using System.Collections.Generic;

namespace _6_Collections4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            List<string> fio = new() { "Фамилия Имя Отчество", "Смирнов Николай Николаевич", "Петров Пётр Иванович", "Целиков Павел Сергеевич" };
            List<string> position = new() { "Должность", "Программист", "Грузчик", "Водитель" };
            const string CommandAddDossier = "add";
            const string CommandOutputAllDossiers = "output";
            const string CommandDeleteDossier = "delete";
            const string CommandExit = "exit";
            bool isWorking = true;

            Console.Clear();
            ShowMenu();

            while (isWorking)
            {
                Console.Write("Введите команду: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandAddDossier:
                        AddDossier(fio, position);
                        break;
                    case CommandOutputAllDossiers:
                        OutputAllDossiers(fio, position);
                        break;
                    case CommandDeleteDossier:
                        DeleteDossier(fio, position);
                        break;
                    case CommandExit:
                        isWorking = false;
                        break;
                    default:
                        Console.WriteLine($"Введите {CommandAddDossier}, {CommandOutputAllDossiers}, {CommandDeleteDossier} или {CommandExit}"); 
                        break;
                }
            }
        }

        static void AddDossier(List<string> fio, List<string> position)
        {
            Console.Write("Введите ФИО: ");
            fio.Add(Console.ReadLine());
            Console.WriteLine("ФИО добавлено!");

            Console.Write("Введите должность: ");
            position.Add(Console.ReadLine());
            Console.WriteLine("Досье добавлено!");
        }

        static void ShowDossier(List<string> fio, List<string> position)
        {
            for (int i = 0; i < fio.Count; i++)
            {
                if (i != 0)
                {
                    Console.WriteLine(i + " " + fio[i] + " " + position[i]);
                }
                else
                {
                    Console.WriteLine("  " + fio[i] + " " + position[i]);
                }
            }
        }

        static void DeleteDossier(List<string> fio, List<string> position)
        {
            Console.Write("Введите номер досье для удаления: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < fio.Count; i++)
            {
                if (i == userInput)
                {
                    fio.RemoveAt(userInput);
                    position.RemoveAt(userInput);
                    Console.WriteLine("Досье удалено!");      
                }
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("==========M--------Е---------Н--------Ю============");
            Console.WriteLine("|||||||||||-----add - ДОБАВИТЬ ДОСЬЕ---||||||||||||");
            Console.WriteLine("|||||||||||-output - ВЫВЕСТИ ВСЁ ДОСЬЕ-||||||||||||");
            Console.WriteLine("|||||||||||--- delete - УДАЛИТЬ ДОСЬЕ--||||||||||||");
            Console.WriteLine("|||||||||||________exit - ВЫХОД________||||||||||||");
        }

        static void OutputAllDossiers(List<string> fio, List<string> position)
        {
            Console.Clear();
            ShowMenu();
            ShowDossier(fio, position);
        }
    }
}
