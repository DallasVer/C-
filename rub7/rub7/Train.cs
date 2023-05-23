using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rub7
{
    //Зад. 2
    internal class Train
    {
        public string Punkt;
        public int num;
        public string Time;

        public Train(string Punkt, int num, string Time)
        {
            this.Punkt = Punkt;
            this.num = num;
            this.Time = Time;
        }

        public int Number { get { return num; } }

        public string rezultat()
        {
            return ("Пункт назначения:" + Punkt + " \nНомер поезда:" + num + "\nВремя отправления:" + Time);
        }
    }
}
