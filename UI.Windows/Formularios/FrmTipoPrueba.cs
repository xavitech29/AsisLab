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
    public partial class FrmTipoPrueba : Form
    {
        private TipoPruebaControladorAplicacion tipoPruebaControlador;
        private TipoPruebaVistaModelo tipoPruebaVistaModelo;
        public FrmTipoPrueba()
        {
            InitializeComponent();
            tipoPruebaControlador = new TipoPruebaControladorAplicacion();
        }

        private void InsertarTipoPrueba()
        {
            tipoPruebaVistaModelo = new TipoPruebaVistaModelo();
            tipoPruebaVistaModelo.Nombre_tipo_prueba = txtNombreTP.Text;
            tipoPruebaVistaModelo.Descripcion = txtDescripcionTP.Text;

            if (txtIdTipoPrueba.Text.Length > 0)
            {
                int idTipoPrueba;
                if (!int.TryParse(txtIdTipoPrueba.Text, out idTipoPrueba))
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para el ID del medico.");
                    return;
                }
                tipoPruebaVistaModelo.Id_tipo_prueba = idTipoPrueba;

                if (tipoPruebaControlador.ActualizarTipoPrueba(tipoPruebaVistaModelo))
                {
                    MessageBox.Show("Tipo Prueba actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("Error. No se puede actualizar Tipo Prueba");
                }
            }
            else
            {
                if (tipoPruebaControlador.InsertarTipoPrueba(tipoPruebaVistaModelo))
                {
                    MessageBox.Show("Tipo Prueba insertado correctamente");
                }
                else
                {
                    MessageBox.Show("Error. No se puede insertar Tipo Prueba");
                }
            }

            ListarTipoPruebas();
        }

        private void ListarTipoPruebas()
        {
            dgvListarTipoPrueba.DataSource = tipoPruebaControlador.ListarTipoPrueba();
        }
        private void FrmTipoPrueba_Load(object sender, EventArgs e)
        {
            ListarTipoPruebas();
        }

        private void btnGuardarTipo_Click(object sender, EventArgs e)
        {
            InsertarTipoPrueba();
            Limpiar();
        }

        private void dgvListarTipoPrueba_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvListarTipoPrueba.SelectedRows.Count > 0)
            {

                txtIdTipoPrueba.Text = dgvListarTipoPrueba.CurrentRow.Cells[0].Value.ToString();
                txtNombreTP.Text = dgvListarTipoPrueba.CurrentRow.Cells[1].Value.ToString();
                txtDescripcionTP.Text = dgvListarTipoPrueba.CurrentRow.Cells[2].Value.ToString();

            }
        }

        private void Limpiar()
        {
            txtIdTipoPrueba.Text = "";
            txtNombreTP.Text = "";
            txtDescripcionTP.Text = "";

        }

        private void EliminarTipoPrueba()
        {
            tipoPruebaVistaModelo = new TipoPruebaVistaModelo();
            var IdTipoPrueba = int.Parse(txtIdTipoPrueba.Text == "" ? "0" : txtIdTipoPrueba.Text);
            tipoPruebaVistaModelo.Id_tipo_prueba = IdTipoPrueba;

            if (tipoPruebaControlador.EliminarTipoPrueba(tipoPruebaVistaModelo) && IdTipoPrueba > 0)
            {
                MessageBox.Show("Tipo Prueba Dado de Baja!!");

                ListarTipoPruebas();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error. Tipo Prueba No Dado de Baja!!");

            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este Tipo Prueba?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                EliminarTipoPrueba();
                Limpiar();
            }
        }
    }
}
