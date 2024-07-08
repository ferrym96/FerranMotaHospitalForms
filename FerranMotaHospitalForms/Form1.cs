using Hospital;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FerranMotaHospitalForms
{
    public partial class Form1 : Form
    {
        // Listas para almacenar los datos
        private List<Paciente> pacientes = new List<Paciente>();
        private List<Medico> medicos = new List<Medico>();
        private List<Administrativo> administrativos = new List<Administrativo>();


        public Form1()
        {
            InitializeComponent();


        }

        private void setInvisible()
        {
            groupCrearPaciente.Visible = false;
            groupCrearMedico.Visible = false;
            groupCrearAdmin.Visible = false;
            groupListarPacientes.Visible = false;
            groupListarMedicos.Visible = false;
            groupListarAdmin.Visible = false;
        }

        private void buttonNuevoPaciente_Click(object sender, EventArgs e)
        {
            setInvisible();
            groupCrearPaciente.Visible = true;



        }

        private void buttonNuevoMedico_Click(object sender, EventArgs e)
        {
            setInvisible();
            groupCrearMedico.Visible = true;
            groupCrearMedico.Location = new Point(180, 14);



        }

        private void buttonNuevoAdministrativo_Click(object sender, EventArgs e)
        {
            setInvisible();
            groupCrearAdmin.Visible = true;
            groupCrearAdmin.Location = new Point(180, 14);
        }

        private void buttonListarPacientes_Click(object sender, EventArgs e)
        {
            setInvisible();
            groupListarPacientes.Visible = true;
            groupListarPacientes.Location = new Point(180, 14);
            MostrarPacientes();
        }

        private void buttonListarMedicos_Click(object sender, EventArgs e)
        {
            setInvisible();
            groupListarMedicos.Visible = true;
            groupListarMedicos.Location = new Point(180, 14);
        }

        private void buttonListarAdmin_Click(object sender, EventArgs e)
        {
            setInvisible();
            groupListarAdmin.Visible = true;
            groupListarAdmin.Location = new Point(180, 14);
        }

        private void buttonCrearPaciente_Click(object sender, EventArgs e)
        {
            string nombrePaciente = txtNombrePaciente.Text;
            string apellidosPaciente = txtApellidosPaciente.Text;
            string dniPaciente = txtDNIPaciente.Text;
            DateTime fechaAltaPaciente = dateFechaAltaPaciente.Value;
            string medicoPaciente = comboMedicoPaciente.Text;
            string plantaPaciente = comboPlantaPaciente.SelectedItem.ToString();
            List<string> medicamentosPaciente = new List<string>();
            foreach (var item in listMedicamentosPaciente.Items)
            {
                medicamentosPaciente.Add(item.ToString());
            }
            // Limpiar items existentes para evitar duplicados
            comboMedicoPaciente.Items.Clear();

            // Agregar médicos al ComboBox
            foreach (Medico medico in medicos)
            {
                comboMedicoPaciente.Items.Add($"{medico.Nombre} {medico.Apellido} - {medico.Especialidad}");
            }
            Paciente nuevoPaciente = new Paciente(nombrePaciente, apellidosPaciente, dniPaciente, plantaPaciente, medicamentosPaciente, fechaAltaPaciente, medicoPaciente);
            pacientes.Add(nuevoPaciente);
            MessageBox.Show("Paciente creado correctamente");
        }

        private void buttonCrearMedico_Click(object sender, EventArgs e)
        {
            string nombreMedico = txtNombreMedico.Text;
            string apellidoMedico = txtApellidosMedico.Text;
            string dniMedico = txtDNIMedico.Text;
            double sueldoMedico = Convert.ToDouble(txtSueldoMedico.Text);
            DateTime incorporacionMedico = DateTime.Parse(dateTimeIncorporacionMedico.Text);
            string especialidadMedico = comboEspecialidadMedico.SelectedItem.ToString();

            Medico nuevoMedico = new Medico(nombreMedico, apellidoMedico, dniMedico, sueldoMedico, incorporacionMedico, especialidadMedico);
            medicos.Add(nuevoMedico);
            MessageBox.Show("Médico creado correctamente");
            // Actualizar ComboBox de pacientes con los médicos actualizados
            RefreshComboBoxPacientes();
        }
        private void RefreshComboBoxPacientes()
        {
            comboMedicoPaciente.Items.Clear();
            foreach (Medico medico in medicos)
            {
                comboMedicoPaciente.Items.Add($"{medico.Nombre} {medico.Apellido} - {medico.Especialidad}");
            }
        }

        private void buttonCrearAdmin_Click(object sender, EventArgs e)
        {
            string nombreAdmin = txtNombreAdmin.Text;
            string apellidoAdmin = txtApellidosAdmin.Text;
            string dniAdmin = txtDNIAdmin.Text;
            double sueldoAdmin = Convert.ToDouble(txtSueldoAdmin.Text);
            DateTime incorporacionAdmin = DateTime.Parse(dateTimeIncorporacionAdmin.Text);
            string deptAdmin = comboDepartamentoAdmin.Text;

            Administrativo nuevoAdmin = new Administrativo(nombreAdmin, apellidoAdmin, dniAdmin, sueldoAdmin, incorporacionAdmin, deptAdmin);
            administrativos.Add(nuevoAdmin);

            MessageBox.Show("Administrativo creado correctamente");
        }
        private void MostrarPacientes()
        {
            listPacientes.Items.Clear();
            foreach (Paciente paciente in pacientes)
            {
                listPacientes.Items.Add(paciente.ToString());
            }
        }

        private void buttonBorrarPaciente_Click(object sender, EventArgs e)
        {
            
                // Obtener el paciente seleccionado en el ListBox
                if (listPacientes.SelectedIndex != -1)
                {
                    string pacienteSeleccionado = listPacientes.SelectedItem.ToString();

                    // Buscar el paciente en la lista de pacientes
                    foreach (Paciente paciente in pacientes)
                    {
                        if (paciente.ToString() == pacienteSeleccionado)
                        {
                            pacientes.Remove(paciente);
                            MessageBox.Show("Paciente eliminado correctamente");
                            MostrarPacientes(); // Actualizar la lista de pacientes en el ListBox
                            return;
                        }
                    }

                    MessageBox.Show("No se encontró el paciente seleccionado en la lista.");
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un paciente para borrar.");
                }
            

        }

        private void buttonCancelarPaciente_Click(object sender, EventArgs e)
        {
            // Mostrar ventana emergente para confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cancelar y eliminar el contenido?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                // Limpiar todos los campos relacionados con la creación de pacientes
                txtNombrePaciente.Text = "";
                txtApellidosPaciente.Text = "";
                txtDNIPaciente.Text = "";
                dateFechaAltaPaciente.Value = DateTime.Now; // Otra fecha por defecto si es necesario
                comboMedicoPaciente.SelectedIndex = -1;
                comboPlantaPaciente.SelectedIndex = -1;
                foreach (var item in listMedicamentosPaciente.SelectedItems.Cast<string>().ToList())
                {
                    listMedicamentosPaciente.SelectedItems.Remove(item);
                }

            }
        }
    }
}
