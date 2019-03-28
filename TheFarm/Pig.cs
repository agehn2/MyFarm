using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFarm
{
    class Pig : Animal
    {
        public override void Name()
        {
            Console.WriteLine("My name is Sausage");
        }
        public override void Speak()
        {
            Console.WriteLine("I say OINK OINK!");
        }
        public override void Job()
        {
            Console.WriteLine("My job is to get fat so i can be bacon eventually!");
        }
        public override void Eat()
        {
            Console.WriteLine("I eat anything!");
        }
        public override void Sleep()
        {
            Console.WriteLine("I sleep for 11 hours a day if i can!");
        }
    }
}
