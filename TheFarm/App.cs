using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFarm
{
    class App
    {
        Horse horse;
        Pig pig;
        Chicken chicken;
        Sheep sheep;

        public void Run()
        {
            horse = new Horse();
            pig = new Pig();
            chicken = new Chicken();
            sheep = new Sheep();

            horse.Name();
            Console.WriteLine("I am a horse");
            horse.Speak();
            horse.Eat();
            horse.Sleep();
            

            Console.ReadKey();



        }


    }
}
        ////List<Horse> horseList = new List<Horse>();
        ////List<Pig> pigList = new List<Pig>();
        ////List<Chicken> chickenList = new List<Chicken>();
        //Horse horse;
        //Pig pig;
        //Chicken chicken;
        //Sheep sheep;
        //public void Run()
        //{
        //    CreateAnimal();
        //    Console.WriteLine($"My name is {horse.name}, I like to eat {horse.eat} and i say {horse.speak}, and my favorite thing to do is {horse.FavoriteThingToDo("run")}");
        //    Console.WriteLine($"My name is {horse.name}, I like to eat {horse.eat} and i say {horse.speak}, and my favorite thing to do is {horse.FavoriteThingToDo("run")}");
        //    Console.WriteLine($"My name is {horse.name}, I like to eat {horse.eat} and i say {horse.speak}, and my favorite thing to do is {horse.FavoriteThingToDo("run")}");
        //    Console.WriteLine($"My name is {sheep.name}, I like to eat {sheep.eat} and i say {sheep.speak}, and my favorite thing to do is {horse.FavoriteThingToDo("run")}");

        //    Console.ReadKey();
        //}

        //public void CreateAnimal()
        //{
        //   horse = new Horse("Sabrina", "hay", "neigh");
        //   pig = new Pig("Sausage","anything but i like me some corn","Oink Oink");
        //   chicken = new Chicken("Lotte","Grains and Seeds","Cluck Cluck Cluck");
        //    sheep = new Sheep("softy", "hay", "baaaaa");
        //}

