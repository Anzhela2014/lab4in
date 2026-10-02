using System;
class Program {
    static void Main() {
        string f = "Резник Анжелика Ильинична"; string g = "ИСП-242";
        Console.WriteLine($"Разработчик: {f}\nГруппа: {g}\nДата: {DateTime.Now}\n");
        Console.WriteLine("=== МЕНЮ ===\n1 - Показать ФИО\n2 - Показать группу\n3 - Показать дату\n4 - Выход");
        while(true) {
            Console.Write("Выбери пункт: ");
            string c = Console.ReadLine();
            if(c=="1") Console.WriteLine($"\n[ФИО]: {f}\n");
            else if(c=="2") Console.WriteLine($"\n[Группа]: {g}\n");
            else if(c=="3") Console.WriteLine($"\n[Дата]: {DateTime.Now}\n");
            else if(c=="4") { Console.WriteLine("Выход."); break; }
            else Console.WriteLine("Нет такого пункта.");
        }
    }
}
