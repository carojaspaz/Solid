namespace Solid.Principles.O
{
    public class AudiModel : AbstractCar
    {
        public AudiModel () : base("Audi") {}
        public override int Cost()
        {
            return 20000;
        }
    }    
}