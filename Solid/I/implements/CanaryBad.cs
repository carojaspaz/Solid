using System;
namespace Solid.Principles.I
{
    public class CanaryBad : IBirdBad
    {
        public void Fly() {
            Console.WriteLine("Volar");
        }
        public void Eat() {
            Console.WriteLine("Comer");
        }
        public void Swim() {
            throw new Exception("No puede nadar");
        }
    }
}