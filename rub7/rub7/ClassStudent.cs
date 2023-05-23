using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace rub7
{
    //Зад1
    internal class Student
    {
        public string FIO { get; set; }
        public string Data;
        public int Grup;
        public int[] Uspev = { 3, 4, 4, 5, 3 };
        public Student()
        {

            FIO = "Иван Иванович Иванов";
            Data = "01.01.2001";
            Grup = 123;
        }
        public void Print()
        {
            Console.WriteLine($" FIO: {FIO}. \n Дата рождения: {Data}. \n Группа: {Grup}.");
            Console.Write($" Оценки:");
            foreach (int i in Uspev)
            {
                Console.Write($" {i},");
            }
            Console.WriteLine(" ");
        }
    }
}
