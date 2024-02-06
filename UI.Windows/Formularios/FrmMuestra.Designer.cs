namespace UI.Windows.Formularios
{
    partial class FrmMuestra
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.dtFechaMuestra = new System.Windows.Forms.DateTimePicker();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.cboTipoPrueba = new System.Windows.Forms.ComboBox();
            this.cboMedico = new System.Windows.Forms.ComboBox();
            this.cboPaciente = new System.Windows.Forms.ComboBox();
            this.btnGuardarMuestra = new System.Windows.Forms.Button();
            this.dgvListarMuestra = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdMuestra = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarMuestra)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdMuestra);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkEstado);
            this.groupBox1.Controls.Add(this.dtFechaMuestra);
            this.groupBox1.Controls.Add(this.cboDepartamento);
            this.groupBox1.Controls.Add(this.cboTipoPrueba);
            this.groupBox1.Controls.Add(this.cboMedico);
            this.groupBox1.Controls.Add(this.cboPaciente);
            this.groupBox1.Controls.Add(this.btnGuardarMuestra);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha Recepcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo Prueba";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Medico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Paciente";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(133, 220);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(59, 17);
            this.chkEstado.TabIndex = 6;
            this.chkEstado.Text = "Estado";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // dtFechaMuestra
            // 
            this.dtFechaMuestra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaMuestra.Location = new System.Drawing.Point(133, 182);
            this.dtFechaMuestra.Name = "dtFechaMuestra";
            this.dtFechaMuestra.Size = new System.Drawing.Size(121, 20);
            this.dtFechaMuestra.TabIndex = 5;
            this.dtFechaMuestra.Value = new System.DateTime(2024, 1, 31, 0, 0, 0, 0);
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(133, 141);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(121, 21);
            this.cboDepartamento.TabIndex = 4;
            // 
            // cboTipoPrueba
            // 
            this.cboTipoPrueba.FormattingEnabled = true;
            this.cboTipoPrueba.Location = new System.Drawing.Point(133, 101);
            this.cboTipoPrueba.Name = "cboTipoPrueba";
            this.cboTipoPrueba.Size = new System.Drawing.Size(121, 21);
            this.cboTipoPrueba.TabIndex = 3;
            // 
            // cboMedico
            // 
            this.cboMedico.FormattingEnabled = true;
            this.cboMedico.Location = new System.Drawing.Point(133, 61);
            this.cboMedico.Name = "cboMedico";
            this.cboMedico.Size = new System.Drawing.Size(121, 21);
            this.cboMedico.TabIndex = 2;
            // 
            // cboPaciente
            // 
            this.cboPaciente.FormattingEnabled = true;
            this.cboPaciente.Location = new System.Drawing.Point(133, 20);
            this.cboPaciente.Name = "cboPaciente";
            this.cboPaciente.Size = new System.Drawing.Size(121, 21);
            this.cboPaciente.TabIndex = 1;
            // 
            // btnGuardarMuestra
            // 
            this.btnGuardarMuestra.Location = new System.Drawing.Point(521, 38);
            this.btnGuardarMuestra.Name = "btnGuardarMuestra";
            this.btnGuardarMuestra.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarMuestra.TabIndex = 0;
            this.btnGuardarMuestra.Text = "Guardar";
            this.btnGuardarMuestra.UseVisualStyleBackColor = true;
            this.btnGuardarMuestra.Click += new System.EventHandler(this.btnGuardarMuestra_Click);
            // 
            // dgvListarMuestra
            // 
            this.dgvListarMuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarMuestra.Location = new System.Drawing.Point(13, 271);
            this.dgvListarMuestra.Name = "dgvListarMuestra";
            this.dgvListarMuestra.Size = new System.Drawing.Size(655, 150);
            this.dgvListarMuestra.TabIndex = 1;
            this.dgvListarMuestra.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListarMuestra_CellMouseDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID";
            // 
            // txtIdMuestra
            // 
            this.txtIdMuestra.Enabled = false;
            this.txtIdMuestra.Location = new System.Drawing.Point(303, 43);
            this.txtIdMuestra.Name = "txtIdMuestra";
            this.txtIdMuestra.Size = new System.Drawing.Size(100, 20);
            this.txtIdMuestra.TabIndex = 13;
            // 
            // FrmMuestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.dgvListarMuestra);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMuestra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMuestra";
            this.Load += new System.EventHandler(this.FrmMuestra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarMuestra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvListarMuestra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.DateTimePicker dtFechaMuestra;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.ComboBox cboTipoPrueba;
        private System.Windows.Forms.ComboBox cboMedico;
        private System.Windows.Forms.ComboBox cboPaciente;
        private System.Windows.Forms.Button btnGuardarMuestra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdMuestra;
        private System.Windows.Forms.Label label6;
    }
}