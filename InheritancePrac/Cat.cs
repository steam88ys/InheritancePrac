using System;

namespace InheritancePrac
{
    internal class Cat : Animal
    {
        public int Age { get; set; }
        
       
        public void Meow() { Console.WriteLine("냥냥 웁니다."); }
    }
}