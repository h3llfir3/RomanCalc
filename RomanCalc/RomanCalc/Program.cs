
// Este es el controlador principal

using System;
using System.Runtime.InteropServices;

namespace RomanCalc
{
    class Program
    {
        // Addition function Controller
        // This function manages the addiotion menu loop,
        // and their options
         public static void LaunchSubAdditionMenu(int accumulated)
        {
            while (true)
            {
                UserInterface.PrintAdditionMenu();
                int number = ControllerUtilities.ReadIntegerInput("Introduzca el número a sumar: ");
                accumulated += number;
                System.Console.WriteLine("El número acumulado es: " + accumulated);
                UserInterface.PrintAdditionSubMenu();
            }
        }
        
        public static void LaunchAdditionMenu()
        {
            while (true)
            {
                UserInterface.PrintAdditionMenu();
                int number1 = ControllerUtilities.ReadIntegerInput("Introduzca el primer número: ");
                int number2 = ControllerUtilities.ReadIntegerInput("Introduzca el segundo número: ");
                int result = number1 + number2;
                System.Console.WriteLine("El resultado de la suma es: " + result);
                System.Console.WriteLine("");
                UserInterface.PrintAdditionSubMenu();
                int option = ControllerUtilities.ReadMenuOption(0,2);
                switch (option)
                {
                    case 0:
                        return;
                    case 1:
                        LaunchSubAdditionMenu(result);
                        break;
                    case 2:
                        break;
                    default:
                        break;
                }
            }
        }
       

        public static void LaunchSubtractionMenu()
        {
            while (true)
            {
                UserInterface.PrintSubtractionMenu();
                int number1 = ControllerUtilities.ReadIntegerInput("Introduzca el primer número: ");
                int number2 = ControllerUtilities.ReadIntegerInput("Introduzca el segundo número: ");
                int result = number1 - number2;
                System.Console.WriteLine("El resultado de la resta es: " + result);
                System.Console.WriteLine("");
                UserInterface.PrintSubtractionSubMenu();
                int option = ControllerUtilities.ReadMenuOption(0,2);
                switch (option)
                {
                    case 0:
                        System.Console.Clear();
                        return;
                    case 1:
                        break;
                    case 2:
                        System.Console.Clear();
                        break;
                    default:
                        break;
                }
            }
        }
        public static void LaunchMainMenu()
        {
            while (true)
            {
                UserInterface.PrintMainMenu();
                int option = ControllerUtilities.ReadMenuOption();
                System.Console.Clear();

                if (option == 0)
                    break;
                else if (option == -1)
                    System.Console.WriteLine("Opción no válida.\n");
                else if (option > 9 || option < 0)
                    System.Console.WriteLine("Opción no válida. Introduzca un número comprendido entre 0 y 9.\n");
                else if (option == 1)
                    LaunchAdditionMenu();
                else if (option == 2)
                    LaunchSubtractionMenu();
            }
}
        static void Main(string[] args)
        {
            LaunchMainMenu();
        }
    }
}
