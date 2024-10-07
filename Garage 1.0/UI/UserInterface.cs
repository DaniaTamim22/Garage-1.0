using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.UI
{
    public class UserInterface : IUI
    {
        public const int CreateNewGarage = 1;
        public const int AddNewVehicle = 2;
        public const int ListAllVehicle = 3;
        public const int ListVehicleTypes = 4;
        public const int ParkVehicle = 5;
        public const int RemoveVehicle = 6;
        public const int FindVehicle = 7;
        public const int Quit = 0;

        public const int SearchByRegNum = 1;
        public const int SearchByProperties = 2;
        public const int SearchByType = 3;
        public const int GoBackToMainMenu = 0;

        public void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to Garage 1.0... \n" +
                    $"Please enter your choice to proceed ..\n" +
                    $"{CreateNewGarage} Create a new garage. \n" +
                    $"{AddNewVehicle} Add a new vehicle .\n" +
                    $"{ListAllVehicle} Show all vehicles in the garage and each type  .\n" +
                    $"{ListVehicleTypes} Show all vehicles types in the garage .\n" +
                    $"{ParkVehicle} Park a vehicle in tha garage .\n" +
                    $"{RemoveVehicle} Remove a vehicle from tha garage .\n" +
                    $"{FindVehicle} Search vehicle in tha garage .\n" +
                    $"{Quit} Close the program .\n");

        }

        public void PrintSearchMenu()
        {
            Console.WriteLine(" ¤¤¤¤¤ Search Vehicle Menu ¤¤¤¤¤  \n +" +
                    $"Please enter your choice to proceed ..\n" +
                    $"{SearchByRegNum} Search a vehicle by registeration number. \n" +
                    $"{SearchByProperties} Search a vehicle by it's properties.\n" +
                    $"{SearchByType} Search a vehicle by it's type  .\n" +
                    $"{GoBackToMainMenu} Go back to main menu.. .\n");
        }

    }
}
