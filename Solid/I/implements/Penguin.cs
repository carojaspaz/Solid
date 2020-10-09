using System;
namespace Solid.Principles.I
{
    public class Penguin : IBird, IBirdSwimming
    {        
        public void Eat() {
            Console.WriteLine("Canario - Comer");
        }
        public void Swim() {
            Console.WriteLine("Canario - Nadar");
        }
    }
}