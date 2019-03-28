using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFarm
{
    class Sheep : Animal
    {
        public override void Name()
        {
            Console.WriteLine("My name is jose");
        }
        public override void Speak()
        {
            Console.WriteLine("I say Baa Baaaa");
        }
        public override void Job()
        {
            Console.WriteLine("I get shaved and make whool");
        }
        public override void Eat()
        {
            Console.WriteLine("I eat vegetables");
        }
        public override void Sleep()
        {
            Console.WriteLine("I sleep for only about 4 hours a day");
        }



    }
}
