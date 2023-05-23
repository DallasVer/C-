using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rub7
{
    //Зад. 4
    internal class Counter
    {
        public int Now { get; set; }
        public int Rand { get; set; }
        public int min { get; set; }
        public int max { get; set; }

        public Counter()
        {
            Now = 0;
            Random rand = new Random();
            Rand = rand.Next(0, 20);
            min = 0;
            max = 20;
        }
        public void Up()
        {
            Now++;
            Console.WriteLine(Now);
        }
        public void Down()
        {
            Now--;
            Console.WriteLine(Now);
        }
    }
}
