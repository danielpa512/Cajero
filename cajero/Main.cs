using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Cajero Automático");
            if (Login())
            {
                Console.WriteLine("Inicio de sesión exitoso");
                CheckBalance();
            }
            else
            {
                Console.WriteLine("Inicio de sesión fallido");
            }
        }

        static bool Login()
        {
            Console.Write("Ingrese su usuario: ");
            string username = Console.ReadLine();
            Console.Write("Ingrese su contraseña: ");
            string password = Console.ReadLine();
            return username == "admin" && password == "1234";
        }

        static void CheckBalance()
        {
            // Aquí se debe agregar la lógica para obtener y mostrar el saldo
            decimal balance = 1000.00m; // Ejemplo simplificado
            Console.WriteLine($"Tu saldo actual es {balance:C}.");
        }
    }
}
