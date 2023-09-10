namespace DatosContactosHerrClass08sep
{
    partial class Buscador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblbuscar = new System.Windows.Forms.Label();
            this.txtbuscador = new System.Windows.Forms.TextBox();
            this.btnbuscador = new System.Windows.Forms.Button();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(146, 49);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(40, 13);
            this.lblbuscar.TabIndex = 0;
            this.lblbuscar.Text = "Buscar";
            this.lblbuscar.UseWaitCursor = true;
            // 
            // txtbuscador
            // 
            this.txtbuscador.Location = new System.Drawing.Point(226, 42);
            this.txtbuscador.Name = "txtbuscador";
            this.txtbuscador.Size = new System.Drawing.Size(309, 20);
            this.txtbuscador.TabIndex = 1;
            this.txtbuscador.UseWaitCursor = true;
            // 
            // btnbuscador
            // 
            this.btnbuscador.Location = new System.Drawing.Point(566, 39);
            this.btnbuscador.Name = "btnbuscador";
            this.btnbuscador.Size = new System.Drawing.Size(75, 23);
            this.btnbuscador.TabIndex = 2;
            this.btnbuscador.Text = "Buscar";
            this.btnbuscador.UseVisualStyleBackColor = true;
            this.btnbuscador.UseWaitCursor = true;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(673, 39);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(75, 23);
            this.btnadicionar.TabIndex = 3;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.UseWaitCursor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // Buscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.btnbuscador);
            this.Controls.Add(this.txtbuscador);
            this.Controls.Add(this.lblbuscar);
            this.Name = "Buscador";
            this.Text = "Buscador";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.TextBox txtbuscador;
        private System.Windows.Forms.Button btnbuscador;
        private System.Windows.Forms.Button btnadicionar;
    }
}

