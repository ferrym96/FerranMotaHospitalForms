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
            MostrarMedicos();
        }

        private void buttonListarAdmin_Click(object sender, EventArgs e)
        {
            setInvisible();
            groupListarAdmin.Visible = true;
            groupListarAdmin.Location = new Point(180, 14);
            MostrarAdministrativos();
        }

        private void buttonCrearPaciente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombrePaciente.Text) ||
        string.IsNullOrWhiteSpace(txtApellidosPaciente.Text) ||
        string.IsNullOrWhiteSpace(txtDNIPaciente.Text) ||
        comboPlantaPaciente.SelectedIndex == -1 ||
        comboMedicoPaciente.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, rellene todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

            Paciente nuevoPaciente = new Paciente(nombrePaciente, apellidosPaciente, dniPaciente, plantaPaciente, medicamentosPaciente, fechaAltaPaciente, medicoPaciente);
            pacientes.Add(nuevoPaciente);
            MessageBox.Show("Paciente creado correctamente");

            LimpiarCamposPaciente();
        }

        private void buttonCrearMedico_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreMedico.Text) ||
         string.IsNullOrWhiteSpace(txtApellidosMedico.Text) ||
         string.IsNullOrWhiteSpace(txtDNIMedico.Text) ||
         string.IsNullOrWhiteSpace(txtSueldoMedico.Text) ||
         comboEspecialidadMedico.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtSueldoMedico.Text, out double sueldoMedico))
            {
                MessageBox.Show("El sueldo debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombreMedico = txtNombreMedico.Text;
            string apellidoMedico = txtApellidosMedico.Text;
            string dniMedico = txtDNIMedico.Text;
            DateTime incorporacionMedico = dateTimeIncorporacionMedico.Value;
            string especialidadMedico = comboEspecialidadMedico.SelectedItem.ToString();

            Medico nuevoMedico = new Medico(nombreMedico, apellidoMedico, dniMedico, sueldoMedico, incorporacionMedico, especialidadMedico);
            medicos.Add(nuevoMedico);
            MessageBox.Show("Médico creado correctamente");
            LimpiarCamposMedico();
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
            if (string.IsNullOrWhiteSpace(txtNombreAdmin.Text) ||
       string.IsNullOrWhiteSpace(txtApellidosAdmin.Text) ||
       string.IsNullOrWhiteSpace(txtDNIAdmin.Text) ||
       string.IsNullOrWhiteSpace(txtSueldoAdmin.Text) ||
       comboDepartamentoAdmin.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtSueldoAdmin.Text, out double sueldoAdmin))
            {
                MessageBox.Show("El sueldo debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombreAdmin = txtNombreAdmin.Text;
            string apellidoAdmin = txtApellidosAdmin.Text;
            string dniAdmin = txtDNIAdmin.Text;
            DateTime incorporacionAdmin = dateTimeIncorporacionAdmin.Value;
            string deptAdmin = comboDepartamentoAdmin.Text;

            Administrativo nuevoAdmin = new Administrativo(nombreAdmin, apellidoAdmin, dniAdmin, sueldoAdmin, incorporacionAdmin, deptAdmin);
            administrativos.Add(nuevoAdmin);
            MessageBox.Show("Administrativo creado correctamente");
            LimpiarCamposAdmin();
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

            if (listPacientes.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este paciente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string pacienteSeleccionado = listPacientes.SelectedItem.ToString();
                    foreach (Paciente paciente in pacientes)
                    {
                        if (paciente.ToString() == pacienteSeleccionado)
                        {
                            pacientes.Remove(paciente);
                            MessageBox.Show("Paciente eliminado correctamente");
                            MostrarPacientes();
                            return;
                        }
                    }
                    MessageBox.Show("No se encontró el paciente seleccionado en la lista.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un paciente para borrar.");
            }

        }

        private void buttonCancelarPaciente_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cancelar y eliminar el contenido?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LimpiarCamposPaciente();
            }
        }

        private void LimpiarCamposPaciente()
        {
            txtNombrePaciente.Text = "";
            txtApellidosPaciente.Text = "";
            txtDNIPaciente.Text = "";
            dateFechaAltaPaciente.Value = DateTime.Now; 
            comboMedicoPaciente.SelectedIndex = -1;
            comboPlantaPaciente.SelectedIndex = -1;
            listMedicamentosPaciente.ClearSelected(); 
        }

        private void buttonCancelarMedico_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cancelar y eliminar el contenido?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LimpiarCamposMedico();
            }
        }

        private void buttonBorrarMedico_Click(object sender, EventArgs e)
        {
            if (listMedicos.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este médico?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string medicoSeleccionado = listMedicos.SelectedItem.ToString();
                    foreach (Medico medico in medicos)
                    {
                        if (medico.ToString() == medicoSeleccionado)
                        {
                            medicos.Remove(medico);
                            MessageBox.Show("Médico eliminado correctamente");
                            MostrarMedicos();
                            RefreshComboBoxPacientes();
                            return;
                        }
                    }
                    MessageBox.Show("No se encontró el médico seleccionado en la lista.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un médico para borrar.");
            }

        }

        private void buttonBorrarAdmin_Click(object sender, EventArgs e)
        {
            if (listAdmin.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este administrativo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string adminSeleccionado = listAdmin.SelectedItem.ToString();
                    foreach (Administrativo admin in administrativos)
                    {
                        if (admin.ToString() == adminSeleccionado)
                        {
                            administrativos.Remove(admin);
                            MessageBox.Show("Administrativo eliminado correctamente");
                            MostrarAdministrativos();
                            return;
                        }
                    }
                    MessageBox.Show("No se encontró el administrativo seleccionado en la lista.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un administrativo para borrar.");
            }
        }

        private void buttonCancelarAdmin_Click(object sender, EventArgs e)
        {            
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cancelar y eliminar el contenido?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        
            if (result == DialogResult.Yes)
            {
                LimpiarCamposAdmin();
            }
        }

        private void LimpiarCamposMedico()
        {
            txtNombreMedico.Text = "";
            txtApellidosMedico.Text = "";
            txtDNIMedico.Text = "";
            txtSueldoMedico.Text = "";
            dateTimeIncorporacionMedico.Value = DateTime.Now;
            comboEspecialidadMedico.SelectedIndex = -1;
        }

        private void LimpiarCamposAdmin()
        {
            txtNombreAdmin.Text = "";
            txtApellidosAdmin.Text = "";
            txtDNIAdmin.Text = "";
            txtSueldoAdmin.Text = "";
            dateTimeIncorporacionAdmin.Value = DateTime.Now;
            comboDepartamentoAdmin.SelectedIndex = -1;
        }

        private void MostrarMedicos()
        {
            listMedicos.Items.Clear();
            foreach (Medico medico in medicos)
            {
                listMedicos.Items.Add(medico.ToString());
            }
        }

        private void MostrarAdministrativos()
        {
            listAdmin.Items.Clear();
            foreach (Administrativo admin in administrativos)
            {
                listAdmin.Items.Add(admin.ToString());
            }
        }

    }
}
