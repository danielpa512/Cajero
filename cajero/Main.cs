using System;

namespace ATM
{
    // Clase Usuario para manejar la autenticación
    class Usuario
    {
        private string username = "admin";
        private string password = "1234";

        public bool Login(string usuario, string contrasena)
        {
            return usuario == username && contrasena == password;
        }
    }

    // Clase CajeroAutomatico para manejar las operaciones
    class CajeroAutomatico
    {
        public void MostrarMensajeBienvenida()
        {
            Console.WriteLine("Bienvenido al Cajero Automático");
        }

        public void Depositar()
        {
            Console.Write("Ingrese la cantidad a depositar: ");
            decimal cantidad = Convert.ToDecimal(Console.ReadLine());
            // Aquí se debe agregar la lógica para verificar y procesar el depósito
            Console.WriteLine($"Has depositado {cantidad:C}.");
        }
    }

    // Clase Program que contiene el punto de entrada
    class Program
    {
        static void Main(string[] args)
        {
            CajeroAutomatico cajero = new CajeroAutomatico();
            Usuario usuario = new Usuario();

            cajero.MostrarMensajeBienvenida();

            if (Login(usuario))
            {
                Console.WriteLine("Inicio de sesión exitoso");
                cajero.Depositar();
            }
            else
            {
                Console.WriteLine("Inicio de sesión fallido");
            }
        }

        static bool Login(Usuario usuario)
        {
            Console.Write("Ingrese su usuario: ");
            string username = Console.ReadLine();
            Console.Write("Ingrese su contraseña: ");
            string password = Console.ReadLine();
            return usuario.Login(username, password);
        }
    }
}