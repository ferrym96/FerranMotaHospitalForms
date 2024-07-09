using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Paciente : Persona
    {
        public string Planta { get; set; }
        public List<string> Medicamentos { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Medico { get; set; }

        public Paciente(string nombre, string apellido, string dni, string planta, List<string> medicamentos, DateTime fechaIngreso, string dniMedico) : base(nombre, apellido, dni)
        {
            Planta = planta;
            Medicamentos = medicamentos;
            FechaIngreso = fechaIngreso;
            Medico = dniMedico;
        }

        public override string ToString()
        {
           
            string medicamentosStr = string.Join(", ", Medicamentos);

            return $"Paciente: {Nombre} {Apellido} \n" +
                   $"DNI: {DNI} \n" +
                   $"Planta: {Planta} \n" +
                   $"Médico: {Medico} \n" +
                   $"Medicamentos: {medicamentosStr} \n" +
                   $"Fecha de Ingreso: {FechaIngreso.ToShortDateString()}";
        }
    }
}
