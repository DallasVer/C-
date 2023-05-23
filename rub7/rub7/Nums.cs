using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rub7
{
    //Зад. 3
    internal class Nums
    {
        private int num1;
        private int num2;
        public int Zna1
        {
            get
            { return this.num1; }
            set
            { this.num1 = value; }
        }

        public int Zna2
        {
            get
            { return this.num2; }
            set
            { this.num2 = value; }
        }
        public Nums()
        {
            Zna1 = 4;
            Zna2 = 5;
        }

        public void Entering()
        {
            Console.WriteLine($" Первое число = {Zna1} \n Второе число = {Zna2}");
        }

        public void more()
        {
            if (Zna1 > Zna2)
            {
                Console.WriteLine($" Число {Zna1} больше числа {Zna2}");
            }
            else if (Zna1 < Zna2)
            {
                Console.WriteLine($" Число {Zna2} больше числа {Zna1}");
            }
            else
            {
                Console.WriteLine("Они индифферентны");
            }
        }
    }
}
