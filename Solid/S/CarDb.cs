using System;

namespace Solid.Principles.S
{   
    public class CarDb
    {
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