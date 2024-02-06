using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Windows.Formularios
{
    public partial class FrmPrincipal : Form
    {
        //private int childFormNumber = 0;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

       
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearPaciente();
        }

        private void CrearPaciente()
        {
            FrmPaciente nuevo = new FrmPaciente();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearMedico();
        }
        private void CrearMedico()
        {
            FrmMedico nuevo = new FrmMedico();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearDepartamento();
        }
        private void CrearDepartamento()
        {
            FrmDepartamento nuevo = new FrmDepartamento();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void tipoPruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearTipoPrueba();
        }

        private void CrearTipoPrueba()
        {
            FrmTipoPrueba nuevo = new FrmTipoPrueba();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void muestraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearMuestra();
        }

        private void CrearMuestra()
        {
            FrmMuestra nuevo = new FrmMuestra();
            nuevo.MdiParent = this;
            nuevo.Show();
        }
    }
}
