using System;

namespace ATM
{
    // Clase CajeroAutomatico
    class CajeroAutomatico
    {
        // Método para mostrar el mensaje de bienvenida
        public void MostrarMensajeBienvenida()
        {
            Console.WriteLine("Bienvenido al Cajero Automático");
        }

        // Método para ejecutar la lógica del cajero automático
        public void Ejecutar()
        {
            // Aquí se agregará la lógica del cajero automático
            Console.WriteLine("Aquí se agregará la lógica del cajero automático.");
        }
    }

    // Clase Program
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase CajeroAutomatico
            CajeroAutomatico cajero = new CajeroAutomatico();

            // Llamar al método para mostrar el mensaje de bienvenida
            cajero.MostrarMensajeBienvenida();

            // Llamar al método para ejecutar la lógica del cajero automático
            cajero.Ejecutar();
        }
    }
}