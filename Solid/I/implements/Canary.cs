using System;
namespace Solid.Principles.I
{
    public class Canary : IBird, IBirdFlying
    {
        public void Fly() {
            Console.WriteLine("Canario - Volar");
        }
        public void Eat() {
            Console.WriteLine("Canario - Comer");
        }        
    }
}