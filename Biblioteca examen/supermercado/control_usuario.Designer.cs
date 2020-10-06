namespace supermercado
{
    partial class control_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(control_usuario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView_Productos = new System.Windows.Forms.DataGridView();
            this.data_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGrid_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.text_dni = new System.Windows.Forms.TextBox();
            this.text_usuario = new System.Windows.Forms.TextBox();
            this.text_contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.Label();
            this.txt_usurio = new System.Windows.Forms.Label();
            this.txt_contraseña = new System.Windows.Forms.Label();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txT_apellido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-15, -21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 616);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView_Productos
            // 
            this.dataGridView_Productos.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridView_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_Nombre,
            this.data_Dni,
            this.data_usuario,
            this.data_contraseña,
            this.dataGrid_apellido});
            this.dataGridView_Productos.Location = new System.Drawing.Point(590, 9);
            this.dataGridView_Productos.Name = "dataGridView_Productos";
            this.dataGridView_Productos.Size = new System.Drawing.Size(543, 552);
            this.dataGridView_Productos.TabIndex = 1;
            this.dataGridView_Productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Productos_CellClick);
            this.dataGridView_Productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Productos_CellContentClick);
            // 
            // data_Nombre
            // 
            this.data_Nombre.HeaderText = "Nombre";
            this.data_Nombre.Name = "data_Nombre";
            // 
            // data_Dni
            // 
            this.data_Dni.HeaderText = "DNI";
            this.data_Dni.Name = "data_Dni";
            // 
            // data_usuario
            // 
            this.data_usuario.HeaderText = "Usuario";
            this.data_usuario.Name = "data_usuario";
            // 
            // data_contraseña
            // 
            this.data_contraseña.HeaderText = "Contraseña";
            this.data_contraseña.Name = "data_contraseña";
            // 
            // dataGrid_apellido
            // 
            this.dataGrid_apellido.HeaderText = "Apellido";
            this.dataGrid_apellido.Name = "dataGrid_apellido";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Location = new System.Drawing.Point(191, 362);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(101, 33);
            this.btn_Agregar.TabIndex = 2;
            this.btn_Agregar.Text = "AGREGAR";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(248, 436);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(146, 36);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar.Location = new System.Drawing.Point(346, 362);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(101, 33);
            this.btn_borrar.TabIndex = 6;
            this.btn_borrar.Text = "BORRAR";
            this.btn_borrar.UseVisualStyleBackColor = false;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(346, 76);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(178, 20);
            this.txt_nombre.TabIndex = 7;
            // 
            // text_dni
            // 
            this.text_dni.Location = new System.Drawing.Point(346, 198);
            this.text_dni.Name = "text_dni";
            this.text_dni.Size = new System.Drawing.Size(178, 20);
            this.text_dni.TabIndex = 8;
            // 
            // text_usuario
            // 
            this.text_usuario.Location = new System.Drawing.Point(346, 250);
            this.text_usuario.Name = "text_usuario";
            this.text_usuario.Size = new System.Drawing.Size(178, 20);
            this.text_usuario.TabIndex = 9;
            // 
            // text_contraseña
            // 
            this.text_contraseña.Location = new System.Drawing.Point(346, 300);
            this.text_contraseña.Name = "text_contraseña";
            this.text_contraseña.Size = new System.Drawing.Size(178, 20);
            this.text_contraseña.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GrayText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "NOMBRE:";
            // 
            // txt_dni
            // 
            this.txt_dni.AutoSize = true;
            this.txt_dni.BackColor = System.Drawing.SystemColors.GrayText;
            this.txt_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dni.Location = new System.Drawing.Point(169, 196);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(45, 20);
            this.txt_dni.TabIndex = 12;
            this.txt_dni.Text = "DNI:";
            // 
            // txt_usurio
            // 
            this.txt_usurio.AutoSize = true;
            this.txt_usurio.BackColor = System.Drawing.SystemColors.GrayText;
            this.txt_usurio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usurio.Location = new System.Drawing.Point(169, 248);
            this.txt_usurio.Name = "txt_usurio";
            this.txt_usurio.Size = new System.Drawing.Size(96, 20);
            this.txt_usurio.TabIndex = 13;
            this.txt_usurio.Text = "USUARIO:";
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.AutoSize = true;
            this.txt_contraseña.BackColor = System.Drawing.SystemColors.GrayText;
            this.txt_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.Location = new System.Drawing.Point(169, 298);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(134, 20);
            this.txt_contraseña.TabIndex = 14;
            this.txt_contraseña.Text = "CONTRASEÑA:";
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.Location = new System.Drawing.Point(424, 375);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(0, 20);
            this.lblInformacion.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GrayText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "APELLIDO";
            // 
            // txT_apellido
            // 
            this.txT_apellido.Location = new System.Drawing.Point(346, 140);
            this.txT_apellido.Name = "txT_apellido";
            this.txT_apellido.Size = new System.Drawing.Size(178, 20);
            this.txT_apellido.TabIndex = 17;
            // 
            // control_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1175, 573);
            this.Controls.Add(this.txT_apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usurio);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_contraseña);
            this.Controls.Add(this.text_usuario);
            this.Controls.Add(this.text_dni);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.dataGridView_Productos);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "control_usuario";
            this.Text = "control_usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.control_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView_Productos;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox text_dni;
        private System.Windows.Forms.TextBox text_usuario;
        private System.Windows.Forms.TextBox text_contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_dni;
        private System.Windows.Forms.Label txt_usurio;
        private System.Windows.Forms.Label txt_contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_contraseña;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGrid_apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txT_apellido;
    }
}