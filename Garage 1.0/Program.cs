using Garage_1._0.Entities;
using Garage_1._0.Garage;
using Garage_1._0.UI;
using System.Xml.Linq;

namespace Garage_1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GarageHandler garageHandler = new GarageHandler (10);
           garageHandler.InitializeGarage();

            UserInterface userInterface = new UserInterface();
            userInterface.PrintWelcomeMessage();


            // Vehicle car= new Vehicle("REG","Red",4);
            // Vehicle car2= new Vehicle("REG","Red",4);

            //Garage<Vehicle> vehicles = [car] ; 
            //GarageHandler garageHandler =GarageHandler("GarageTest",5, vehicles);
        }
    }
}
