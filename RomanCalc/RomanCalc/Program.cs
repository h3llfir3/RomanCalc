
// Este es el controlador principal

namespace RomanCalc
{
    class Program
    {
        public static void LaunchAdditionMenu()
        {
            while (true)
            {
                UserInterface.PrintAdditionMenu();
            }
        }
        public static void LaunchMainMenu()
        {
            while (true)
            {
                UserInterface.PrintMainMenu();
                int option = UserInterface.ReadOption();
                System.Console.Clear();

                if (option == 0)
                    break;
                else if (option == -1)
                    System.Console.WriteLine("Opción no válida.\n");
                else if (option > 9 || option < 0)
                    System.Console.WriteLine("Opción no válida. Introduzca un número comprendido entre 0 y 9.\n");
                else if (option == 1)
                    LaunchAdditionMenu();
            }
}
        static void Main(string[] args)
        {
            LaunchMainMenu();
        }
    }
}
