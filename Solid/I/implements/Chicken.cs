using System;
namespace Solid.Principles.I
{
    public class Chicken : IBird
    {        
        public void Eat() {
            Console.WriteLine("Canario - Comer");
        }        
    }
}