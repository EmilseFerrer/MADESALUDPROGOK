namespace PRESENTACION
{
    partial class MADEsalud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MADEsalud));
            this.tbTURNOS = new System.Windows.Forms.TabControl();
            this.tpHC = new System.Windows.Forms.TabPage();
            this.btnAsignarTurno = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dGVListaPacientes = new System.Windows.Forms.DataGridView();
            this.HC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblregistrarp = new System.Windows.Forms.Label();
            this.tpTURNOS = new System.Windows.Forms.TabPage();
            this.btnAceptarTurno = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblMostrarTurno = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.dTPTurno = new System.Windows.Forms.DateTimePicker();
            this.lblDNITurnos = new System.Windows.Forms.Label();
            this.lblApellidoTurnos = new System.Windows.Forms.Label();
            this.lblNombreturnos = new System.Windows.Forms.Label();
            this.lblHCTurnos = new System.Windows.Forms.Label();
            this.txtDNITurnos = new System.Windows.Forms.TextBox();
            this.txtApellidoTurnos = new System.Windows.Forms.TextBox();
            this.txtNombreTurnos = new System.Windows.Forms.TextBox();
            this.txtHCturnos = new System.Windows.Forms.TextBox();
            this.dgvturnos = new System.Windows.Forms.DataGridView();
            this.tbTURNOS.SuspendLayout();
            this.tpHC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListaPacientes)).BeginInit();
            this.tpTURNOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvturnos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTURNOS
            // 
            this.tbTURNOS.Controls.Add(this.tpHC);
            this.tbTURNOS.Controls.Add(this.tpTURNOS);
            this.tbTURNOS.Location = new System.Drawing.Point(12, 12);
            this.tbTURNOS.Name = "tbTURNOS";
            this.tbTURNOS.SelectedIndex = 0;
            this.tbTURNOS.Size = new System.Drawing.Size(776, 433);
            this.tbTURNOS.TabIndex = 0;
            // 
            // tpHC
            // 
            this.tpHC.Controls.Add(this.btnAsignarTurno);
            this.tpHC.Controls.Add(this.btnEliminar);
            this.tpHC.Controls.Add(this.pictureBox1);
            this.tpHC.Controls.Add(this.btnRegistrar);
            this.tpHC.Controls.Add(this.btnModificar);
            this.tpHC.Controls.Add(this.dGVListaPacientes);
            this.tpHC.Controls.Add(this.label1);
            this.tpHC.Controls.Add(this.dtpFechaNac);
            this.tpHC.Controls.Add(this.lblTelefono);
            this.tpHC.Controls.Add(this.txtTelefono);
            this.tpHC.Controls.Add(this.lblDireccion);
            this.tpHC.Controls.Add(this.lblDNI);
            this.tpHC.Controls.Add(this.lblApellido);
            this.tpHC.Controls.Add(this.lblNombre);
            this.tpHC.Controls.Add(this.txtDireccion);
            this.tpHC.Controls.Add(this.txtDNI);
            this.tpHC.Controls.Add(this.txtApellido);
            this.tpHC.Controls.Add(this.txtNombre);
            this.tpHC.Controls.Add(this.lblregistrarp);
            this.tpHC.Location = new System.Drawing.Point(4, 22);
            this.tpHC.Name = "tpHC";
            this.tpHC.Padding = new System.Windows.Forms.Padding(3);
            this.tpHC.Size = new System.Drawing.Size(768, 407);
            this.tpHC.TabIndex = 0;
            this.tpHC.Text = "HC";
            this.tpHC.UseVisualStyleBackColor = true;
            // 
            // btnAsignarTurno
            // 
            this.btnAsignarTurno.Location = new System.Drawing.Point(607, 352);
            this.btnAsignarTurno.Name = "btnAsignarTurno";
            this.btnAsignarTurno.Size = new System.Drawing.Size(127, 23);
            this.btnAsignarTurno.TabIndex = 17;
            this.btnAsignarTurno.Text = "Asignar Turno";
            this.btnAsignarTurno.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(113, 352);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(634, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(161, 143);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(101, 23);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(21, 352);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // dGVListaPacientes
            // 
            this.dGVListaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVListaPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HC,
            this.Nombre,
            this.Apellido,
            this.DNI,
            this.Dirección,
            this.Teléfono,
            this.FechaNac});
            this.dGVListaPacientes.Location = new System.Drawing.Point(21, 182);
            this.dGVListaPacientes.Name = "dGVListaPacientes";
            this.dGVListaPacientes.Size = new System.Drawing.Size(741, 150);
            this.dGVListaPacientes.TabIndex = 13;
            // 
            // HC
            // 
            this.HC.HeaderText = "HC";
            this.HC.Name = "HC";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "APELLIDO";
            this.Apellido.Name = "Apellido";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Dirección
            // 
            this.Dirección.HeaderText = "DIRECCIÓN";
            this.Dirección.Name = "Dirección";
            // 
            // Teléfono
            // 
            this.Teléfono.HeaderText = "TELÉFONO";
            this.Teléfono.Name = "Teléfono";
            // 
            // FechaNac
            // 
            this.FechaNac.HeaderText = "FECHANAC";
            this.FechaNac.Name = "FechaNac";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fecha de nacimiento";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(283, 107);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaNac.TabIndex = 11;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(280, 50);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(283, 66);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 9;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(162, 92);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(162, 50);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 7;
            this.lblDNI.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(34, 94);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(34, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(162, 108);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(162, 66);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(37, 110);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(37, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblregistrarp
            // 
            this.lblregistrarp.AutoSize = true;
            this.lblregistrarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistrarp.Location = new System.Drawing.Point(34, 22);
            this.lblregistrarp.Name = "lblregistrarp";
            this.lblregistrarp.Size = new System.Drawing.Size(206, 20);
            this.lblregistrarp.TabIndex = 0;
            this.lblregistrarp.Text = "REGISTRAR PACIENTE";
            // 
            // tpTURNOS
            // 
            this.tpTURNOS.Controls.Add(this.dgvturnos);
            this.tpTURNOS.Controls.Add(this.btnAceptarTurno);
            this.tpTURNOS.Controls.Add(this.pictureBox2);
            this.tpTURNOS.Controls.Add(this.lblMostrarTurno);
            this.tpTURNOS.Controls.Add(this.lblTurno);
            this.tpTURNOS.Controls.Add(this.dTPTurno);
            this.tpTURNOS.Controls.Add(this.lblDNITurnos);
            this.tpTURNOS.Controls.Add(this.lblApellidoTurnos);
            this.tpTURNOS.Controls.Add(this.lblNombreturnos);
            this.tpTURNOS.Controls.Add(this.lblHCTurnos);
            this.tpTURNOS.Controls.Add(this.txtDNITurnos);
            this.tpTURNOS.Controls.Add(this.txtApellidoTurnos);
            this.tpTURNOS.Controls.Add(this.txtNombreTurnos);
            this.tpTURNOS.Controls.Add(this.txtHCturnos);
            this.tpTURNOS.Location = new System.Drawing.Point(4, 22);
            this.tpTURNOS.Name = "tpTURNOS";
            this.tpTURNOS.Padding = new System.Windows.Forms.Padding(3);
            this.tpTURNOS.Size = new System.Drawing.Size(768, 407);
            this.tpTURNOS.TabIndex = 1;
            this.tpTURNOS.Text = "TURNOS";
            this.tpTURNOS.UseVisualStyleBackColor = true;
            // 
            // btnAceptarTurno
            // 
            this.btnAceptarTurno.Location = new System.Drawing.Point(39, 163);
            this.btnAceptarTurno.Name = "btnAceptarTurno";
            this.btnAceptarTurno.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarTurno.TabIndex = 12;
            this.btnAceptarTurno.Text = "ACEPTAR";
            this.btnAceptarTurno.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(616, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // lblMostrarTurno
            // 
            this.lblMostrarTurno.AutoSize = true;
            this.lblMostrarTurno.Location = new System.Drawing.Point(33, 282);
            this.lblMostrarTurno.Name = "lblMostrarTurno";
            this.lblMostrarTurno.Size = new System.Drawing.Size(10, 13);
            this.lblMostrarTurno.TabIndex = 10;
            this.lblMostrarTurno.Text = ".";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(36, 79);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(35, 13);
            this.lblTurno.TabIndex = 9;
            this.lblTurno.Text = "Turno";
            // 
            // dTPTurno
            // 
            this.dTPTurno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPTurno.Location = new System.Drawing.Point(36, 98);
            this.dTPTurno.Name = "dTPTurno";
            this.dTPTurno.Size = new System.Drawing.Size(100, 20);
            this.dTPTurno.TabIndex = 8;
            // 
            // lblDNITurnos
            // 
            this.lblDNITurnos.AutoSize = true;
            this.lblDNITurnos.Location = new System.Drawing.Point(410, 24);
            this.lblDNITurnos.Name = "lblDNITurnos";
            this.lblDNITurnos.Size = new System.Drawing.Size(26, 13);
            this.lblDNITurnos.TabIndex = 7;
            this.lblDNITurnos.Text = "DNI";
            // 
            // lblApellidoTurnos
            // 
            this.lblApellidoTurnos.AutoSize = true;
            this.lblApellidoTurnos.Location = new System.Drawing.Point(283, 24);
            this.lblApellidoTurnos.Name = "lblApellidoTurnos";
            this.lblApellidoTurnos.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoTurnos.TabIndex = 6;
            this.lblApellidoTurnos.Text = "Apellido";
            // 
            // lblNombreturnos
            // 
            this.lblNombreturnos.AutoSize = true;
            this.lblNombreturnos.Location = new System.Drawing.Point(159, 24);
            this.lblNombreturnos.Name = "lblNombreturnos";
            this.lblNombreturnos.Size = new System.Drawing.Size(44, 13);
            this.lblNombreturnos.TabIndex = 5;
            this.lblNombreturnos.Text = "Nombre";
            // 
            // lblHCTurnos
            // 
            this.lblHCTurnos.AutoSize = true;
            this.lblHCTurnos.Location = new System.Drawing.Point(36, 24);
            this.lblHCTurnos.Name = "lblHCTurnos";
            this.lblHCTurnos.Size = new System.Drawing.Size(22, 13);
            this.lblHCTurnos.TabIndex = 4;
            this.lblHCTurnos.Text = "HC";
            // 
            // txtDNITurnos
            // 
            this.txtDNITurnos.Location = new System.Drawing.Point(410, 42);
            this.txtDNITurnos.Name = "txtDNITurnos";
            this.txtDNITurnos.Size = new System.Drawing.Size(100, 20);
            this.txtDNITurnos.TabIndex = 3;
            // 
            // txtApellidoTurnos
            // 
            this.txtApellidoTurnos.Location = new System.Drawing.Point(283, 42);
            this.txtApellidoTurnos.Name = "txtApellidoTurnos";
            this.txtApellidoTurnos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoTurnos.TabIndex = 2;
            // 
            // txtNombreTurnos
            // 
            this.txtNombreTurnos.Location = new System.Drawing.Point(159, 42);
            this.txtNombreTurnos.Name = "txtNombreTurnos";
            this.txtNombreTurnos.Size = new System.Drawing.Size(100, 20);
            this.txtNombreTurnos.TabIndex = 1;
            // 
            // txtHCturnos
            // 
            this.txtHCturnos.Location = new System.Drawing.Point(36, 43);
            this.txtHCturnos.Name = "txtHCturnos";
            this.txtHCturnos.Size = new System.Drawing.Size(100, 20);
            this.txtHCturnos.TabIndex = 0;
            // 
            // dgvturnos
            // 
            this.dgvturnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvturnos.Location = new System.Drawing.Point(174, 128);
            this.dgvturnos.Name = "dgvturnos";
            this.dgvturnos.Size = new System.Drawing.Size(542, 150);
            this.dgvturnos.TabIndex = 13;
            // 
            // MADEsalud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbTURNOS);
            this.Name = "MADEsalud";
            this.Text = "MADEsalud";
            this.tbTURNOS.ResumeLayout(false);
            this.tpHC.ResumeLayout(false);
            this.tpHC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListaPacientes)).EndInit();
            this.tpTURNOS.ResumeLayout(false);
            this.tpTURNOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvturnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbTURNOS;
        private System.Windows.Forms.TabPage tpHC;
        private System.Windows.Forms.TabPage tpTURNOS;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblregistrarp;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.DataGridView dGVListaPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn HC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dirección;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAsignarTurno;
        private System.Windows.Forms.Label lblDNITurnos;
        private System.Windows.Forms.Label lblApellidoTurnos;
        private System.Windows.Forms.Label lblNombreturnos;
        private System.Windows.Forms.Label lblHCTurnos;
        private System.Windows.Forms.TextBox txtDNITurnos;
        private System.Windows.Forms.TextBox txtApellidoTurnos;
        private System.Windows.Forms.TextBox txtNombreTurnos;
        private System.Windows.Forms.TextBox txtHCturnos;
        private System.Windows.Forms.Label lblMostrarTurno;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.DateTimePicker dTPTurno;
        private System.Windows.Forms.Button btnAceptarTurno;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvturnos;
    }
}