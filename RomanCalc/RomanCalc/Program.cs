
// Este es el controlador principal

using System;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace RomanCalc
{
    class Program
    {
        // Addition function Controller
        // This function manages the addiotion menu loop,
        // and their options
         public static int LaunchSubAdditionMenu(int accumulated)
        {
            while (true)
            {
                UserInterface.PrintAdditionMenu();
                int number = ControllerUtilities.ReadIntegerInput("Introduzca el número a sumar: ");
                accumulated += number;
                System.Console.WriteLine("El número acumulado es: " + accumulated);
                UserInterface.PrintAdditionSubMenu();
                switch (ControllerUtilities.ReadMenuOption(0, 2))
                {
                    case 0:
                        System.Console.Clear();
                        return 0;
                    case 2:
                        return 2;
                }
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
                // Important. How to return from submenu to main menu
                switch (option)
                {
                    case 0:
                        return;
                    case 1:
                        int suboption = LaunchSubAdditionMenu(result);
                        if (suboption == 0)
                            return;
                        break;
                    case 2:
                        System.Console.Clear();
                        break;
                }
            }
        }
       
        public static int LaunchSubSubtractionMenu(int accumulated)
        {
            while (true)
            {
                System.Console.Clear();
                System.Console.WriteLine("El resultado anterior es: " + accumulated);
                System.Console.WriteLine("");
                UserInterface.PrintSubtractionMenu();
                int number = ControllerUtilities.ReadIntegerInput("Introduzca el número a restar: ");
                accumulated -= number;
                System.Console.WriteLine("El resultado es " + accumulated);
                UserInterface.PrintSubtractionSubMenu();
                switch (ControllerUtilities.ReadMenuOption(0,2))
                {
                    case 0:
                        System.Console.Clear();
                        return 0;
                    case 1:
                        System.Console.Clear();
                        System.Console.WriteLine("El resultado anterior es: " + accumulated);
                        break;
                    case 2:
                        return 2;
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
                        int suboption = LaunchSubSubtractionMenu(result);
                        if (suboption == 0)
                            return;
                        break;
                    case 2:
                        System.Console.Clear();
                        break;
                    default:
                        break;
                }
            }
        }

        public static void LaunchMultiplicationMenu()
        {

        }

        public static void LaunchEquation2Menu()
        {
            while (true)
            {
                // Imprimiré el mení
                // pido a
                // leo a
                // pido b
                // leo b
                // pido c
                // leo c
                double a = 1.0, b = 1.0, c = 1.0;
                Model.Equation2Solution eq = Model.Maths.SolveEquation2(a, b, c);
                // La solución es... 
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
