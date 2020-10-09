namespace Solid.Principles.O
{
    public class RenaultModel : AbstractCar
    {
        public RenaultModel () : base("Renault") {}
        public override int Cost()
        {
            return 10000;
        }
    }    
}