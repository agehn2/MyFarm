using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFarm
{
    class Horse : Animal
    {
        public override void Name()
        {
            Console.WriteLine("My name is Sabrina");
        }
        public override void Speak()
        {
            Console.WriteLine("I say Neighhhhhhhh!");
        }
        public override void Job()
        {
            Console.WriteLine("I help pull heavy things");
        }
        public override void Eat()
        {
            Console.WriteLine("I eat grain, and breads.. but i really like Apples when a human brings me one!");
        }
        public override void Sleep()
        {
            Console.WriteLine("I only sleep about 3 hours a day, i dont get tired often");
        }






    }
}
