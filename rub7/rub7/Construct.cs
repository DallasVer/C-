using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rub7
{
    //Зад 5.
    internal class Construct
    {
        public int Const1 { get; set; }
        public int Const2 { get; set; }


        public Construct(int Const1, int Const2)
        {
            this.Const1 = Const1;
            this.Const2 = Const2;
        }

        ~Construct()
        {
            Console.WriteLine($" Данные {Const1} и {Const2} были удалены.");
        }
    }
}
