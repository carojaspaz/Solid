using System;
namespace Solid.Principles.D
{
    public class ApiService : IService
    {                
        public void getData(string entity){
            Console.WriteLine("Consultar Datos Api: {0}", entity);
        }
    }
}