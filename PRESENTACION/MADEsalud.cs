using ENTIDADES;
using NEGOCIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class MADEsalud : Form
    {
        NegHistoriaClinica negHC = new NegHistoriaClinica();
        NegTurno negTurno = new NegTurno();
        public MADEsalud()
        {
            InitializeComponent();
            dGVListaPacientes.CellClick += new DataGridViewCellEventHandler(dGVListaPacientes_CellClick);
            btnRegistrar.Click += new EventHandler(btnRegistrar_Click);
            btnModificar.Click += new EventHandler(btnModificar_Click);
            btnEliminar.Click += new EventHandler(btnEliminar_Click);
        }
        private void MADEsalud_Load(object sender, EventArgs e)
        {
            CargarHistorias();
            CargarTurnos();
        }

        private void CargarHistorias()
        {
            
            dGVListaPacientes.DataSource = negHC.ListadoHistoriaClinica("Todos").Tables[0];
        }

        private void CargarTurnos()
        {
            
            dgvturnos.DataSource = negTurno.ListadoTurno("Todos").Tables[0];
        }

        private void dGVListaPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dGVListaPacientes.Rows[e.RowIndex];
                txtHCturnos.Text = fila.Cells["HC"].Value.ToString();
                txtNombreTurnos.Text = fila.Cells["Nombre"].Value.ToString();
                txtApellidoTurnos.Text = fila.Cells["Apellido"].Value.ToString();
                txtDNITurnos.Text = fila.Cells["DNI"].Value.ToString();

                tbTURNOS.SelectedTab = tpTURNOS;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            HistoriaClinica hc = new HistoriaClinica
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                DNI = txtDNI.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                FechaNacimiento = dtpFechaNac.Value.Date
            };

            int resultado = negHC.AbmHistoriaClinica("Alta", hc);
            if (resultado > 0)
            {
                MessageBox.Show("Paciente registrado.");
                CargarHistorias();
            }
            else
            {
                MessageBox.Show("Error al registrar.");
            }

            
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dGVListaPacientes.CurrentRow != null)
            {
                int id = Convert.ToInt32(dGVListaPacientes.CurrentRow.Cells["HC"].Value);
                HistoriaClinica hc = new HistoriaClinica
                {
                    IdPaciente = id,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    DNI = txtDNI.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text,
                    FechaNacimiento = dtpFechaNac.Value.Date
                };
                int resultado = negHC.AbmHistoriaClinica("Alta", hc);
                if (resultado > 0)
                {
                    MessageBox.Show("Paciente modificado.");
                    CargarHistorias();
                }
                else
                {
                    MessageBox.Show("Error al modificar.");
                }


            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dGVListaPacientes.CurrentRow != null)
            {
                int id = Convert.ToInt32(dGVListaPacientes.CurrentRow.Cells["HC"].Value);
                HistoriaClinica hc = new HistoriaClinica { IdPaciente = id };

                int resultado = negHC.AbmHistoriaClinica("Alta", hc);
                if (resultado > 0)
                {
                    MessageBox.Show("Paciente eliminado.");
                    CargarHistorias();
                }
                else
                {
                    MessageBox.Show("Error al eliminar.");
                }
            }
        }
        private void btnAceptarTurno_Click(object sender, EventArgs e)
        {
            Turno turno = new Turno
            {
                IdPaciente = int.Parse(txtHCturnos.Text),
                Fecha = dTPTurno.Value.Date,
                Hora = TimeSpan.FromHours(10), 
                IdMedico = 1,
                Estado = "Pendiente"
            };
            negTurno.AbmTurnos("Alta", turno);
            MessageBox.Show("Turno asignado correctamente.");
            CargarTurnos();
        }



    }
}
