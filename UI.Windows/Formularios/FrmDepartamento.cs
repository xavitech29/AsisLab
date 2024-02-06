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
    public partial class FrmDepartamento : Form
    {
        private DepartamentoControladorAplicacion departamentoControlador;
        private DepartamentoVistaModelo departamentoVistaModelo;
        public FrmDepartamento()
        {
            InitializeComponent();
            departamentoControlador = new DepartamentoControladorAplicacion();
        }

        private void InsertarDepartamento()
        {
            departamentoVistaModelo = new DepartamentoVistaModelo();
            departamentoVistaModelo.Nombre_departamento = txtNomDepartamento.Text;
            departamentoVistaModelo.Descripcion = txtDescripcion.Text;

            if (txtIdDepartamento.Text.Length > 0)
            {
                int idDepartamento;
                if (!int.TryParse(txtIdDepartamento.Text, out idDepartamento))
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para el ID del medico.");
                    return;
                }
                departamentoVistaModelo.Id_departamento = idDepartamento;

                if (departamentoControlador.ActualizarDepartamento(departamentoVistaModelo))
                {
                    MessageBox.Show("Departamento actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("Error. No se puede actualizar Departamento");
                }
            }
            else
            {
                if (departamentoControlador.InsertarDepartamento(departamentoVistaModelo))
                {
                    MessageBox.Show("Departamento insertado correctamente");
                }
                else
                {
                    MessageBox.Show("Error. No se puede insertar Departamento");
                }
            }

            ListarDepartamentos();
        }

        private void ListarDepartamentos()
        {
            dgvListarDepartamento.DataSource = departamentoControlador.ListarDepartamento();
        }
        private void FrmDepartamento_Load(object sender, EventArgs e)
        {
            ListarDepartamentos();
        }

        private void bntGuardarDepartamento_Click(object sender, EventArgs e)
        {
            InsertarDepartamento();
        }

        private void dgvListarDepartamento_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvListarDepartamento.SelectedRows.Count > 0)
            {

                txtIdDepartamento.Text = dgvListarDepartamento.CurrentRow.Cells[0].Value.ToString();
                txtNomDepartamento.Text = dgvListarDepartamento.CurrentRow.Cells[1].Value.ToString();
                txtDescripcion.Text = dgvListarDepartamento.CurrentRow.Cells[2].Value.ToString();
                
            }
        }
    }
}
