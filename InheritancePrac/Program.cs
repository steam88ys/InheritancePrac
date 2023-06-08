using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    class Program
    {
        class Parent
        {
            public static int counter = 0;

            public Parent() { Console.WriteLine("Parent()"); }
            public Parent(int param) { Console.WriteLine("Parent(int param)"); }
            public Parent(String param) { Console.WriteLine("Parent(String param)"); }

            public void CountParent()
            {
                Parent.counter++;
            }
        }
        class Child:Parent
        {
            public void CountChild() { Child.counter++; }
            public Child():base(10)
            {
                Console.WriteLine("Child(): base(10)");
            }
            public Child(string input) : base(input)
            {
                Console.WriteLine("Child(string input): base(input)");
            }
        }

        static void Main(string[] args)
        {
            Child childA = new Child();
            Child childB = new Child("string");

            Dog d = new Dog();
            d.Public();
            // d.Protected();
            // d.Private();

            List<Animal> animals = new List<Animal>() { new Dog(), new Dog(), new Dog(), new Cat(), new Cat(), new Cat() };

            foreach (var item in animals)
            {
                item.Eat();
                item.Sleep();

                // as 방식
                Dog dog = item as Dog;
                if(dog != null)
                {
                    dog.Bark();
                }
                Cat cat = item as Cat;
                if (cat != null)
                {
                    cat.Meow();
                }

                // is 방식
                if (item is Dog)
                {
                    ((Dog)item).Bark();
                }else if(item is Cat)
                {
                    ((Cat)item).Meow();
                }

            }
        }
    }
}
