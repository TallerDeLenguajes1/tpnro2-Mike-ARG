using System;
using NLog;
using System.Collections.Generic;
using System.Globalization;

namespace Sist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Logger Logger = LogManager.GetCurrentClassLogger(); 

            //Problema 1

            Console.WriteLine("Ingrese un número entero: ");

            try
            {
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Cuadrado del número: " + Math.Pow(numero, 2));
            }
            catch(Exception ex)
            {
                var mensaje = "Error message: " + ex.Message;

                if(ex.InnerException != null)
                {
                    mensaje = mensaje + " Inner exception: " + ex.InnerException.Message;
                }
                mensaje = mensaje + " Stack trace: " + ex.StackTrace;
                Logger.Error(mensaje);
            }

            //Problema 2 

            int num1, num2;

            Console.WriteLine("Ingrese el dividendo: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el divisor: ");
            num2 = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine("Resultado de la división entre " + num1 + " y " + num2 + ": " + num1 / num2);
            }
            catch(Exception ex2)
            {
                Console.WriteLine("Se produjo un error en la división");
                Console.WriteLine(ex2.ToString());
            }

            Console.WriteLine("Ingrese el número de empleados: ");
            int num = Convert.ToInt32(Console.ReadLine());
            List<Empleado> listaEmpleados = new List<Empleado>();

            listaEmpleados.Add(new Empleado("Juan", "Perez", "Av. Mitre 1350", Estadociv.Casado, 2, Convert.ToDateTime("19/04/1986"), Convert.ToDateTime("25/07/2009"), Cargos.Administrativo, 15300));
            listaEmpleados.Add(new Empleado("Miguel", "Vanetta", "Santiago 3515", Estadociv.Soltero, 2, Convert.ToDateTime("19/08/1999"), Convert.ToDateTime("03/01/2015"), Cargos.DirectorRegional, 48650));
            listaEmpleados.Add(new Empleado("Carlos", "Morales", "Bolivia 350", Estadociv.Divorciado, 2, Convert.ToDateTime("14/09/1965"), Convert.ToDateTime("13/12/1999"), Cargos.CEO, 94946));

            foreach(Empleado empleado in listaEmpleados)
            {
                empleado.MostrarDatos();
            }
        }
    }
}
