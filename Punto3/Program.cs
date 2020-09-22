using System;
using NLog;

namespace Punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
               
            }
    }

    public class Empleado
    {
        string nombre;
        string apellido;
        string direccion;
        Datetime fechaIngreso;
        Cargos cargo;
        string titulo;

        public global::System.String Nombre { get => nombre; set => nombre = value; }
        public global::System.String Apellido { get => apellido; set => apellido = value; }
        public global::System.String Direccion { get => direccion; set => direccion = value; }
        public Datetime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public Cargos Cargo { get => cargo; set => cargo = value; }
        public global::System.String Titulo { get => titulo; set => titulo = value; }

        public int CalcularAntiguedad()
        {
            
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
}
