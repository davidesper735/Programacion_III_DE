using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Ejercicios
{
       public class CuentaBancaria
        {
            public string Titular { get; set; }
            public double Saldo { get; private set; }

            public void ConsultarSaldo()
            {
                Console.WriteLine($"Saldo actual: {this.Saldo}");
            }

            public void Depositar (double cantidad)
            {
                if (cantidad > 0) 
                {
                    this.Saldo += cantidad;
                    Console.WriteLine($"Depósito exitoso.\nEl nuevo saldo es: {this.Saldo}");
                }
                else
                {
                    Console.WriteLine("La cantidad a depositar debe ser mayor a cero.");
                }
            }

            public void Retirar(double cantidad)
            {

                if (cantidad > 0) 
                {
                    this.Saldo -= cantidad;
                    Console.WriteLine($"Retiro exitoso.\nEl nuevo saldo es: {this.Saldo}");
                }
                
            }


        }
    public static class Ejercicio1
    {
        public static void Ejecutar()
        {

            Console.WriteLine("Ejercicio 1: Cuenta Bancaria");

            Console.WriteLine(" ");

            Console.WriteLine("Ingrese el nombre del Titular: ");
            string titular = Console.ReadLine();

            Console.Clear();

            CuentaBancaria cuenta = new CuentaBancaria { Titular = titular};

            Console.WriteLine("================================");
            Console.WriteLine("       MENU DE OPERACIONES      ");
            Console.WriteLine("================================");
            Console.WriteLine($"Bienvenido, Titular: {cuenta.Titular}");
            Console.WriteLine(" ");
            Console.WriteLine("1. Consultar Saldo");
            Console.WriteLine("2. Depositar");
            Console.WriteLine("3. Retirar");
            Console.WriteLine(" ");
            Console.WriteLine("Seleccione una opción (1-3): ");
            int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        cuenta.ConsultarSaldo();
                        break;

                    case 2:

                        Console.WriteLine("Ingrese la cantidad a depositar: ");
                        double deposito = double.Parse(Console.ReadLine());
                        cuenta.Depositar(deposito);
                        break;

                    case 3:

                        Console.WriteLine("Ingrese la cantidad a retirar: ");
                        double retiro = double.Parse(Console.ReadLine());
                        cuenta.Retirar(retiro);
                        break;

                    default:

                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción entre 1 y 3.");
                        break;

                }
         }
            
    }

}




