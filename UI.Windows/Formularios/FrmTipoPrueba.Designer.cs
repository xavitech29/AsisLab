namespace UI.Windows.Formularios
{
    partial class FrmTipoPrueba
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTipoPrueba = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarTipo = new System.Windows.Forms.Button();
            this.txtDescripcionTP = new System.Windows.Forms.TextBox();
            this.txtNombreTP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListarTipoPrueba = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarTipoPrueba)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Prueba";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTipoPrueba);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnGuardarTipo);
            this.groupBox1.Controls.Add(this.txtDescripcionTP);
            this.groupBox1.Controls.Add(this.txtNombreTP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtTipoPrueba
            // 
            this.txtTipoPrueba.Enabled = false;
            this.txtTipoPrueba.Location = new System.Drawing.Point(243, 57);
            this.txtTipoPrueba.Name = "txtTipoPrueba";
            this.txtTipoPrueba.Size = new System.Drawing.Size(100, 20);
            this.txtTipoPrueba.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID";
            // 
            // btnGuardarTipo
            // 
            this.btnGuardarTipo.Location = new System.Drawing.Point(280, 18);
            this.btnGuardarTipo.Name = "btnGuardarTipo";
            this.btnGuardarTipo.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarTipo.TabIndex = 4;
            this.btnGuardarTipo.Text = "Guardar";
            this.btnGuardarTipo.UseVisualStyleBackColor = true;
            this.btnGuardarTipo.Click += new System.EventHandler(this.btnGuardarTipo_Click);
            // 
            // txtDescripcionTP
            // 
            this.txtDescripcionTP.Location = new System.Drawing.Point(78, 54);
            this.txtDescripcionTP.Name = "txtDescripcionTP";
            this.txtDescripcionTP.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionTP.TabIndex = 3;
            // 
            // txtNombreTP
            // 
            this.txtNombreTP.Location = new System.Drawing.Point(78, 20);
            this.txtNombreTP.Name = "txtNombreTP";
            this.txtNombreTP.Size = new System.Drawing.Size(100, 20);
            this.txtNombreTP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // dgvListarTipoPrueba
            // 
            this.dgvListarTipoPrueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarTipoPrueba.Location = new System.Drawing.Point(12, 157);
            this.dgvListarTipoPrueba.Name = "dgvListarTipoPrueba";
            this.dgvListarTipoPrueba.Size = new System.Drawing.Size(428, 150);
            this.dgvListarTipoPrueba.TabIndex = 2;
            this.dgvListarTipoPrueba.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListarTipoPrueba_CellMouseDoubleClick);
            // 
            // FrmTipoPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.dgvListarTipoPrueba);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTipoPrueba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTipoPrueba";
            this.Load += new System.EventHandler(this.FrmTipoPrueba_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarTipoPrueba)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardarTipo;
        private System.Windows.Forms.TextBox txtDescripcionTP;
        private System.Windows.Forms.TextBox txtNombreTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListarTipoPrueba;
        private System.Windows.Forms.TextBox txtTipoPrueba;
        private System.Windows.Forms.Label label3;
    }
}