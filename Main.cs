using System;

class CajeroAutomatico
{
    static void Main()
    {
        decimal saldo = 1000.00m; // Saldo inicial del usuario
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al Cajero Automático");
            Console.WriteLine("1. Ver saldo");
            Console.WriteLine("2. Depositar dinero");
            Console.WriteLine("3. Retirar dinero");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    VerSaldo(saldo);
                    break;
                case 2:
                    saldo = DepositarDinero(saldo);
                    break;
                case 3:
                    saldo = RetirarDinero(saldo);
                    break;
                case 4:
                    Console.WriteLine("Gracias por usar el Cajero Automático. ¡Adiós!");
                    break;
                default:
                    Console.WriteLine("Opción no válida, por favor intente de nuevo.");
                    break;
            }

            if (opcion != 4)
            {
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 4);
    }

    static void VerSaldo(decimal saldo)
    {
        Console.WriteLine($"Su saldo actual es: ${saldo}");
    }

    static decimal DepositarDinero(decimal saldo)
    {
        Console.Write("Ingrese la
