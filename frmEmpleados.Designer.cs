namespace TP_2___FInal
{
    partial class ADODesconectadoEmpleado
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
            this.btnDescartar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.Empleado = new System.Windows.Forms.GroupBox();
            this.txtIDTarea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGVFiltrada = new System.Windows.Forms.DataGridView();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtApeFiltro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.Empleado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFiltrada)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDescartar
            // 
            this.btnDescartar.Location = new System.Drawing.Point(182, 195);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(144, 23);
            this.btnDescartar.TabIndex = 100;
            this.btnDescartar.Text = "Descartar cambios";
            this.btnDescartar.UseVisualStyleBackColor = true;
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(363, 195);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(144, 23);
            this.btnCargar.TabIndex = 99;
            this.btnCargar.Text = "Cargar datos nuevamente";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(12, 195);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(144, 23);
            this.btnGrabar.TabIndex = 98;
            this.btnGrabar.Text = "Guardar cambios";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(363, 145);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(144, 23);
            this.btnEliminar.TabIndex = 97;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(182, 145);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(144, 23);
            this.btnModificar.TabIndex = 96;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(13, 87);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(47, 13);
            this.Label3.TabIndex = 94;
            this.Label3.Text = "Apellido:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(13, 57);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(47, 13);
            this.Label2.TabIndex = 93;
            this.Label2.Text = "Nombre:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(19, 13);
            this.Label1.TabIndex = 92;
            this.Label1.Text = "Id:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(103, 84);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(247, 20);
            this.txtApellido.TabIndex = 90;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(103, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(247, 20);
            this.txtNombre.TabIndex = 89;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(103, 25);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(41, 20);
            this.txtId.TabIndex = 88;
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(16, 19);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(491, 170);
            this.DGV.TabIndex = 87;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(16, 145);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(144, 23);
            this.btnNuevo.TabIndex = 85;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Empleado
            // 
            this.Empleado.Controls.Add(this.txtIDTarea);
            this.Empleado.Controls.Add(this.label4);
            this.Empleado.Controls.Add(this.btnNuevo);
            this.Empleado.Controls.Add(this.txtId);
            this.Empleado.Controls.Add(this.txtNombre);
            this.Empleado.Controls.Add(this.btnEliminar);
            this.Empleado.Controls.Add(this.txtApellido);
            this.Empleado.Controls.Add(this.btnModificar);
            this.Empleado.Controls.Add(this.Label1);
            this.Empleado.Controls.Add(this.Label3);
            this.Empleado.Controls.Add(this.Label2);
            this.Empleado.Location = new System.Drawing.Point(12, 12);
            this.Empleado.Name = "Empleado";
            this.Empleado.Size = new System.Drawing.Size(513, 182);
            this.Empleado.TabIndex = 101;
            this.Empleado.TabStop = false;
            this.Empleado.Text = "Empleado:";
            // 
            // txtIDTarea
            // 
            this.txtIDTarea.Location = new System.Drawing.Point(103, 110);
            this.txtIDTarea.Name = "txtIDTarea";
            this.txtIDTarea.Size = new System.Drawing.Size(41, 20);
            this.txtIDTarea.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 99;
            this.label4.Text = "ID Tarea:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVFiltrada);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.txtApeFiltro);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 433);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 195);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar:";
            // 
            // DGVFiltrada
            // 
            this.DGVFiltrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFiltrada.Location = new System.Drawing.Point(6, 53);
            this.DGVFiltrada.Name = "DGVFiltrada";
            this.DGVFiltrada.Size = new System.Drawing.Size(491, 122);
            this.DGVFiltrada.TabIndex = 101;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(369, 24);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(112, 23);
            this.btnFiltrar.TabIndex = 85;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtApeFiltro
            // 
            this.txtApeFiltro.Location = new System.Drawing.Point(79, 26);
            this.txtApeFiltro.Name = "txtApeFiltro";
            this.txtApeFiltro.Size = new System.Drawing.Size(247, 20);
            this.txtApeFiltro.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 93;
            this.label8.Text = "Apellido:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGV);
            this.groupBox2.Controls.Add(this.btnGrabar);
            this.groupBox2.Controls.Add(this.btnCargar);
            this.groupBox2.Controls.Add(this.btnDescartar);
            this.groupBox2.Location = new System.Drawing.Point(12, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 227);
            this.groupBox2.TabIndex = 103;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Empleado:";
            // 
            // ADODesconectadoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 632);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Empleado);
            this.Name = "ADODesconectadoEmpleado";
            this.Text = "Empleados";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.Empleado.ResumeLayout(false);
            this.Empleado.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFiltrada)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnDescartar;
        internal System.Windows.Forms.Button btnCargar;
        internal System.Windows.Forms.Button btnGrabar;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.Button btnModificar;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtApellido;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.DataGridView DGV;
        internal System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox Empleado;
        internal System.Windows.Forms.TextBox txtIDTarea;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button btnFiltrar;
        internal System.Windows.Forms.TextBox txtApeFiltro;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.DataGridView DGVFiltrada;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}