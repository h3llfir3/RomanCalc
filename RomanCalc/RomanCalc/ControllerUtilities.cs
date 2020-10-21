
using System.Runtime.InteropServices;

namespace RomanCalc
{
    class ControllerUtilities
    {
        public static int ReadIntegerInput(string Message)
        {
            while (true)
            {
                System.Console.WriteLine(Message);
                string number = System.Console.ReadLine();
                try 
                {
                    int convertedInteger = System.Convert.ToInt32(number);
                    return convertedInteger;

                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine("La entrada es incorrecta.");
                }
            }
        }
        public static int ReadMenuOption()
        {
            string option = System.Console.ReadLine();
            try
            {
                int result = System.Convert.ToInt32(option);
                return result;
            }
            catch (System.Exception e)
            {
                return -1;
            }
        }
        public static int ReadMenuOption(int minOptionValue, int maxOptionValue)
        {
            while (true)
            {
                int option = ReadMenuOption();
                if (option >= minOptionValue && option <= maxOptionValue)
                    return option;
                else
                    System.Console.WriteLine("Opción no válida. Introduzca una opción entre " + minOptionValue + " y " + maxOptionValue);
            }
            
        }
    }
}
