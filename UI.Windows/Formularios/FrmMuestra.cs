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
    public partial class FrmMuestra : Form
    {
        private MuestraControladorAplicacion muestraControlador;
        private MuestraVistaModelo muestraVistaModelo;
        private DepartamentoControladorAplicacion departamentoControlador;
        private MedicoControladorAplicacion medicoControlador;
        private TipoPruebaControladorAplicacion tipoPruebaControlador;
        private PacienteControladorAplicacion pacienteControlador;
        public FrmMuestra()
        {
            InitializeComponent();
            muestraControlador = new MuestraControladorAplicacion();
            departamentoControlador = new DepartamentoControladorAplicacion();
            medicoControlador = new MedicoControladorAplicacion();
            tipoPruebaControlador = new TipoPruebaControladorAplicacion();
            pacienteControlador = new PacienteControladorAplicacion();
        }

        private void InsertarMuestra()
        {
            muestraVistaModelo = new MuestraVistaModelo();
            muestraVistaModelo.Id_paciente = int.Parse(cboPaciente.SelectedValue.ToString());
            muestraVistaModelo.Id_medico = int.Parse(cboMedico.SelectedValue.ToString());
            muestraVistaModelo.Id_tipo_prueba = int.Parse(cboTipoPrueba.SelectedValue.ToString());
            muestraVistaModelo.Id_departamento = int.Parse(cboDepartamento.SelectedValue.ToString());
            muestraVistaModelo.Fecha_recepcion = dtFechaMuestra.Value;

            if (chkEstado.Checked)

                muestraVistaModelo.Estado = true;
            else
                muestraVistaModelo.Estado = false;


            // Si el campo de ID no está vacío, significa que estás actualizando un historial existente
            if (txtIdMuestra.Text.Length > 0)
            {
                int idMuestra;
                if (!int.TryParse(txtIdMuestra.Text, out idMuestra))
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para el ID del muestra.");
                    return;
                }
                muestraVistaModelo.Id_muestra = idMuestra;

                if (muestraControlador.ActualizarMuestra(muestraVistaModelo))
                {
                    MessageBox.Show("Muestra actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("Error. No se puede actualizar muestra");
                }
            }
            else
            {
                if (muestraControlador.InsertarMuestra(muestraVistaModelo))
                {
                    MessageBox.Show("Reserva insertado correctamente");
                }
                else
                {
                    MessageBox.Show("Error. No se puede insertar el reserva");
                }
            }

            ListarMuestras();

        }
        private void ComboboxListar()
        {
            cboPaciente.DataSource = pacienteControlador.ListarPaciente();
            cboPaciente.DisplayMember = "nombre";
            cboPaciente.ValueMember = "id_paciente";

            cboMedico.DataSource = medicoControlador.ListarMedico();
            cboMedico.DisplayMember = "nombre";
            cboMedico.ValueMember = "id_medico";

            cboTipoPrueba.DataSource = tipoPruebaControlador.ListarTipoPrueba();
            cboTipoPrueba.DisplayMember = "nombre_tipo_prueba";
            cboTipoPrueba.ValueMember = "id_tipo_prueba";

            cboDepartamento.DataSource = departamentoControlador.ListarDepartamento();
            cboDepartamento.DisplayMember = "nombre_departamento";
            cboDepartamento.ValueMember = "id_departamento";
        }
        private void ListarMuestras()
        {
            dgvListarMuestra.DataSource = muestraControlador.ListarMuestra();
        }
        private void FrmMuestra_Load(object sender, EventArgs e)
        {
            ListarMuestras();
            ComboboxListar();
        }

        private void btnGuardarMuestra_Click(object sender, EventArgs e)
        {
            InsertarMuestra();
        }

        private void dgvListarMuestra_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvListarMuestra.SelectedRows.Count > 0)
            {

                txtIdMuestra.Text = dgvListarMuestra.CurrentRow.Cells[0].Value.ToString();
                cboPaciente.SelectedValue = dgvListarMuestra.CurrentRow.Cells[1].Value;
                cboMedico.SelectedValue = dgvListarMuestra.CurrentRow.Cells[2].Value;
                cboTipoPrueba.SelectedValue = dgvListarMuestra.CurrentRow.Cells[3].Value;
                cboDepartamento.SelectedValue = dgvListarMuestra.CurrentRow.Cells[4].Value;
                dtFechaMuestra.Text = dgvListarMuestra.CurrentRow.Cells[5].Value.ToString();
                
                if (dgvListarMuestra.CurrentRow.Cells[6].Value.ToString() == "True")
                {
                    chkEstado.Checked = true;
                }
                else
                {
                    chkEstado.Checked = false;
                }

                
            }
        }
    }
}
