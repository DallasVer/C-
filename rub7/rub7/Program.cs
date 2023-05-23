using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;

namespace rub7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Зад1.
            /*Student nem = new Student();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Выберите пункт \n 1: Просмотреть существующие данные. \n 2: Изменить данные. \n 3: Закрыть меню");
                int res = Convert.ToInt32(Console.ReadLine());
                switch (res)
                {
                    case 1: nem.Print(); break;
                    case 2:
                        Console.WriteLine("Меню выбора: \n 1-изменить ФИО,\n 2-изменить дату рождения,\n 3-изменить группу, \n 4-выход из меню \n");
                        int izmen = Convert.ToInt32(Console.ReadLine());
                        switch (izmen)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Введите ФИО");
                                    nem.FIO = Console.ReadLine();
                                    Console.WriteLine($"новое ФИО: {nem.FIO}");
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("Введите дату");
                                    nem.Data = Console.ReadLine();
                                    Console.WriteLine($"новая дата: {nem.Data}");
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("Введите группу");
                                    nem.Grup = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine($"новая группа: {nem.Grup}");
                                    break;
                                }
                        }; break;
                    case 3: return;
                    default: Console.WriteLine("Данного меню не существует"); break;
                }
            }*/

            //Зад. 2 
            /*List<Train> bas = new List<Train>();
            string raz = null;

            bas.Add(new Train("Котёночкино", 456, "13:20"));
            bas.Add(new Train("Метронов", 100, "01:50"));
            bas.Add(new Train("City17", 036, "07:10"));
            bas.Add(new Train("Янов", 226, "01:50"));

            while (true)
            {
                Console.WriteLine("Выберите пункт \n 1: Вывести данные поезда. \n 2: Закрыть меню");
                int res = Convert.ToInt32(Console.ReadLine());
                switch (res)
                {
                    case 1:
                        Console.WriteLine("Введите номер поеда, информацию о котором вы хотите узнать.");
                        int name = Convert.ToInt32(Console.ReadLine());
                        foreach (Train Nums in bas)
                        {
                            if (Nums.Number == name)
                            {
                                raz = Nums.rezultat();
                            }
                        }
                        if (raz == null)
                        {
                            Console.WriteLine("Такого поезда нет.");
                        }
                        else
                        {
                            Console.WriteLine(raz);
                        }
                        raz = null;
                        break;
                    case 2:
                        return;
                }
            }*/

            //Зад. 3
            /*Nums rub = new Nums();
            while (true)
            {
                Console.WriteLine("Выберите пункт \n 1: Вывести на экран числа. \n 2: Изменить числа. \n 3: Найти сумму чисел \n 4: Найти наибольшее из чисел. \n 5: Закрыть меню.");
                int res = Convert.ToInt32(Console.ReadLine());
                switch (res)
                {
                    case 1:
                        rub.Entering();
                        break;
                    case 2:
                        Console.WriteLine("Введите первое значение");
                        rub.Zna1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе значение");
                        rub.Zna2 = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine($" Сумма чисел {rub.Zna1} и {rub.Zna2} = {rub.Zna1 + rub.Zna2}");
                        break;
                    case 4: rub.more(); break;
                    case 5: return;
                }
            }*/

            //Зад. 4
            /*Counter trick = new Counter();
            ConsoleKeyInfo key;

            Console.WriteLine("Инициализация счетчика '~~'\n 1: По умолчанию \n 2: Произвольное значение. \n 3: Выйти.");
            int res = Convert.ToInt32(Console.ReadLine());
            switch (res)
            {
                case 1:
                    Console.WriteLine("Введите первое значение");
                    trick.Now = int.Parse(Console.ReadLine());
                    break;
                case 2:
                    trick.Now = trick.Rand;
                    break;
                case 3: return;
            }
            while (true)
            {
                Console.WriteLine("Операции со счётчиком: \n 1: Знать текущее состояние \n 2: Работать со счётчиком. \n 3: Выйти.");

                res = Convert.ToInt32(Console.ReadLine());
                switch (res)
                {
                    case 1: Console.WriteLine(trick.Now); break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(" KeyUp ↑︎: Продвинуться вверх \n KeyDown ↓︎: Продвинуться вниз \n Escape: Выйти.");
                        key = Console.ReadKey(true);
                        switch (key.Key)
                        {
                            case ConsoleKey.DownArrow: trick.Down(); break;
                            case ConsoleKey.UpArrow: trick.Up(); break;
                            case ConsoleKey.Escape: break;
                        }
                        break;
                    case 3: return;
                }
            }*/

            //Зад. 5 
            static void Test()
            {
                Console.WriteLine("Напишите два новых свойства.");
                Console.WriteLine("Введите первое значение");
                var i = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе значение");
                var g = int.Parse(Console.ReadLine());
                Construct del = new Construct(i, g);
            }
            Test();
            Console.WriteLine("1: Удалить оба пункта.");
            int res = Convert.ToInt32(Console.ReadLine());
            if (res == 1)
            {
                GC.Collect();
            }
            Console.ReadKey();
        }
    }
}