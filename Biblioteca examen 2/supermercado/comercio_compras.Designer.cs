namespace supermercado
{
    partial class comercio_compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(comercio_compras));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionControl = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesión = new System.Windows.Forms.ToolStripMenuItem();
            this.salir = new System.Windows.Forms.ToolStripMenuItem();
            this.VerEnTiempoReal = new System.Windows.Forms.Button();
            this.btn_Deliberi = new System.Windows.Forms.Button();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Desktop;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.opcionSalir});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionControl,
            this.controlDeEmpleadoToolStripMenuItem});
            resources.ApplyResources(this.archivoToolStripMenuItem, "archivoToolStripMenuItem");
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            // 
            // opcionControl
            // 
            resources.ApplyResources(this.opcionControl, "opcionControl");
            this.opcionControl.Name = "opcionControl";
            this.opcionControl.Click += new System.EventHandler(this.opcionControl_Click_1);
            // 
            // controlDeEmpleadoToolStripMenuItem
            // 
            resources.ApplyResources(this.controlDeEmpleadoToolStripMenuItem, "controlDeEmpleadoToolStripMenuItem");
            this.controlDeEmpleadoToolStripMenuItem.Name = "controlDeEmpleadoToolStripMenuItem";
            this.controlDeEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.controlDeEmpleadoToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionCompra});
            resources.ApplyResources(this.inventarioToolStripMenuItem, "inventarioToolStripMenuItem");
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            // 
            // opcionCompra
            // 
            resources.ApplyResources(this.opcionCompra, "opcionCompra");
            this.opcionCompra.Name = "opcionCompra";
            this.opcionCompra.Click += new System.EventHandler(this.opcionCompra_Click);
            // 
            // opcionSalir
            // 
            this.opcionSalir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesión,
            this.salir});
            resources.ApplyResources(this.opcionSalir, "opcionSalir");
            this.opcionSalir.Name = "opcionSalir";
            // 
            // cerrarSesión
            // 
            resources.ApplyResources(this.cerrarSesión, "cerrarSesión");
            this.cerrarSesión.Name = "cerrarSesión";
            this.cerrarSesión.Click += new System.EventHandler(this.cerrarSesión_Click);
            // 
            // salir
            // 
            resources.ApplyResources(this.salir, "salir");
            this.salir.Name = "salir";
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // VerEnTiempoReal
            // 
            this.VerEnTiempoReal.BackColor = System.Drawing.SystemColors.Desktop;
            resources.ApplyResources(this.VerEnTiempoReal, "VerEnTiempoReal");
            this.VerEnTiempoReal.Name = "VerEnTiempoReal";
            this.VerEnTiempoReal.UseVisualStyleBackColor = false;
            this.VerEnTiempoReal.Click += new System.EventHandler(this.VerEnTiempoReal_Click);
            // 
            // btn_Deliberi
            // 
            resources.ApplyResources(this.btn_Deliberi, "btn_Deliberi");
            this.btn_Deliberi.BackColor = System.Drawing.Color.Maroon;
            this.btn_Deliberi.Name = "btn_Deliberi";
            this.btn_Deliberi.UseVisualStyleBackColor = false;
            this.btn_Deliberi.Click += new System.EventHandler(this.btn_Deliberi_Click);
            // 
            // txt_tel
            // 
            resources.ApplyResources(this.txt_tel, "txt_tel");
            this.txt_tel.Name = "txt_tel";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // comercio_compras
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.btn_Deliberi);
            this.Controls.Add(this.VerEnTiempoReal);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "comercio_compras";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionControl;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionCompra;
        private System.Windows.Forms.ToolStripMenuItem opcionSalir;
        private System.Windows.Forms.ToolStripMenuItem salir;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesión;
        private System.Windows.Forms.ToolStripMenuItem controlDeEmpleadoToolStripMenuItem;
        private System.Windows.Forms.Button VerEnTiempoReal;
        private System.Windows.Forms.Button btn_Deliberi;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}