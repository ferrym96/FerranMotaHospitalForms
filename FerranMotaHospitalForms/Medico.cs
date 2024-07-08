using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Medico : Empleado
    {
        public enum eEspecialidad
        {
            Cardiologia,
            Pediatria,
            Neurologia,
            Oncologia,
            Oftalmologia,
            Otras
        }
        public string Especialidad { get; set; }

        public Medico(string nombre, string apellido, string dni, double sueldo, DateTime anyoIncorporacion, string especialidad) : base(nombre, apellido, dni, sueldo, anyoIncorporacion)
        {
            Especialidad = especialidad;
        }

        public override string ToString()
        {
            return $"Médico: {Nombre} {Apellido}\n" +
                   $"DNI: {DNI}\n" +
                   $"Sueldo: {Sueldo}\n" +
                   $"Año de Incorporación: {AnyoIncorporacion}\n" +
                   $"Especialidad: {Especialidad}";
        }

    }
}
