using System;
namespace Solid.Principles.D
{
    public class DataBaseService : IService
    {                
        public void getData(string entity){
            Console.WriteLine("Consultar Datos DB: {0}", entity);
        }
    }
}