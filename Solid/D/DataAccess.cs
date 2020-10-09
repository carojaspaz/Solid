using System;
namespace Solid.Principles.D
{
    public class DataAccess
    {
        private IService _service;

        public DataAccess(IService service){
            _service = service;
        }

        public void GetData(string entity){
            _service.getData(entity);
        }
    }
}