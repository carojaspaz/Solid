using System;
namespace Solid.Principles.I
{
    public class PenguinBad : IBirdBad
    {
        public void Fly() {
            throw new Exception("No puede volar");
        }
        public void Eat() {
            Console.WriteLine("Comer");
        }
        public void Swim() {
            Console.WriteLine("Comer");
        }
    }
}