using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using NLog;

namespace Sist
{
    public class Empleado
    {
        string nombre;
        string apellido;
        string direccion;
        Estadociv estCiv;
        int cantHijos;
        DateTime fechaDivorcio;
        DateTime fechaNacimiento;
        DateTime fechaIngreso;
        Cargos cargo;
        struct Universidad
        {
            enum Tienetitulo { Si, No };
            string titulo;
            string nombreuni;
        }
        float salario;

        public global::System.String Nombre { get => nombre; set => nombre = value; }
        public global::System.String Apellido { get => apellido; set => apellido = value; }
        public global::System.String Direccion { get => direccion; set => direccion = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public Cargos Cargo { get => cargo; set => cargo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public float Salario { get => salario; set => salario = value; }
        public int CantHijos { get => cantHijos; set => cantHijos = value; }

        public int CalcularAntiguedad()
        {
            return DateTime.Today.Year - FechaIngreso.Year;
        }

        public int CalcularEdad()
        {
            return DateTime.Today.Year - FechaNacimiento.Year;
        }

        public float CalcularSalario(float sueldoBasico)
        {
            float adicional;
            float descuento = Convert.ToSingle(sueldoBasico * 0.15);

            if (CalcularAntiguedad() > 20)
            {
                adicional = Convert.ToSingle(sueldoBasico * 0.25); //25%
            } else
            {
                adicional = Convert.ToSingle(sueldoBasico * (CalcularAntiguedad() / 100));
            }

            return sueldoBasico + adicional - descuento;
        }

        public Empleado(string nom, string apellido, string direcc, Estadociv ec, int hijos, DateTime nacimiento, DateTime ingreso, Cargos cargo, float salario)
        {

            try
            {
                this.Nombre = nom;
                this.Apellido = apellido;
                this.Direccion = direcc;
                this.estCiv = ec;
                this.CantHijos = hijos;
                this.FechaNacimiento = nacimiento;
                this.FechaIngreso = ingreso;
                this.Cargo = cargo;
                this.Salario = salario;
            }
            catch(Exception exx)
            {
                Console.WriteLine("Error al cargar datos.");
            }
        }

        public void MostrarDatos()
        {
            try
            {
                Console.WriteLine("Nombre y apellido: " + this.Nombre + " " + this.Apellido);
                Console.WriteLine("Edad: " + this.CalcularEdad());
                Console.WriteLine("Salario bruto: " + this.Salario);
                Console.WriteLine("Salario neto: " + this.CalcularSalario(this.Salario));
                Console.WriteLine("Antigüedad: " + this.CalcularAntiguedad());
                Console.WriteLine("");
            }
            catch(Exception exx2)
            {
                Console.WriteLine("Error al mostrar datos.");
            }
        }
    }

    public enum Cargos
    {
        Administrativo = 0,
        JefeDeEquipo = 1,
        JefeDeArea = 2,
        CoordinadorDeSector = 3,
        DirectorRegional = 4,
        CEO = 5
    }

    public enum Estadociv { Casado, Soltero, Divorciado };
}
