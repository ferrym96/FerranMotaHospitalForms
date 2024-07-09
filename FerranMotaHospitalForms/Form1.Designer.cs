namespace FerranMotaHospitalForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNuevoPaciente = new System.Windows.Forms.Button();
            this.buttonNuevoMedico = new System.Windows.Forms.Button();
            this.buttonNuevoAdministrativo = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonListarPacientes = new System.Windows.Forms.Button();
            this.buttonListarMedicos = new System.Windows.Forms.Button();
            this.buttonListarAdmin = new System.Windows.Forms.Button();
            this.groupCrearPaciente = new System.Windows.Forms.GroupBox();
            this.comboMedicoPaciente = new System.Windows.Forms.ComboBox();
            this.buttonCancelarPaciente = new System.Windows.Forms.Button();
            this.buttonCrearPaciente = new System.Windows.Forms.Button();
            this.listMedicamentosPaciente = new System.Windows.Forms.ListBox();
            this.comboPlantaPaciente = new System.Windows.Forms.ComboBox();
            this.dateFechaAltaPaciente = new System.Windows.Forms.DateTimePicker();
            this.txtDNIPaciente = new System.Windows.Forms.TextBox();
            this.labelMedicamentosPaciente = new System.Windows.Forms.Label();
            this.labelMedicoPaciente = new System.Windows.Forms.Label();
            this.labelFechaAltaPaciente = new System.Windows.Forms.Label();
            this.labelPlantaPaciente = new System.Windows.Forms.Label();
            this.labelDNIPaciente = new System.Windows.Forms.Label();
            this.txtApellidosPaciente = new System.Windows.Forms.TextBox();
            this.labelApellidosPaciente = new System.Windows.Forms.Label();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.labelNombrePaciente = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupCrearMedico = new System.Windows.Forms.GroupBox();
            this.buttonCancelarMedico = new System.Windows.Forms.Button();
            this.buttonCrearMedico = new System.Windows.Forms.Button();
            this.comboEspecialidadMedico = new System.Windows.Forms.ComboBox();
            this.txtSueldoMedico = new System.Windows.Forms.TextBox();
            this.dateTimeIncorporacionMedico = new System.Windows.Forms.DateTimePicker();
            this.txtDNIMedico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSueldoMedico = new System.Windows.Forms.Label();
            this.labelIncorporacionMedico = new System.Windows.Forms.Label();
            this.labelEspMedico = new System.Windows.Forms.Label();
            this.labelDNIMedico = new System.Windows.Forms.Label();
            this.txtApellidosMedico = new System.Windows.Forms.TextBox();
            this.labelApellidosMedico = new System.Windows.Forms.Label();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.labelNombreMedico = new System.Windows.Forms.Label();
            this.groupCrearAdmin = new System.Windows.Forms.GroupBox();
            this.buttonCancelarAdmin = new System.Windows.Forms.Button();
            this.buttonCrearAdmin = new System.Windows.Forms.Button();
            this.comboDepartamentoAdmin = new System.Windows.Forms.ComboBox();
            this.txtSueldoAdmin = new System.Windows.Forms.TextBox();
            this.dateTimeIncorporacionAdmin = new System.Windows.Forms.DateTimePicker();
            this.txtDNIAdmin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSueldoAdmin = new System.Windows.Forms.Label();
            this.labelIncorporacionAdmin = new System.Windows.Forms.Label();
            this.labelDeptAdmin = new System.Windows.Forms.Label();
            this.labelDNIAdmin = new System.Windows.Forms.Label();
            this.txtApellidosAdmin = new System.Windows.Forms.TextBox();
            this.labelApellidosAdmin = new System.Windows.Forms.Label();
            this.txtNombreAdmin = new System.Windows.Forms.TextBox();
            this.labelNombreAdmin = new System.Windows.Forms.Label();
            this.groupListarPacientes = new System.Windows.Forms.GroupBox();
            this.buttonBorrarPaciente = new System.Windows.Forms.Button();
            this.groupListarMedicos = new System.Windows.Forms.GroupBox();
            this.buttonBorrarMedico = new System.Windows.Forms.Button();
            this.groupListarAdmin = new System.Windows.Forms.GroupBox();
            this.buttonBorrarAdmin = new System.Windows.Forms.Button();
            this.listPacientes = new System.Windows.Forms.ListBox();
            this.listMedicos = new System.Windows.Forms.ListBox();
            this.listAdmin = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupCrearPaciente.SuspendLayout();
            this.groupCrearMedico.SuspendLayout();
            this.groupCrearAdmin.SuspendLayout();
            this.groupListarPacientes.SuspendLayout();
            this.groupListarMedicos.SuspendLayout();
            this.groupListarAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNuevoPaciente
            // 
            this.buttonNuevoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevoPaciente.Location = new System.Drawing.Point(3, 3);
            this.buttonNuevoPaciente.Name = "buttonNuevoPaciente";
            this.buttonNuevoPaciente.Size = new System.Drawing.Size(130, 47);
            this.buttonNuevoPaciente.TabIndex = 0;
            this.buttonNuevoPaciente.Text = "Añadir paciente";
            this.buttonNuevoPaciente.UseVisualStyleBackColor = true;
            this.buttonNuevoPaciente.Click += new System.EventHandler(this.buttonNuevoPaciente_Click);
            // 
            // buttonNuevoMedico
            // 
            this.buttonNuevoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevoMedico.Location = new System.Drawing.Point(3, 56);
            this.buttonNuevoMedico.Name = "buttonNuevoMedico";
            this.buttonNuevoMedico.Size = new System.Drawing.Size(130, 47);
            this.buttonNuevoMedico.TabIndex = 1;
            this.buttonNuevoMedico.Text = "Añadir médico";
            this.buttonNuevoMedico.UseVisualStyleBackColor = true;
            this.buttonNuevoMedico.Click += new System.EventHandler(this.buttonNuevoMedico_Click);
            // 
            // buttonNuevoAdministrativo
            // 
            this.buttonNuevoAdministrativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevoAdministrativo.Location = new System.Drawing.Point(3, 109);
            this.buttonNuevoAdministrativo.Name = "buttonNuevoAdministrativo";
            this.buttonNuevoAdministrativo.Size = new System.Drawing.Size(130, 47);
            this.buttonNuevoAdministrativo.TabIndex = 2;
            this.buttonNuevoAdministrativo.Text = "Añadir administrativo";
            this.buttonNuevoAdministrativo.UseVisualStyleBackColor = true;
            this.buttonNuevoAdministrativo.Click += new System.EventHandler(this.buttonNuevoAdministrativo_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.buttonNuevoPaciente);
            this.flowLayoutPanel1.Controls.Add(this.buttonNuevoMedico);
            this.flowLayoutPanel1.Controls.Add(this.buttonNuevoAdministrativo);
            this.flowLayoutPanel1.Controls.Add(this.buttonListarPacientes);
            this.flowLayoutPanel1.Controls.Add(this.buttonListarMedicos);
            this.flowLayoutPanel1.Controls.Add(this.buttonListarAdmin);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(141, 337);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // buttonListarPacientes
            // 
            this.buttonListarPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListarPacientes.Location = new System.Drawing.Point(3, 162);
            this.buttonListarPacientes.Name = "buttonListarPacientes";
            this.buttonListarPacientes.Size = new System.Drawing.Size(130, 47);
            this.buttonListarPacientes.TabIndex = 3;
            this.buttonListarPacientes.Text = "Ver pacientes";
            this.buttonListarPacientes.UseVisualStyleBackColor = true;
            this.buttonListarPacientes.Click += new System.EventHandler(this.buttonListarPacientes_Click);
            // 
            // buttonListarMedicos
            // 
            this.buttonListarMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListarMedicos.Location = new System.Drawing.Point(3, 215);
            this.buttonListarMedicos.Name = "buttonListarMedicos";
            this.buttonListarMedicos.Size = new System.Drawing.Size(130, 47);
            this.buttonListarMedicos.TabIndex = 4;
            this.buttonListarMedicos.Text = "Ver médicos";
            this.buttonListarMedicos.UseVisualStyleBackColor = true;
            this.buttonListarMedicos.Click += new System.EventHandler(this.buttonListarMedicos_Click);
            // 
            // buttonListarAdmin
            // 
            this.buttonListarAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListarAdmin.Location = new System.Drawing.Point(3, 268);
            this.buttonListarAdmin.Name = "buttonListarAdmin";
            this.buttonListarAdmin.Size = new System.Drawing.Size(130, 49);
            this.buttonListarAdmin.TabIndex = 5;
            this.buttonListarAdmin.Text = "Ver administrativos";
            this.buttonListarAdmin.UseVisualStyleBackColor = true;
            this.buttonListarAdmin.Click += new System.EventHandler(this.buttonListarAdmin_Click);
            // 
            // groupCrearPaciente
            // 
            this.groupCrearPaciente.Controls.Add(this.comboMedicoPaciente);
            this.groupCrearPaciente.Controls.Add(this.buttonCancelarPaciente);
            this.groupCrearPaciente.Controls.Add(this.buttonCrearPaciente);
            this.groupCrearPaciente.Controls.Add(this.listMedicamentosPaciente);
            this.groupCrearPaciente.Controls.Add(this.comboPlantaPaciente);
            this.groupCrearPaciente.Controls.Add(this.dateFechaAltaPaciente);
            this.groupCrearPaciente.Controls.Add(this.txtDNIPaciente);
            this.groupCrearPaciente.Controls.Add(this.labelMedicamentosPaciente);
            this.groupCrearPaciente.Controls.Add(this.labelMedicoPaciente);
            this.groupCrearPaciente.Controls.Add(this.labelFechaAltaPaciente);
            this.groupCrearPaciente.Controls.Add(this.labelPlantaPaciente);
            this.groupCrearPaciente.Controls.Add(this.labelDNIPaciente);
            this.groupCrearPaciente.Controls.Add(this.txtApellidosPaciente);
            this.groupCrearPaciente.Controls.Add(this.labelApellidosPaciente);
            this.groupCrearPaciente.Controls.Add(this.txtNombrePaciente);
            this.groupCrearPaciente.Controls.Add(this.labelNombrePaciente);
            this.groupCrearPaciente.Location = new System.Drawing.Point(180, 14);
            this.groupCrearPaciente.Name = "groupCrearPaciente";
            this.groupCrearPaciente.Size = new System.Drawing.Size(461, 335);
            this.groupCrearPaciente.TabIndex = 4;
            this.groupCrearPaciente.TabStop = false;
            this.groupCrearPaciente.Text = "Añadir paciente";
            this.groupCrearPaciente.Visible = false;
            // 
            // comboMedicoPaciente
            // 
            this.comboMedicoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMedicoPaciente.FormattingEnabled = true;
            this.comboMedicoPaciente.Items.AddRange(new object[] {
            "--"});
            this.comboMedicoPaciente.Location = new System.Drawing.Point(251, 55);
            this.comboMedicoPaciente.Name = "comboMedicoPaciente";
            this.comboMedicoPaciente.Size = new System.Drawing.Size(180, 24);
            this.comboMedicoPaciente.TabIndex = 5;
            // 
            // buttonCancelarPaciente
            // 
            this.buttonCancelarPaciente.Location = new System.Drawing.Point(181, 286);
            this.buttonCancelarPaciente.Name = "buttonCancelarPaciente";
            this.buttonCancelarPaciente.Size = new System.Drawing.Size(112, 30);
            this.buttonCancelarPaciente.TabIndex = 9;
            this.buttonCancelarPaciente.Text = "Cancelar";
            this.buttonCancelarPaciente.UseVisualStyleBackColor = true;
            this.buttonCancelarPaciente.Click += new System.EventHandler(this.buttonCancelarPaciente_Click);
            // 
            // buttonCrearPaciente
            // 
            this.buttonCrearPaciente.Location = new System.Drawing.Point(318, 286);
            this.buttonCrearPaciente.Name = "buttonCrearPaciente";
            this.buttonCrearPaciente.Size = new System.Drawing.Size(113, 30);
            this.buttonCrearPaciente.TabIndex = 8;
            this.buttonCrearPaciente.Text = "Añadir paciente";
            this.buttonCrearPaciente.UseVisualStyleBackColor = true;
            this.buttonCrearPaciente.Click += new System.EventHandler(this.buttonCrearPaciente_Click);
            // 
            // listMedicamentosPaciente
            // 
            this.listMedicamentosPaciente.FormattingEnabled = true;
            this.listMedicamentosPaciente.ItemHeight = 16;
            this.listMedicamentosPaciente.Items.AddRange(new object[] {
            "Paracetamol",
            "Ibuprofeno",
            "Naproxeno",
            "Aspirina",
            "Tramadol",
            "Amoxicilina",
            "Azitromicina",
            "Ciprofloxacino",
            "Doxiciclina",
            "Cefalexina"});
            this.listMedicamentosPaciente.Location = new System.Drawing.Point(251, 159);
            this.listMedicamentosPaciente.Name = "listMedicamentosPaciente";
            this.listMedicamentosPaciente.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listMedicamentosPaciente.Size = new System.Drawing.Size(180, 84);
            this.listMedicamentosPaciente.TabIndex = 7;
            // 
            // comboPlantaPaciente
            // 
            this.comboPlantaPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPlantaPaciente.FormattingEnabled = true;
            this.comboPlantaPaciente.Items.AddRange(new object[] {
            "Planta baja - Recepción y Admisión",
            "1ª planta - Medicina Interna",
            "2ª planta - Cirugía y Cuidados Postoperatorios",
            "3ª planta - Pediatría y Neonatología",
            "4ª planta - Obstetricia y Ginecología",
            "5ª planta - Oncología",
            "6ª planta - Traumatología y Rehabilitación",
            "7ª planta - Neurología y Neurocirugía",
            "8ª planta - Psiquiatría y Salud Mental",
            "9ª planta - Cardiología y Cirugía Cardiovascular",
            "10ª planta - Geriatría y Cuidados Paliativos"});
            this.comboPlantaPaciente.Location = new System.Drawing.Point(251, 108);
            this.comboPlantaPaciente.Name = "comboPlantaPaciente";
            this.comboPlantaPaciente.Size = new System.Drawing.Size(180, 24);
            this.comboPlantaPaciente.TabIndex = 6;
            // 
            // dateFechaAltaPaciente
            // 
            this.dateFechaAltaPaciente.Location = new System.Drawing.Point(28, 221);
            this.dateFechaAltaPaciente.Name = "dateFechaAltaPaciente";
            this.dateFechaAltaPaciente.Size = new System.Drawing.Size(180, 22);
            this.dateFechaAltaPaciente.TabIndex = 4;
            // 
            // txtDNIPaciente
            // 
            this.txtDNIPaciente.Location = new System.Drawing.Point(28, 159);
            this.txtDNIPaciente.Name = "txtDNIPaciente";
            this.txtDNIPaciente.Size = new System.Drawing.Size(180, 22);
            this.txtDNIPaciente.TabIndex = 3;
            // 
            // labelMedicamentosPaciente
            // 
            this.labelMedicamentosPaciente.AutoSize = true;
            this.labelMedicamentosPaciente.Location = new System.Drawing.Point(248, 139);
            this.labelMedicamentosPaciente.Name = "labelMedicamentosPaciente";
            this.labelMedicamentosPaciente.Size = new System.Drawing.Size(146, 16);
            this.labelMedicamentosPaciente.TabIndex = 8;
            this.labelMedicamentosPaciente.Text = "Lista de medicamentos";
            // 
            // labelMedicoPaciente
            // 
            this.labelMedicoPaciente.AutoSize = true;
            this.labelMedicoPaciente.Location = new System.Drawing.Point(248, 35);
            this.labelMedicoPaciente.Name = "labelMedicoPaciente";
            this.labelMedicoPaciente.Size = new System.Drawing.Size(52, 16);
            this.labelMedicoPaciente.TabIndex = 7;
            this.labelMedicoPaciente.Text = "Médico";
            // 
            // labelFechaAltaPaciente
            // 
            this.labelFechaAltaPaciente.AutoSize = true;
            this.labelFechaAltaPaciente.Location = new System.Drawing.Point(25, 193);
            this.labelFechaAltaPaciente.Name = "labelFechaAltaPaciente";
            this.labelFechaAltaPaciente.Size = new System.Drawing.Size(89, 16);
            this.labelFechaAltaPaciente.TabIndex = 6;
            this.labelFechaAltaPaciente.Text = "Fecha de alta";
            // 
            // labelPlantaPaciente
            // 
            this.labelPlantaPaciente.AutoSize = true;
            this.labelPlantaPaciente.Location = new System.Drawing.Point(248, 86);
            this.labelPlantaPaciente.Name = "labelPlantaPaciente";
            this.labelPlantaPaciente.Size = new System.Drawing.Size(45, 16);
            this.labelPlantaPaciente.TabIndex = 5;
            this.labelPlantaPaciente.Text = "Planta";
            // 
            // labelDNIPaciente
            // 
            this.labelDNIPaciente.AutoSize = true;
            this.labelDNIPaciente.Location = new System.Drawing.Point(25, 139);
            this.labelDNIPaciente.Name = "labelDNIPaciente";
            this.labelDNIPaciente.Size = new System.Drawing.Size(30, 16);
            this.labelDNIPaciente.TabIndex = 4;
            this.labelDNIPaciente.Text = "DNI";
            // 
            // txtApellidosPaciente
            // 
            this.txtApellidosPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidosPaciente.Location = new System.Drawing.Point(28, 108);
            this.txtApellidosPaciente.Name = "txtApellidosPaciente";
            this.txtApellidosPaciente.Size = new System.Drawing.Size(180, 23);
            this.txtApellidosPaciente.TabIndex = 2;
            // 
            // labelApellidosPaciente
            // 
            this.labelApellidosPaciente.AutoSize = true;
            this.labelApellidosPaciente.Location = new System.Drawing.Point(25, 86);
            this.labelApellidosPaciente.Name = "labelApellidosPaciente";
            this.labelApellidosPaciente.Size = new System.Drawing.Size(64, 16);
            this.labelApellidosPaciente.TabIndex = 2;
            this.labelApellidosPaciente.Text = "Apellidos";
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(28, 55);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(180, 22);
            this.txtNombrePaciente.TabIndex = 1;
            // 
            // labelNombrePaciente
            // 
            this.labelNombrePaciente.AutoSize = true;
            this.labelNombrePaciente.Location = new System.Drawing.Point(25, 35);
            this.labelNombrePaciente.Name = "labelNombrePaciente";
            this.labelNombrePaciente.Size = new System.Drawing.Size(56, 16);
            this.labelNombrePaciente.TabIndex = 0;
            this.labelNombrePaciente.Text = "Nombre";
            // 
            // groupCrearMedico
            // 
            this.groupCrearMedico.Controls.Add(this.buttonCancelarMedico);
            this.groupCrearMedico.Controls.Add(this.buttonCrearMedico);
            this.groupCrearMedico.Controls.Add(this.comboEspecialidadMedico);
            this.groupCrearMedico.Controls.Add(this.txtSueldoMedico);
            this.groupCrearMedico.Controls.Add(this.dateTimeIncorporacionMedico);
            this.groupCrearMedico.Controls.Add(this.txtDNIMedico);
            this.groupCrearMedico.Controls.Add(this.label1);
            this.groupCrearMedico.Controls.Add(this.labelSueldoMedico);
            this.groupCrearMedico.Controls.Add(this.labelIncorporacionMedico);
            this.groupCrearMedico.Controls.Add(this.labelEspMedico);
            this.groupCrearMedico.Controls.Add(this.labelDNIMedico);
            this.groupCrearMedico.Controls.Add(this.txtApellidosMedico);
            this.groupCrearMedico.Controls.Add(this.labelApellidosMedico);
            this.groupCrearMedico.Controls.Add(this.txtNombreMedico);
            this.groupCrearMedico.Controls.Add(this.labelNombreMedico);
            this.groupCrearMedico.Location = new System.Drawing.Point(690, 16);
            this.groupCrearMedico.Name = "groupCrearMedico";
            this.groupCrearMedico.Size = new System.Drawing.Size(461, 333);
            this.groupCrearMedico.TabIndex = 16;
            this.groupCrearMedico.TabStop = false;
            this.groupCrearMedico.Text = "Añadir médico";
            this.groupCrearMedico.Visible = false;
            // 
            // buttonCancelarMedico
            // 
            this.buttonCancelarMedico.Location = new System.Drawing.Point(181, 286);
            this.buttonCancelarMedico.Name = "buttonCancelarMedico";
            this.buttonCancelarMedico.Size = new System.Drawing.Size(112, 30);
            this.buttonCancelarMedico.TabIndex = 15;
            this.buttonCancelarMedico.Text = "Cancelar";
            this.buttonCancelarMedico.UseVisualStyleBackColor = true;
            this.buttonCancelarMedico.Click += new System.EventHandler(this.buttonCancelarMedico_Click);
            // 
            // buttonCrearMedico
            // 
            this.buttonCrearMedico.Location = new System.Drawing.Point(318, 286);
            this.buttonCrearMedico.Name = "buttonCrearMedico";
            this.buttonCrearMedico.Size = new System.Drawing.Size(113, 30);
            this.buttonCrearMedico.TabIndex = 14;
            this.buttonCrearMedico.Text = "Añadir médico";
            this.buttonCrearMedico.UseVisualStyleBackColor = true;
            this.buttonCrearMedico.Click += new System.EventHandler(this.buttonCrearMedico_Click);
            // 
            // comboEspecialidadMedico
            // 
            this.comboEspecialidadMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEspecialidadMedico.FormattingEnabled = true;
            this.comboEspecialidadMedico.Items.AddRange(new object[] {
            "Cirujano",
            "Pediatría",
            "Ginecología",
            "Oncología",
            "Traumatología",
            "Neurología",
            "Psiquiatría",
            "Cardiología",
            "Geriatría"});
            this.comboEspecialidadMedico.Location = new System.Drawing.Point(251, 108);
            this.comboEspecialidadMedico.Name = "comboEspecialidadMedico";
            this.comboEspecialidadMedico.Size = new System.Drawing.Size(180, 24);
            this.comboEspecialidadMedico.TabIndex = 12;
            // 
            // txtSueldoMedico
            // 
            this.txtSueldoMedico.Location = new System.Drawing.Point(251, 55);
            this.txtSueldoMedico.Name = "txtSueldoMedico";
            this.txtSueldoMedico.Size = new System.Drawing.Size(180, 22);
            this.txtSueldoMedico.TabIndex = 11;
            // 
            // dateTimeIncorporacionMedico
            // 
            this.dateTimeIncorporacionMedico.Location = new System.Drawing.Point(28, 221);
            this.dateTimeIncorporacionMedico.Name = "dateTimeIncorporacionMedico";
            this.dateTimeIncorporacionMedico.Size = new System.Drawing.Size(180, 22);
            this.dateTimeIncorporacionMedico.TabIndex = 10;
            // 
            // txtDNIMedico
            // 
            this.txtDNIMedico.Location = new System.Drawing.Point(28, 159);
            this.txtDNIMedico.Name = "txtDNIMedico";
            this.txtDNIMedico.Size = new System.Drawing.Size(180, 22);
            this.txtDNIMedico.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 8;
            // 
            // labelSueldoMedico
            // 
            this.labelSueldoMedico.AutoSize = true;
            this.labelSueldoMedico.Location = new System.Drawing.Point(248, 35);
            this.labelSueldoMedico.Name = "labelSueldoMedico";
            this.labelSueldoMedico.Size = new System.Drawing.Size(50, 16);
            this.labelSueldoMedico.TabIndex = 7;
            this.labelSueldoMedico.Text = "Sueldo";
            // 
            // labelIncorporacionMedico
            // 
            this.labelIncorporacionMedico.AutoSize = true;
            this.labelIncorporacionMedico.Location = new System.Drawing.Point(25, 193);
            this.labelIncorporacionMedico.Name = "labelIncorporacionMedico";
            this.labelIncorporacionMedico.Size = new System.Drawing.Size(149, 16);
            this.labelIncorporacionMedico.TabIndex = 6;
            this.labelIncorporacionMedico.Text = "Fecha de incorporación";
            // 
            // labelEspMedico
            // 
            this.labelEspMedico.AutoSize = true;
            this.labelEspMedico.Location = new System.Drawing.Point(248, 86);
            this.labelEspMedico.Name = "labelEspMedico";
            this.labelEspMedico.Size = new System.Drawing.Size(87, 16);
            this.labelEspMedico.TabIndex = 5;
            this.labelEspMedico.Text = "Especialidad";
            // 
            // labelDNIMedico
            // 
            this.labelDNIMedico.AutoSize = true;
            this.labelDNIMedico.Location = new System.Drawing.Point(25, 139);
            this.labelDNIMedico.Name = "labelDNIMedico";
            this.labelDNIMedico.Size = new System.Drawing.Size(30, 16);
            this.labelDNIMedico.TabIndex = 4;
            this.labelDNIMedico.Text = "DNI";
            // 
            // txtApellidosMedico
            // 
            this.txtApellidosMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidosMedico.Location = new System.Drawing.Point(28, 108);
            this.txtApellidosMedico.Name = "txtApellidosMedico";
            this.txtApellidosMedico.Size = new System.Drawing.Size(180, 23);
            this.txtApellidosMedico.TabIndex = 3;
            // 
            // labelApellidosMedico
            // 
            this.labelApellidosMedico.AutoSize = true;
            this.labelApellidosMedico.Location = new System.Drawing.Point(25, 86);
            this.labelApellidosMedico.Name = "labelApellidosMedico";
            this.labelApellidosMedico.Size = new System.Drawing.Size(64, 16);
            this.labelApellidosMedico.TabIndex = 2;
            this.labelApellidosMedico.Text = "Apellidos";
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Location = new System.Drawing.Point(28, 55);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.Size = new System.Drawing.Size(180, 22);
            this.txtNombreMedico.TabIndex = 1;
            // 
            // labelNombreMedico
            // 
            this.labelNombreMedico.AutoSize = true;
            this.labelNombreMedico.Location = new System.Drawing.Point(25, 35);
            this.labelNombreMedico.Name = "labelNombreMedico";
            this.labelNombreMedico.Size = new System.Drawing.Size(56, 16);
            this.labelNombreMedico.TabIndex = 0;
            this.labelNombreMedico.Text = "Nombre";
            // 
            // groupCrearAdmin
            // 
            this.groupCrearAdmin.Controls.Add(this.buttonCancelarAdmin);
            this.groupCrearAdmin.Controls.Add(this.buttonCrearAdmin);
            this.groupCrearAdmin.Controls.Add(this.comboDepartamentoAdmin);
            this.groupCrearAdmin.Controls.Add(this.txtSueldoAdmin);
            this.groupCrearAdmin.Controls.Add(this.dateTimeIncorporacionAdmin);
            this.groupCrearAdmin.Controls.Add(this.txtDNIAdmin);
            this.groupCrearAdmin.Controls.Add(this.label2);
            this.groupCrearAdmin.Controls.Add(this.labelSueldoAdmin);
            this.groupCrearAdmin.Controls.Add(this.labelIncorporacionAdmin);
            this.groupCrearAdmin.Controls.Add(this.labelDeptAdmin);
            this.groupCrearAdmin.Controls.Add(this.labelDNIAdmin);
            this.groupCrearAdmin.Controls.Add(this.txtApellidosAdmin);
            this.groupCrearAdmin.Controls.Add(this.labelApellidosAdmin);
            this.groupCrearAdmin.Controls.Add(this.txtNombreAdmin);
            this.groupCrearAdmin.Controls.Add(this.labelNombreAdmin);
            this.groupCrearAdmin.Location = new System.Drawing.Point(1208, 16);
            this.groupCrearAdmin.Name = "groupCrearAdmin";
            this.groupCrearAdmin.Size = new System.Drawing.Size(461, 333);
            this.groupCrearAdmin.TabIndex = 17;
            this.groupCrearAdmin.TabStop = false;
            this.groupCrearAdmin.Text = "Añadir administrativo";
            this.groupCrearAdmin.Visible = false;
            // 
            // buttonCancelarAdmin
            // 
            this.buttonCancelarAdmin.Location = new System.Drawing.Point(181, 275);
            this.buttonCancelarAdmin.Name = "buttonCancelarAdmin";
            this.buttonCancelarAdmin.Size = new System.Drawing.Size(112, 41);
            this.buttonCancelarAdmin.TabIndex = 15;
            this.buttonCancelarAdmin.Text = "Cancelar";
            this.buttonCancelarAdmin.UseVisualStyleBackColor = true;
            this.buttonCancelarAdmin.Click += new System.EventHandler(this.buttonCancelarAdmin_Click);
            // 
            // buttonCrearAdmin
            // 
            this.buttonCrearAdmin.Location = new System.Drawing.Point(318, 275);
            this.buttonCrearAdmin.Name = "buttonCrearAdmin";
            this.buttonCrearAdmin.Size = new System.Drawing.Size(113, 41);
            this.buttonCrearAdmin.TabIndex = 14;
            this.buttonCrearAdmin.Text = "Añadir administrativo";
            this.buttonCrearAdmin.UseVisualStyleBackColor = true;
            this.buttonCrearAdmin.Click += new System.EventHandler(this.buttonCrearAdmin_Click);
            // 
            // comboDepartamentoAdmin
            // 
            this.comboDepartamentoAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDepartamentoAdmin.FormattingEnabled = true;
            this.comboDepartamentoAdmin.Items.AddRange(new object[] {
            "Dirección General",
            "Recursos Humanos",
            "Finanzas",
            "Tecnología de la Información (IT)",
            "Calidad y Seguridad del Paciente",
            "Facturación y Codificación Médica",
            "Compras y Logística",
            "Relaciones Públicas y Comunicaciones",
            "Servicios Generales",
            "Legal y Cumplimiento"});
            this.comboDepartamentoAdmin.Location = new System.Drawing.Point(251, 108);
            this.comboDepartamentoAdmin.Name = "comboDepartamentoAdmin";
            this.comboDepartamentoAdmin.Size = new System.Drawing.Size(180, 24);
            this.comboDepartamentoAdmin.TabIndex = 12;
            // 
            // txtSueldoAdmin
            // 
            this.txtSueldoAdmin.Location = new System.Drawing.Point(251, 55);
            this.txtSueldoAdmin.Name = "txtSueldoAdmin";
            this.txtSueldoAdmin.Size = new System.Drawing.Size(180, 22);
            this.txtSueldoAdmin.TabIndex = 11;
            // 
            // dateTimeIncorporacionAdmin
            // 
            this.dateTimeIncorporacionAdmin.Location = new System.Drawing.Point(28, 221);
            this.dateTimeIncorporacionAdmin.Name = "dateTimeIncorporacionAdmin";
            this.dateTimeIncorporacionAdmin.Size = new System.Drawing.Size(180, 22);
            this.dateTimeIncorporacionAdmin.TabIndex = 10;
            // 
            // txtDNIAdmin
            // 
            this.txtDNIAdmin.Location = new System.Drawing.Point(28, 159);
            this.txtDNIAdmin.Name = "txtDNIAdmin";
            this.txtDNIAdmin.Size = new System.Drawing.Size(180, 22);
            this.txtDNIAdmin.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 8;
            // 
            // labelSueldoAdmin
            // 
            this.labelSueldoAdmin.AutoSize = true;
            this.labelSueldoAdmin.Location = new System.Drawing.Point(248, 35);
            this.labelSueldoAdmin.Name = "labelSueldoAdmin";
            this.labelSueldoAdmin.Size = new System.Drawing.Size(50, 16);
            this.labelSueldoAdmin.TabIndex = 7;
            this.labelSueldoAdmin.Text = "Sueldo";
            // 
            // labelIncorporacionAdmin
            // 
            this.labelIncorporacionAdmin.AutoSize = true;
            this.labelIncorporacionAdmin.Location = new System.Drawing.Point(25, 193);
            this.labelIncorporacionAdmin.Name = "labelIncorporacionAdmin";
            this.labelIncorporacionAdmin.Size = new System.Drawing.Size(149, 16);
            this.labelIncorporacionAdmin.TabIndex = 6;
            this.labelIncorporacionAdmin.Text = "Fecha de incorporación";
            // 
            // labelDeptAdmin
            // 
            this.labelDeptAdmin.AutoSize = true;
            this.labelDeptAdmin.Location = new System.Drawing.Point(248, 86);
            this.labelDeptAdmin.Name = "labelDeptAdmin";
            this.labelDeptAdmin.Size = new System.Drawing.Size(93, 16);
            this.labelDeptAdmin.TabIndex = 5;
            this.labelDeptAdmin.Text = "Departamento";
            // 
            // labelDNIAdmin
            // 
            this.labelDNIAdmin.AutoSize = true;
            this.labelDNIAdmin.Location = new System.Drawing.Point(25, 139);
            this.labelDNIAdmin.Name = "labelDNIAdmin";
            this.labelDNIAdmin.Size = new System.Drawing.Size(30, 16);
            this.labelDNIAdmin.TabIndex = 4;
            this.labelDNIAdmin.Text = "DNI";
            // 
            // txtApellidosAdmin
            // 
            this.txtApellidosAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidosAdmin.Location = new System.Drawing.Point(28, 108);
            this.txtApellidosAdmin.Name = "txtApellidosAdmin";
            this.txtApellidosAdmin.Size = new System.Drawing.Size(180, 23);
            this.txtApellidosAdmin.TabIndex = 3;
            // 
            // labelApellidosAdmin
            // 
            this.labelApellidosAdmin.AutoSize = true;
            this.labelApellidosAdmin.Location = new System.Drawing.Point(25, 86);
            this.labelApellidosAdmin.Name = "labelApellidosAdmin";
            this.labelApellidosAdmin.Size = new System.Drawing.Size(64, 16);
            this.labelApellidosAdmin.TabIndex = 2;
            this.labelApellidosAdmin.Text = "Apellidos";
            // 
            // txtNombreAdmin
            // 
            this.txtNombreAdmin.Location = new System.Drawing.Point(28, 55);
            this.txtNombreAdmin.Name = "txtNombreAdmin";
            this.txtNombreAdmin.Size = new System.Drawing.Size(180, 22);
            this.txtNombreAdmin.TabIndex = 1;
            // 
            // labelNombreAdmin
            // 
            this.labelNombreAdmin.AutoSize = true;
            this.labelNombreAdmin.Location = new System.Drawing.Point(25, 35);
            this.labelNombreAdmin.Name = "labelNombreAdmin";
            this.labelNombreAdmin.Size = new System.Drawing.Size(56, 16);
            this.labelNombreAdmin.TabIndex = 0;
            this.labelNombreAdmin.Text = "Nombre";
            // 
            // groupListarPacientes
            // 
            this.groupListarPacientes.Controls.Add(this.listPacientes);
            this.groupListarPacientes.Controls.Add(this.buttonBorrarPaciente);
            this.groupListarPacientes.Location = new System.Drawing.Point(180, 385);
            this.groupListarPacientes.Name = "groupListarPacientes";
            this.groupListarPacientes.Size = new System.Drawing.Size(461, 335);
            this.groupListarPacientes.TabIndex = 16;
            this.groupListarPacientes.TabStop = false;
            this.groupListarPacientes.Text = "Ver pacientes";
            this.groupListarPacientes.Visible = false;
            // 
            // buttonBorrarPaciente
            // 
            this.buttonBorrarPaciente.Location = new System.Drawing.Point(327, 286);
            this.buttonBorrarPaciente.Name = "buttonBorrarPaciente";
            this.buttonBorrarPaciente.Size = new System.Drawing.Size(113, 30);
            this.buttonBorrarPaciente.TabIndex = 14;
            this.buttonBorrarPaciente.Text = "Borrar paciente";
            this.buttonBorrarPaciente.UseVisualStyleBackColor = true;
            this.buttonBorrarPaciente.Click += new System.EventHandler(this.buttonBorrarPaciente_Click);
            // 
            // groupListarMedicos
            // 
            this.groupListarMedicos.Controls.Add(this.listMedicos);
            this.groupListarMedicos.Controls.Add(this.buttonBorrarMedico);
            this.groupListarMedicos.Location = new System.Drawing.Point(690, 385);
            this.groupListarMedicos.Name = "groupListarMedicos";
            this.groupListarMedicos.Size = new System.Drawing.Size(461, 335);
            this.groupListarMedicos.TabIndex = 17;
            this.groupListarMedicos.TabStop = false;
            this.groupListarMedicos.Text = "Ver médicos";
            this.groupListarMedicos.Visible = false;
            // 
            // buttonBorrarMedico
            // 
            this.buttonBorrarMedico.Location = new System.Drawing.Point(327, 286);
            this.buttonBorrarMedico.Name = "buttonBorrarMedico";
            this.buttonBorrarMedico.Size = new System.Drawing.Size(113, 30);
            this.buttonBorrarMedico.TabIndex = 14;
            this.buttonBorrarMedico.Text = "Borrar médico";
            this.buttonBorrarMedico.UseVisualStyleBackColor = true;
            this.buttonBorrarMedico.Click += new System.EventHandler(this.buttonBorrarMedico_Click);
            // 
            // groupListarAdmin
            // 
            this.groupListarAdmin.Controls.Add(this.listAdmin);
            this.groupListarAdmin.Controls.Add(this.buttonBorrarAdmin);
            this.groupListarAdmin.Location = new System.Drawing.Point(1208, 385);
            this.groupListarAdmin.Name = "groupListarAdmin";
            this.groupListarAdmin.Size = new System.Drawing.Size(461, 335);
            this.groupListarAdmin.TabIndex = 18;
            this.groupListarAdmin.TabStop = false;
            this.groupListarAdmin.Text = "Ver administrativos";
            this.groupListarAdmin.Visible = false;
            // 
            // buttonBorrarAdmin
            // 
            this.buttonBorrarAdmin.Location = new System.Drawing.Point(298, 286);
            this.buttonBorrarAdmin.Name = "buttonBorrarAdmin";
            this.buttonBorrarAdmin.Size = new System.Drawing.Size(142, 30);
            this.buttonBorrarAdmin.TabIndex = 14;
            this.buttonBorrarAdmin.Text = "Borrar administrativo";
            this.buttonBorrarAdmin.UseVisualStyleBackColor = true;
            this.buttonBorrarAdmin.Click += new System.EventHandler(this.buttonBorrarAdmin_Click);
            // 
            // listPacientes
            // 
            this.listPacientes.FormattingEnabled = true;
            this.listPacientes.ItemHeight = 16;
            this.listPacientes.Location = new System.Drawing.Point(20, 36);
            this.listPacientes.Name = "listPacientes";
            this.listPacientes.Size = new System.Drawing.Size(420, 244);
            this.listPacientes.TabIndex = 15;
            // 
            // listMedicos
            // 
            this.listMedicos.FormattingEnabled = true;
            this.listMedicos.ItemHeight = 16;
            this.listMedicos.Location = new System.Drawing.Point(20, 36);
            this.listMedicos.Name = "listMedicos";
            this.listMedicos.Size = new System.Drawing.Size(420, 244);
            this.listMedicos.TabIndex = 15;
            // 
            // listAdmin
            // 
            this.listAdmin.FormattingEnabled = true;
            this.listAdmin.ItemHeight = 16;
            this.listAdmin.Location = new System.Drawing.Point(20, 36);
            this.listAdmin.Name = "listAdmin";
            this.listAdmin.Size = new System.Drawing.Size(420, 244);
            this.listAdmin.TabIndex = 16;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(659, 364);
            this.Controls.Add(this.groupListarAdmin);
            this.Controls.Add(this.groupListarMedicos);
            this.Controls.Add(this.groupListarPacientes);
            this.Controls.Add(this.groupCrearAdmin);
            this.Controls.Add(this.groupCrearMedico);
            this.Controls.Add(this.groupCrearPaciente);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Hospital Management";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupCrearPaciente.ResumeLayout(false);
            this.groupCrearPaciente.PerformLayout();
            this.groupCrearMedico.ResumeLayout(false);
            this.groupCrearMedico.PerformLayout();
            this.groupCrearAdmin.ResumeLayout(false);
            this.groupCrearAdmin.PerformLayout();
            this.groupListarPacientes.ResumeLayout(false);
            this.groupListarMedicos.ResumeLayout(false);
            this.groupListarAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button buttonNuevoPaciente;
        private System.Windows.Forms.Button buttonNuevoMedico;
        private System.Windows.Forms.Button buttonNuevoAdministrativo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupCrearPaciente;
        private System.Windows.Forms.Label labelNombrePaciente;
        private System.Windows.Forms.TextBox txtDNIPaciente;
        private System.Windows.Forms.Label labelMedicamentosPaciente;
        private System.Windows.Forms.Label labelMedicoPaciente;
        private System.Windows.Forms.Label labelFechaAltaPaciente;
        private System.Windows.Forms.Label labelPlantaPaciente;
        private System.Windows.Forms.Label labelDNIPaciente;
        private System.Windows.Forms.TextBox txtApellidosPaciente;
        private System.Windows.Forms.Label labelApellidosPaciente;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.ComboBox comboPlantaPaciente;
        private System.Windows.Forms.DateTimePicker dateFechaAltaPaciente;
        private System.Windows.Forms.ListBox listMedicamentosPaciente;
        private System.Windows.Forms.Button buttonCancelarPaciente;
        private System.Windows.Forms.Button buttonCrearPaciente;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupCrearMedico;
        private System.Windows.Forms.Button buttonCancelarMedico;
        private System.Windows.Forms.Button buttonCrearMedico;
        private System.Windows.Forms.ComboBox comboEspecialidadMedico;
        private System.Windows.Forms.TextBox txtSueldoMedico;
        private System.Windows.Forms.DateTimePicker dateTimeIncorporacionMedico;
        private System.Windows.Forms.TextBox txtDNIMedico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSueldoMedico;
        private System.Windows.Forms.Label labelIncorporacionMedico;
        private System.Windows.Forms.Label labelEspMedico;
        private System.Windows.Forms.Label labelDNIMedico;
        private System.Windows.Forms.TextBox txtApellidosMedico;
        private System.Windows.Forms.Label labelApellidosMedico;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.Label labelNombreMedico;
        private System.Windows.Forms.GroupBox groupCrearAdmin;
        private System.Windows.Forms.Button buttonCancelarAdmin;
        private System.Windows.Forms.Button buttonCrearAdmin;
        private System.Windows.Forms.ComboBox comboDepartamentoAdmin;
        private System.Windows.Forms.TextBox txtSueldoAdmin;
        private System.Windows.Forms.DateTimePicker dateTimeIncorporacionAdmin;
        private System.Windows.Forms.TextBox txtDNIAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSueldoAdmin;
        private System.Windows.Forms.Label labelIncorporacionAdmin;
        private System.Windows.Forms.Label labelDeptAdmin;
        private System.Windows.Forms.Label labelDNIAdmin;
        private System.Windows.Forms.TextBox txtApellidosAdmin;
        private System.Windows.Forms.Label labelApellidosAdmin;
        private System.Windows.Forms.TextBox txtNombreAdmin;
        private System.Windows.Forms.Label labelNombreAdmin;
        private System.Windows.Forms.Button buttonListarPacientes;
        private System.Windows.Forms.Button buttonListarMedicos;
        private System.Windows.Forms.Button buttonListarAdmin;
        private System.Windows.Forms.GroupBox groupListarPacientes;
        private System.Windows.Forms.Button buttonBorrarPaciente;
        private System.Windows.Forms.GroupBox groupListarMedicos;
        private System.Windows.Forms.Button buttonBorrarMedico;
        private System.Windows.Forms.GroupBox groupListarAdmin;
        private System.Windows.Forms.Button buttonBorrarAdmin;
        private System.Windows.Forms.ComboBox comboMedicoPaciente;
        private System.Windows.Forms.ListBox listPacientes;
        private System.Windows.Forms.ListBox listMedicos;
        private System.Windows.Forms.ListBox listAdmin;
    }

        #endregion
    }


