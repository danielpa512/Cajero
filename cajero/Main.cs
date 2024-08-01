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
                Transfer();
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

        static void Transfer()
        {
            Console.Write("Ingrese la cantidad a transferir: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ingrese el número de cuenta destinatario: ");
            string accountNumber = Console.ReadLine();
            // Aquí se debe agregar la lógica para verificar y procesar la transferencia
            Console.WriteLine($"Has transferido {amount:C} a la cuenta {accountNumber}.");
        }
    }
}
