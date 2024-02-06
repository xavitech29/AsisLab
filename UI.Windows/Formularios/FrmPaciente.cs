using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Windows.ControladoresAplicacion;
using UI.Windows.VistaModelo;

namespace UI.Windows.Formularios
{
    public partial class FrmPaciente : Form
    {

        private PacienteControladorAplicacion pacienteControlador;
        private PacienteVistaModelo pacienteVistaModelo;
        
        public FrmPaciente()
        {
            InitializeComponent();
            pacienteControlador = new PacienteControladorAplicacion();
        }

        private void InsertarPaciente()
        {
            pacienteVistaModelo = new PacienteVistaModelo();
            pacienteVistaModelo.Nombre = txtNombrePaciente.Text;
            pacienteVistaModelo.Apellido = txtApellidoPaciente.Text;
            pacienteVistaModelo.Fecha_nacimiento = fechaPaciente.Value;
            pacienteVistaModelo.Genero = txtGeneroPaciente.Text;
            pacienteVistaModelo.Direccion = txtDireccionPaciente.Text;
            pacienteVistaModelo.Telefono = txtTelefonoPaciente.Text;



            if (txtIdPaciente.Text.Length > 0)
            {
                int idPaciente;
                if (!int.TryParse(txtIdPaciente.Text, out idPaciente))
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para el ID del paciente.");
                    return;
                }
                pacienteVistaModelo.Id_paciente = idPaciente;

                if (pacienteControlador.ActualizarPaciente(pacienteVistaModelo))
                {
                    MessageBox.Show("Paciente actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("Error. No se puede actualizar Paciente");
                }
            }
            else
            {
                if (pacienteControlador.InsertarPaciente(pacienteVistaModelo))
                {
                    MessageBox.Show("Paciente insertado correctamente");
                }
                else
                {
                    MessageBox.Show("Error. No se puede insertar Paciente");
                }
            }

            ListarPacientes();

        }
        
        
        private void FrmPaciente_Load(object sender, EventArgs e)
        {
            ListarPacientes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarPaciente();
            Limpiar();
        }
        private void ListarPacientes()
        {
            dgvPaciente.DataSource = pacienteControlador.ListarPaciente();
        }
        private void dgvPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPaciente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvPaciente.SelectedRows.Count > 0)
            {

                txtIdPaciente.Text = dgvPaciente.CurrentRow.Cells[0].Value.ToString();
                txtNombrePaciente.Text = dgvPaciente.CurrentRow.Cells[1].Value.ToString();
                txtApellidoPaciente.Text = dgvPaciente.CurrentRow.Cells[2].Value.ToString();
                fechaPaciente.Text = dgvPaciente.CurrentRow.Cells[3].Value.ToString();
                txtGeneroPaciente.Text = dgvPaciente.CurrentRow.Cells[4].Value.ToString();
                txtDireccionPaciente.Text = dgvPaciente.CurrentRow.Cells[5].Value.ToString();
                txtTelefonoPaciente.Text = dgvPaciente.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void Limpiar()
        {
            txtIdPaciente.Text = "";
            txtNombrePaciente.Text = "";
            txtApellidoPaciente.Text = "";
            fechaPaciente.Text = "";
            txtGeneroPaciente.Text = "";
            txtDireccionPaciente.Text = "";
            txtTelefonoPaciente.Text = "";
        }

        //eliminar 
        private void EliminarPaciente()
        {
            pacienteVistaModelo = new PacienteVistaModelo();
            var IdPaciente = int.Parse(txtIdPaciente.Text == "" ? "0" : txtIdPaciente.Text);
            pacienteVistaModelo.Id_paciente = IdPaciente;

            if (pacienteControlador.EliminarPaciente(pacienteVistaModelo) && IdPaciente > 0)
            {
                MessageBox.Show("Paciente Eliminado!!");

                ListarPacientes();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error. Paciente No Eliminado!!");

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este paciente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                EliminarPaciente();
                Limpiar();
            }

          
        }
    }
    
}
