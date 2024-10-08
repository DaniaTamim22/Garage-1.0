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
            bool isalive = true;
            GarageHandler garageHandler;

            UserInterface userInterface = new UserInterface();
            do
            {   userInterface.PrintWelcomeMessage();
                uint input = Util.AskForUInt("Enter your choice : ");

                switch (input)
                {
                    case UserInterface.Quit:
                        {
                            isalive = false; break;
                        }

                    case UserInterface.CreateNewGarage:
                        {
                            garageHandler = new GarageHandler("First Garage", 10);
                            garageHandler.SeedData(garageHandler);
                            break;
                        }
                    case UserInterface.AddNewVehicle:
                        {
                            userInterface.PrintAddVehicleMenu();
                            break;
                        }
                    case UserInterface.ListAllVehicle:
                        {
                            userInterface.ListAllVehicleMenu();
                            break;
                        }
                    case UserInterface.ListVehicleTypes:
                        {
                            userInterface.ListVehicleTypesMenu();
                            break;
                        }
                    case UserInterface.ParkVehicle:
                        {
                            userInterface.ParkVehicleMenu();
                            break;
                        }
                    case UserInterface.RemoveVehicle:
                        {
                            userInterface.RemoveVehicleMenu();
                            break;
                        }
                    case UserInterface.FindVehicle:
                        {
                            userInterface.FindVehicleMenu();
                            break;
                        }
                    case UserInterface.SearchByRegNum:
                        {
                            userInterface.SearchByRegNumMenu();
                            break;
                        }
                    case UserInterface.SearchByProperties:
                        {
                            //userInterface.ListAllVehicleMenu();
                            break;
                        }
                    case UserInterface.SearchByNumOfWheels:
                        {
                           // userInterface.ListAllVehicleMenu();
                            break;
                        }
                    case UserInterface.SearchByType:
                        {
                           // userInterface.ListAllVehicleMenu();
                            break;
                        }
                    case UserInterface.GoBackToMainMenu:
                        {
                           // userInterface.ListAllVehicleMenu();
                            break;
                        }
                    case UserInterface.SearchByColor:
                        {
                            //userInterface.ListAllVehicleMenu();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You Entered Unvalid Number!! Please Enter a number from the menu below :\n");
                            break;
                        }

                }
                   
            }
            while (isalive);

            //var vehicles =garageHandler.GetAllVehicles();
            //foreach (var v in vehicles)
            //{
            //    if (v != null)
            //    {
            //        Console.WriteLine(v.ToString());
            //    }
            //}
        }
    }
}
