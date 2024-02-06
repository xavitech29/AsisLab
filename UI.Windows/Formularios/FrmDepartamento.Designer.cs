namespace UI.Windows.Formularios
{
    partial class FrmDepartamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomDepartamento = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dgvListarDepartamento = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntGuardarDepartamento = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdDepartamento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarDepartamento)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Departamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // txtNomDepartamento
            // 
            this.txtNomDepartamento.Location = new System.Drawing.Point(127, 19);
            this.txtNomDepartamento.Name = "txtNomDepartamento";
            this.txtNomDepartamento.Size = new System.Drawing.Size(100, 20);
            this.txtNomDepartamento.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(127, 54);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // dgvListarDepartamento
            // 
            this.dgvListarDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarDepartamento.Location = new System.Drawing.Point(12, 172);
            this.dgvListarDepartamento.Name = "dgvListarDepartamento";
            this.dgvListarDepartamento.Size = new System.Drawing.Size(461, 150);
            this.dgvListarDepartamento.TabIndex = 4;
            this.dgvListarDepartamento.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListarDepartamento_CellMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdDepartamento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bntGuardarDepartamento);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNomDepartamento);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 134);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // bntGuardarDepartamento
            // 
            this.bntGuardarDepartamento.Location = new System.Drawing.Point(380, 95);
            this.bntGuardarDepartamento.Name = "bntGuardarDepartamento";
            this.bntGuardarDepartamento.Size = new System.Drawing.Size(75, 23);
            this.bntGuardarDepartamento.TabIndex = 4;
            this.bntGuardarDepartamento.Text = "Guardar";
            this.bntGuardarDepartamento.UseVisualStyleBackColor = true;
            this.bntGuardarDepartamento.Click += new System.EventHandler(this.bntGuardarDepartamento_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID";
            // 
            // txtIdDepartamento
            // 
            this.txtIdDepartamento.Enabled = false;
            this.txtIdDepartamento.Location = new System.Drawing.Point(270, 19);
            this.txtIdDepartamento.Name = "txtIdDepartamento";
            this.txtIdDepartamento.Size = new System.Drawing.Size(100, 20);
            this.txtIdDepartamento.TabIndex = 6;
            // 
            // FrmDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 347);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvListarDepartamento);
            this.Name = "FrmDepartamento";
            this.Text = "FrmDepartamento";
            this.Load += new System.EventHandler(this.FrmDepartamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarDepartamento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomDepartamento;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dgvListarDepartamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bntGuardarDepartamento;
        private System.Windows.Forms.TextBox txtIdDepartamento;
        private System.Windows.Forms.Label label3;
    }
}