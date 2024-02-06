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
    }
}
