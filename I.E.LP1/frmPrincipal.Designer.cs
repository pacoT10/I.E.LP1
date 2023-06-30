namespace I.E.LP1
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.cmdCarga = new System.Windows.Forms.Button();
            this.cmdVentas = new System.Windows.Forms.Button();
            this.cmdListado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdCarga
            // 
            this.cmdCarga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCarga.Location = new System.Drawing.Point(86, 112);
            this.cmdCarga.Name = "cmdCarga";
            this.cmdCarga.Size = new System.Drawing.Size(212, 60);
            this.cmdCarga.TabIndex = 0;
            this.cmdCarga.Text = "Cargar producto";
            this.cmdCarga.UseVisualStyleBackColor = true;
            this.cmdCarga.Click += new System.EventHandler(this.cmdCarga_Click);
            // 
            // cmdVentas
            // 
            this.cmdVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVentas.Location = new System.Drawing.Point(86, 194);
            this.cmdVentas.Name = "cmdVentas";
            this.cmdVentas.Size = new System.Drawing.Size(212, 56);
            this.cmdVentas.TabIndex = 1;
            this.cmdVentas.Text = "Cargar venta";
            this.cmdVentas.UseVisualStyleBackColor = true;
            this.cmdVentas.Click += new System.EventHandler(this.cmdVentas_Click);
            // 
            // cmdListado
            // 
            this.cmdListado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListado.Location = new System.Drawing.Point(86, 278);
            this.cmdListado.Name = "cmdListado";
            this.cmdListado.Size = new System.Drawing.Size(212, 57);
            this.cmdListado.TabIndex = 2;
            this.cmdListado.Text = "Listado";
            this.cmdListado.UseVisualStyleBackColor = true;
            this.cmdListado.Click += new System.EventHandler(this.cmdListado_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenido  ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "¿que desea hacer?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 365);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdListado);
            this.Controls.Add(this.cmdVentas);
            this.Controls.Add(this.cmdCarga);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Gestion de productos y ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCarga;
        private System.Windows.Forms.Button cmdVentas;
        private System.Windows.Forms.Button cmdListado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

