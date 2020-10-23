
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
            System.Console.WriteLine("0) Salir.");
            System.Console.WriteLine("");
        }

        public static void PrintAdditionMenu()
        {
            System.Console.WriteLine("          MENÚ DE SUMAS");
            System.Console.WriteLine("----------------------------------");
            System.Console.WriteLine("");
        }

        public static void PrintAdditionSubMenu()
        {
            System.Console.WriteLine("0) Volver al menú principal.");
            System.Console.WriteLine("1) Seguir sumando.");
            System.Console.WriteLine("2) Reiniciar suma.");
            System.Console.WriteLine("");
        }

        public static void PrintSubtractionMenu()
        {
            System.Console.WriteLine("          MENÚ DE RESTAS");
            System.Console.WriteLine("-----------------------------------");
            System.Console.WriteLine("");
        }

        public static void PrintSubtractionSubMenu()
        {
            System.Console.WriteLine("0) Volver al menú principal.");
            System.Console.WriteLine("1) Seguir restando.");
            System.Console.WriteLine("2) Reiniciar resta.");
            System.Console.WriteLine("");
        }

        public static void PrintMultiplicationMenu()
        {
            System.Console.WriteLine("           MENÚ DE MULTIPLICACIONES");
            System.Console.WriteLine("-----------------------------------------------");
            System.Console.WriteLine("");
        }
        
        public static void PrintMultiplicationSubMenu()
        {
            System.Console.WriteLine("0) Volver al menú principal.");
            System.Console.WriteLine("1) Seguir multiplicando.");
            System.Console.WriteLine("2) Reiniciar multiplicación.");
        }
    }
}
