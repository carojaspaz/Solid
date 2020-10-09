using System;
namespace Solid.Principles.D
{
    public class DataBadAccess
    {
        private DataBadService _service;

        public DataBadAccess(DataBadService service){
            _service = service;
        }

        public void GetData(string entity){
            _service.getData(entity);
        }
    }
}