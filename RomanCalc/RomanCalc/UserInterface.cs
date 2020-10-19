
namespace RomanCalc
{
    class UserInterface
    {
        public static void PrintMainMenu()
        {
            System.Console.WriteLine("          CALCULADORA ROMÁN");
            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("1) Sumar una serie de números.");
            System.Console.WriteLine("2) Restar una serie de números.");
            System.Console.WriteLine("3) Multiplicar una serie de números.");
            System.Console.WriteLine("4) Dividir una serie de números.");
            System.Console.WriteLine("5) Ecuaciones de primer grado.");
            System.Console.WriteLine("6) Ecuaciones de segundo grado.");
            System.Console.WriteLine("7) Raíces cuadradas.");
            System.Console.WriteLine("8) Fibonacci.");
            System.Console.WriteLine("9) Sumatorios.");
            System.Console.WriteLine("0) Salir.\n");
        }

        public static void PrintAdditionMenu()
        {
            System.Console.WriteLine("          MENÚ DE SUMAS");
            System.Console.WriteLine("----------------------------------");
            System.Console.WriteLine("");
        }
        public static int ReadOption()
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
    }
}
