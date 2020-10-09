using System;
using sb = Solid.Principles.S.Bad;
using Solid.Principles.S;
using Solid.Principles.O;
using Solid.Principles.I;
using Solid.Principles.D;


namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");
            #region S
            Console.WriteLine("S - Responsabilidad Simple");

            Console.WriteLine("Incorrecto");
            // Una sola clase tiene la responsabilidad del objeto
            // y la de almacenarlo en la base de datos eso esta en
            // desacuerdo con el principio
            var carBad = new sb.Car("Renault");
            carBad.saveCarDB(carBad);

            Console.WriteLine("Correcto");
            // Lo correcto es que cada responsabilidad sea separada
            // en clases diferentes
            var car = new Car("Renault");
            var cadDB = new CarDb();
            cadDB.saveCarDB(car);
            #endregion
            Console.WriteLine("---------------------------------");
            
            Console.WriteLine("0 - Abierto Cerrado");
            #region O
            Console.WriteLine("Incorrecto");
            // Si agregamos un item en el arreglo carsBadArray se debe
            // modificar el método viewCostCarBad, lo cual no cumple
            // el principio Abierto/Cerrado
            // Para cada nuevo carro se debería modificar la funcionalidad
            sb.Car[] carsBadArray = {
                new sb.Car("Renault"),
                new sb.Car("Audi")//,
                //new sb.Car("Susuzi")
            };
            viewCostCarBad(carsBadArray);

            Console.WriteLine("Correcto");
            // Si agregamos un nuevo item al arreglo carsArray no será
            // necesario hacer modificaciones en el médodo viewCostCar
            AbstractCar[] carsArray = {
                new RenaultModel(),
                new AudiModel()//,
                //new SusukiModel()
            };

            viewCostCar(carsArray);
            #endregion
            Console.WriteLine("---------------------------------");            
            
            Console.WriteLine("L - Suplantación de Liskov");
            
            // Llamamos al método Sustitution, para evaluar el comportamiento            
            Sustitution(carsArray);

            Console.WriteLine("---------------------------------");            
            #region I
            Console.WriteLine("I - Segregación de interfaces");

            Console.WriteLine("Incorrecto");
            // Cuando la interfaz tiene metodos que la clase no debe implementar
            // estos generan comportamientos innecesarios que no deberian tener
            ChickenBad chickenBad = new ChickenBad();
            chickenBad.Eat();
            try{
                chickenBad.Fly();
            } catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Correcto");
            // Cuando se dividen las interfaces las implementaciones no tienen
            // funcionalidades que no necesitan
            Chicken chicken = new Chicken();
            chicken.Eat();
            //chicken.Fly(); No es implementado en la clase Chicken
            #endregion
            Console.WriteLine("---------------------------------");            
            #region D
            Console.WriteLine("D - Inversión de dependencias");
            // Cuando los sistemas son bastante grandes se utiliza
            // inyección de dependencias para cargar modulos
            Console.WriteLine("Incorrecto");
            // Si por alguna razón cambio el servicio de acceso a datos
            // debo modificar todas las instancias del accesso
            DataBadService dataBadService = new DataBadService();
            DataBadAccess dataBadAccess = new DataBadAccess(dataBadService);
            dataBadAccess.GetData("Carros");                        
            Console.WriteLine("Correcto");
            // Cuando se hace usando las interfaces no es necesario cambiar todas
            // las instancias, ya que utilizamos la abstracción no la concreción
            // Puede intercambiar ApiService con DataBaseService
            ApiService service = new ApiService();
            //DataBaseService service = new DataBaseService();
            DataAccess dataAccess = new DataAccess(service);
            dataAccess.GetData("Carros");
            #endregion
        }

        public static void viewCostCarBad(sb.Car[] carsBadArray)
        {
            foreach (var c in carsBadArray)
            {
                if (c.Brand == "Renault")
                    Console.WriteLine("Costo Auto Marca Renault = {0}", 10000);
                if (c.Brand == "Audi")
                    Console.WriteLine("Costo Auto Marca Audi = {0}", 20000);
                //if (c.Brand == "Susuki")
                //  Console.WriteLine("Costo Auto Marca Susuki = {0}", 30000);
            }

        }

         public static void viewCostCar(AbstractCar[] carsArray)
        {
            foreach (var c in carsArray)
            {
               Console.WriteLine("Costo Auto Marca {0} = {1}", c.Brand, c.Cost());
            }
        }
    
        public static void Sustitution(AbstractCar[] carsArray){
            // Podemos ver que el comportamiento es el mismo, si usamos
            // la clase padre como si usamos la clase hija
            // viewCostCar llama a la clase Padre AbstractCar
            // Y los if invocan a la clase hija, en los dos casos el resultado es
            // el mismo
            foreach (var c in carsArray)
            {                
                viewCostCar(c);
                if(c is RenaultModel)
                    Console.WriteLine("Clase Hija Renault Costo: {0}", c.Cost());
                if(c is AudiModel)
                    Console.WriteLine("Clase Hija Audi Costo: {0}", c.Cost());
            }
        }

        public static void viewCostCar(AbstractCar car){
            Console.WriteLine("Clase Padre Costo: {0}", car.Cost());            
        }
    }
}
