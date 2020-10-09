namespace Solid.Principles.O
{
    public class SusukiModel : AbstractCar
    {
        public SusukiModel () : base("Susuki") {}
        public override int Cost()
        {
            return 30000;
        }
    }    
}