namespace Solid.Services.Solid
{
    public class Data {

    }
    public interface IService {
        Data getData();        
    }

    public class DataAccess {
        private IService _srv;

        public DataAccess(IService srv){
            _srv = srv;
        }

        public Data getData(){
            return _srv.getData();            
        }
    }
}