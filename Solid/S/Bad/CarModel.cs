using System;

namespace Solid.Principles.S.Bad
{
    public class Car
    {
        public string Brand { get; set; }

        public Car(string _brand)
        {
            Brand = _brand;
        }        
         public void saveCarDB(Car _car)
        {
            //TODO: Guardar en base de datos
            Console.WriteLine("Carro {0} guardado satisfactoriamente", _car.Brand);
        }

        public void deleteCarDb(Car _car)
        {
            //TODO: Eliminar en base de datos
            Console.WriteLine("Carro {0} eliminado satisfactoriamente", _car.Brand);
        }
    }    
}