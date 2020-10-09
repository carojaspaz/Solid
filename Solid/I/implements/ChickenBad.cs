using System;
namespace Solid.Principles.I
{
    public class ChickenBad : IBirdBad
    {
        public void Fly() {
            throw new Exception("No puede volar");
        }
        public void Eat() {
            Console.WriteLine("Comer");
        }
        public void Swim() {
            throw new Exception("No puede nadar");
        }
    }
}