using System;
using System.Collections.Generic;

namespace _6_Collections4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            List<string> fullName = new() { "Петров Пётр Иванович", "Целиков Павел Сергеевич", "Смирнов Николай Николаевич" };
            List<string> position = new() { "Грузчик", "Водитель", "Программист" };
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
                        AddDossier(fullName, position);
                        break;
                    case CommandOutputAllDossiers:
                        OutputAllDossiers(fullName, position);
                        break;
                    case CommandDeleteDossier:
                        DeleteDossier(fullName, position);
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

        static void AddDossier(List<string> fullName, List<string> position)
        {
            Console.Write("Введите ФИО: ");
            fullName.Add(Console.ReadLine());
            Console.WriteLine("ФИО добавлено!");

            Console.Write("Введите должность: ");
            position.Add(Console.ReadLine());
            Console.WriteLine("Досье добавлено!");
        }

        static void ShowDossier(List<string> fullName, List<string> position)
        {
            for (int i = 0; i < fullName.Count; i++)
            {
                if (i != 0)
                {
                    Console.WriteLine(i + " " + fullName[i] + " " + position[i]);
                }
                else
                {
                    Console.WriteLine("  " + fullName[i] + " " + position[i]);
                }
            }
        }

        static void DeleteDossier(List<string> fullName, List<string> position)
        {
            Console.Write("Введите номер досье для удаления: ");
            string userInput = Console.ReadLine();
            bool isSuccess = int.TryParse(userInput, out int dossierNumber);

            if (isSuccess)
            {
                if (dossierNumber < fullName.Count && dossierNumber >= 0)
                {
                    fullName.RemoveAt(dossierNumber);
                    position.RemoveAt(dossierNumber);
                    Console.WriteLine("Досье удалено!");
                }
                else
                {
                    Console.WriteLine("Ошибка. Попробуйте ещё раз");
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

        static void OutputAllDossiers(List<string> fullName, List<string> position)
        {
            Console.Clear();
            ShowMenu();
            ShowDossier(fullName, position);
        }
    }
}
