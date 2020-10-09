namespace Solid.Principles.O
{
    public abstract class AbstractCar
    {
        public string Brand { get; set; }

        public AbstractCar(string _brand)
        {
            Brand = _brand;
        }        

        public abstract int Cost();

    }    
}