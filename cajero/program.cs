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

    // Clase Cuenta para manejar el saldo y depósitos
    class Cuenta
    {
        private decimal saldo;

        public Cuenta(decimal saldoInicial)
        {
            saldo = saldoInicial;
        }

        public void Depositar(decimal cantidad)
        {
            saldo += cantidad;
            Console.WriteLine($"Has depositado {cantidad:C}. Tu saldo actual es {saldo:C}.");
        }

        public decimal ObtenerSaldo()
        {
            return saldo;
        }
    }

    // Clase CajeroAutomatico para manejar las operaciones
    class CajeroAutomatico
    {
        private Cuenta cuenta;

        public CajeroAutomatico(Cuenta cuenta)
        {
            this.cuenta = cuenta;
        }

        public void MostrarMensajeBienvenida()
        {
            Console.WriteLine("Bienvenido al Cajero Automático");
        }

        public void Depositar()
        {
            Console.Write("Ingrese la cantidad a depositar: ");
            decimal cantidad = Convert.ToDecimal(Console.ReadLine());
            cuenta.Depositar(cantidad);
        }
    }

    // Clase Program que contiene el punto de entrada
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta(1000.00m);
            CajeroAutomatico cajero = new CajeroAutomatico(cuenta);
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
