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
    public partial class FrmMedico : Form
    {
        private MedicoControladorAplicacion medicoControlador;
        private MedicoVistaModelo medicoVistaModelo;
        public FrmMedico()
        {
            InitializeComponent();
            medicoControlador = new MedicoControladorAplicacion();
        }

        private void InsertarMedico()
        {
            medicoVistaModelo = new MedicoVistaModelo();
            medicoVistaModelo.Nombre = txtNombreM.Text;
            medicoVistaModelo.Apellido = txtApellidoM.Text;
            medicoVistaModelo.Especialidad = txtEspecialidadM.Text;
            medicoVistaModelo.Telefono = txtTelefonoM.Text;
            medicoVistaModelo.Email = txtEmailM.Text;

            
            if (txtIdMedico.Text.Length > 0)
            {
                int idMedico;
                if (!int.TryParse(txtIdMedico.Text, out idMedico))
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para el ID del medico.");
                    return;
                }
                medicoVistaModelo.Id_medico = idMedico;

                if (medicoControlador.ActualizarMedico(medicoVistaModelo))
                {
                    MessageBox.Show("Medico actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("Error. No se puede actualizar Medico");
                }
            }
            else
            {
                if (medicoControlador.InsertarMedico(medicoVistaModelo))
                {
                    MessageBox.Show("Medico insertado correctamente");
                }
                else
                {
                    MessageBox.Show("Error. No se puede insertar Medico");
                }
            }

            ListarMedicos();
        }
        private void ListarMedicos()
        {
            dgvListarMedico.DataSource = medicoControlador.ListarMedico();
        }

        private void FrmMedico_Load(object sender, EventArgs e)
        {
            ListarMedicos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarMedico();
            Limpiar();

        }

        private void dgvListarMedico_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvListarMedico.SelectedRows.Count > 0)
            {

                txtIdMedico.Text = dgvListarMedico.CurrentRow.Cells[0].Value.ToString();
                txtNombreM.Text = dgvListarMedico.CurrentRow.Cells[1].Value.ToString();
                txtApellidoM.Text = dgvListarMedico.CurrentRow.Cells[2].Value.ToString();
                txtEspecialidadM.Text = dgvListarMedico.CurrentRow.Cells[3].Value.ToString();
                txtTelefonoM.Text = dgvListarMedico.CurrentRow.Cells[4].Value.ToString();
                txtEmailM.Text = dgvListarMedico.CurrentRow.Cells[5].Value.ToString();              
            }
        }

        private void Limpiar()
        {
            txtIdMedico.Text = "";
            txtNombreM.Text = "";
            txtApellidoM.Text = "";
            txtEspecialidadM.Text = "";
            txtTelefonoM.Text = "";
            txtEmailM.Text = "";
        }

        private void EliminarMedico()
        {
            medicoVistaModelo = new MedicoVistaModelo();
            var IdMedico= int.Parse(txtIdMedico.Text == "" ? "0" : txtIdMedico.Text);
            medicoVistaModelo.Id_medico = IdMedico;

            if (medicoControlador.EliminarMedico(medicoVistaModelo) && IdMedico > 0)
            {
                MessageBox.Show("Medico Dado de Baja!!");

                ListarMedicos();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error.Medico No Dado de Baja!!");

            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este médico?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                EliminarMedico();
                Limpiar();
            }
        }
    }
}
