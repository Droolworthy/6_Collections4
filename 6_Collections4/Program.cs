using System;
using System.Collections.Generic;

namespace _6_Collections4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            List<string> fio = new() { "Фамилия Имя Отчество", "Смирнов Николай Николаевич", "Петров Пётр Иванович", "Целиков Павел Сергеевич" };
            List<string> position = new() { "Должность", "Программист", "Грузчик", "Водитель" };
            bool isExitApp = true;

            Console.Clear();
            ShowMenu();

            while (isExitApp)
            {
                Console.Write("Ввод: ");
                userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        AddDossier(fio, position);
                        break;
                    case 2:
                        OutputAllDossiers(fio, position);
                        break;
                    case 3:
                        DeleteDossier(fio);
                        break;
                    case 4:
                        isExitApp = false;
                        break;
                }
            }
        }
            
        static void AddDossier(List<string> fio, List<string> position)
        {
            Console.Write("Добавьте досье: ");
            fio.Add(Console.ReadLine());
            Console.WriteLine("Досье добавлено!");

            Console.Write("Добавьте должность: ");
            position.Add(Console.ReadLine());
            Console.WriteLine("Досье добавлено!");
        }

        static void ShowDossier(List<string> fio, List<string> position)
        {
            for(int i = 0; i < fio.Count; i++)
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

        static void DeleteDossier(List<string> fio)
        {
            Console.Write("Для удаление досье введите номер: ");
            fio.RemoveAt(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Досье удалено!");
        }

        static void ShowMenu()
        {
            Console.WriteLine("==========M--------Е---------Н--------Ю============");
            Console.WriteLine("|||||||||-------1)ДОБАВИТЬ ДОСЬЕ---------||||||||||");
            Console.WriteLine("|||||||||-----2)ВЫВЕСТИ ВСЁ ДОСЬЕ--------||||||||||");
            Console.WriteLine("|||||||||-------3)УДАЛИТЬ ДОСЬЕ----------||||||||||");
            Console.WriteLine("|||||||||___________4)ВЫХОД______________||||||||||");
        }

        static void OutputAllDossiers(List<string> fio, List<string> position)
        {
            Console.Clear();
            ShowMenu();
            ShowDossier(fio, position);
        }
    }
}
