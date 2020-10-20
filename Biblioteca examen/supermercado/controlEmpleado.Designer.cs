namespace supermercado
{
    partial class Compra2
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
            this.dataGridView_Empleados = new System.Windows.Forms.DataGridView();
            this.data_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_ventas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AltaEmpleado = new System.Windows.Forms.Button();
            this.BajaEmpleado = new System.Windows.Forms.Button();
            this.EmpleadoConMenosVentas = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtVentas = new System.Windows.Forms.TextBox();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Empleados
            // 
            this.dataGridView_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_nombre,
            this.data_apellido,
            this.data_dni,
            this.data_ventas});
            this.dataGridView_Empleados.Location = new System.Drawing.Point(29, 22);
            this.dataGridView_Empleados.Name = "dataGridView_Empleados";
            this.dataGridView_Empleados.Size = new System.Drawing.Size(441, 221);
            this.dataGridView_Empleados.TabIndex = 0;
            this.dataGridView_Empleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // data_nombre
            // 
            this.data_nombre.HeaderText = "Nombre";
            this.data_nombre.Name = "data_nombre";
            // 
            // data_apellido
            // 
            this.data_apellido.HeaderText = "Apellido";
            this.data_apellido.Name = "data_apellido";
            // 
            // data_dni
            // 
            this.data_dni.HeaderText = "Dni";
            this.data_dni.Name = "data_dni";
            // 
            // data_ventas
            // 
            this.data_ventas.HeaderText = "Ventas";
            this.data_ventas.Name = "data_ventas";
            // 
            // AltaEmpleado
            // 
            this.AltaEmpleado.Font = new System.Drawing.Font("Sylfaen", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltaEmpleado.Location = new System.Drawing.Point(520, 62);
            this.AltaEmpleado.Name = "AltaEmpleado";
            this.AltaEmpleado.Size = new System.Drawing.Size(106, 41);
            this.AltaEmpleado.TabIndex = 1;
            this.AltaEmpleado.Text = "Agregar";
            this.AltaEmpleado.UseVisualStyleBackColor = true;
            this.AltaEmpleado.Click += new System.EventHandler(this.AltaEmpleado_Click);
            // 
            // BajaEmpleado
            // 
            this.BajaEmpleado.Font = new System.Drawing.Font("Sylfaen", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BajaEmpleado.Location = new System.Drawing.Point(662, 65);
            this.BajaEmpleado.Name = "BajaEmpleado";
            this.BajaEmpleado.Size = new System.Drawing.Size(106, 38);
            this.BajaEmpleado.TabIndex = 2;
            this.BajaEmpleado.Text = "Eliminar";
            this.BajaEmpleado.UseVisualStyleBackColor = true;
            this.BajaEmpleado.Click += new System.EventHandler(this.BajaEmpleado_Click);
            // 
            // EmpleadoConMenosVentas
            // 
            this.EmpleadoConMenosVentas.Font = new System.Drawing.Font("Sylfaen", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpleadoConMenosVentas.Location = new System.Drawing.Point(587, 146);
            this.EmpleadoConMenosVentas.Name = "EmpleadoConMenosVentas";
            this.EmpleadoConMenosVentas.Size = new System.Drawing.Size(137, 83);
            this.EmpleadoConMenosVentas.TabIndex = 3;
            this.EmpleadoConMenosVentas.Text = "Empleados con menos de 10 ventas";
            this.EmpleadoConMenosVentas.UseVisualStyleBackColor = true;
            this.EmpleadoConMenosVentas.Click += new System.EventHandler(this.EmpleadoConMenosVentas_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Sylfaen", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(682, 390);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(106, 41);
            this.buttonSalir.TabIndex = 4;
            this.buttonSalir.Text = "salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 313);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(136, 390);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(154, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(420, 313);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(154, 20);
            this.txtDni.TabIndex = 8;
            // 
            // txtVentas
            // 
            this.txtVentas.Location = new System.Drawing.Point(420, 390);
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.Size = new System.Drawing.Size(154, 20);
            this.txtVentas.TabIndex = 9;
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Location = new System.Drawing.Point(292, 270);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(0, 13);
            this.lblInformacion.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "APELLIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "VENTAS";
            // 
            // compra2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.txtVentas);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.EmpleadoConMenosVentas);
            this.Controls.Add(this.BajaEmpleado);
            this.Controls.Add(this.AltaEmpleado);
            this.Controls.Add(this.dataGridView_Empleados);
            this.Name = "compra2";
            this.Text = "Control de Empleado";
            this.Load += new System.EventHandler(this.compra2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Empleados;
        private System.Windows.Forms.Button AltaEmpleado;
        private System.Windows.Forms.Button BajaEmpleado;
        private System.Windows.Forms.Button EmpleadoConMenosVentas;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_ventas;
        private System.Windows.Forms.TextBox txtVentas;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}