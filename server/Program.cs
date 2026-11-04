using System;

class Program {
    static void Main() {
        string n = "Резник Анжелика Ильинична";
        string g= "ИСП-242";
        
        Console.WriteLine("Добро пожаловать в анкету лабы 4!");
        Console.WriteLine($"Разработчик: {n}");
        Console.WriteLine($"Группа: {g}");
        Console.WriteLine($"Дата запуска: {DateTime.Now}");
        Console.WriteLine();

        Console.Write("Введите номер команды (1 - ФИО, 2 - Группа, 3 - Выход): ");
        string choice = Console.ReadLine();

        if (choice == "1") {
            Console.WriteLine($"Студент: {n}");
        } 
        else if (choice == "2") {
            Console.WriteLine($"Учебная группа: {g}");
        } 
        else {
             Console.WriteLine("Программа завершена.");
        }
    }
}
