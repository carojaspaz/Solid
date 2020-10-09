namespace Solid.Services
{
    public class Data {

    }
    public class DataServices {
        public Data getData(){
           return new Data();
        }
    }

    public class DataAccess {
        private DataServices _dataSrv;

        public DataAccess(DataServices dataServices){
            _dataSrv = dataServices;
        }

        public Data getData(){
            _dataSrv.getData();
            return null;
        }

    }


}