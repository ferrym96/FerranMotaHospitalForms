using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal enum eDepartamento
    {
        Administracion,
        RecursosHumanos,
        Finanzas,
        Marketing
    }

    internal class Administrativo : Empleado
    {
        public string Departamento { get; set; }

        public Administrativo(string nombre, string apellido, string dni, double sueldo, DateTime anyoIncorporacion, string departamento) : base(nombre, apellido, dni, sueldo, anyoIncorporacion)
        {
            Departamento = departamento;
        }

        public override string ToString()
        {
            return $"Administrativo: {Nombre} {Apellido} \n" +
                   $"DNI: {DNI} \n" +
                   $"Sueldo: {Sueldo} \n" +
                   $"Año de Incorporación: {AnyoIncorporacion} \n" +
                   $"Departamento: {Departamento}";
        }
    }
}
