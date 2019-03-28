using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFarm
{
    class Chicken : Animal
    {
        public override void Name()
        {
            Console.WriteLine("My name is Lotte");
        }
        public override void Speak()
        {
            Console.WriteLine("I say cluck cluck cluck");
        }
        public override void Job()
        {
            Console.WriteLine("I make Eggs");
        }
        public override void Eat()
        {
            Console.WriteLine("I eat seeds");
        }
        public override void Sleep()
        {
            Console.WriteLine("I sleep for as long as its dark");
        }

    }
}
