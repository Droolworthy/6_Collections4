//В функциях вы выполняли задание "Кадровый учёт"
//Используя одну из изученных коллекций, вы смогли бы сильно себе упростить код выполненной программы, 
//ведь у нас данные, это ФИО и позиция.
//Поиск в данном задании не нужен.
//1) добавить досье
//2) вывести все досье (в одну строку через “-” фио и должность)
//3) удалить досье
//4) выход.
using System;
using System.Collections.Generic;

namespace _6_Collections4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandAddDossier = "add";
            const string CommandOutputAllDossiers = "output";
            const string CommandDeleteDossier = "delete";
            const string CommandExit = "exit";
            List<string> fullName = new() { "Петрова Пётра Ивановича", "Целикова Павла Сергеевича", "Смирнова Николай Николаевича" };
            List<string> position = new() { "Грузчика", "Водителя", "Программиста" };
            string userInput;
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
                        ShowDossier(fullName, position);
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
                Console.WriteLine(i + " " + fullName[i] + " " + position[i]);
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
            const string CommandAddDossier = "add";
            const string CommandOutputAllDossiers = "output";
            const string CommandDeleteDossier = "delete";
            const string CommandExit = "exit";

            Console.WriteLine("==========M--------Е---------Н--------Ю============");
            Console.WriteLine($"|||||||||||-----{CommandAddDossier} - ДОБАВИТЬ ДОСЬЕ---||||||||||||");
            Console.WriteLine($"|||||||||||-{CommandOutputAllDossiers} - ВЫВЕСТИ ВСЁ ДОСЬЕ-||||||||||||");
            Console.WriteLine($"|||||||||||--- {CommandDeleteDossier} - УДАЛИТЬ ДОСЬЕ--||||||||||||");
            Console.WriteLine($"|||||||||||________{CommandExit} - ВЫХОД________||||||||||||");
        }
    }
}
