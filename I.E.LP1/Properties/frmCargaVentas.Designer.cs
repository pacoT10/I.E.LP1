namespace I.E.LP1.Properties
{
    partial class frmCargaVentas
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
            this.lblFV = new System.Windows.Forms.Label();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.txtIDV = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cmdCargarV = new System.Windows.Forms.Button();
            this.cmdConsultaV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFV
            // 
            this.lblFV.AutoSize = true;
            this.lblFV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFV.Location = new System.Drawing.Point(12, 9);
            this.lblFV.Name = "lblFV";
            this.lblFV.Size = new System.Drawing.Size(161, 25);
            this.lblFV.TabIndex = 6;
            this.lblFV.Text = "Fecha de venta";
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Location = new System.Drawing.Point(17, 37);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVenta.TabIndex = 7;
            this.dtpFechaVenta.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtIDV
            // 
            this.txtIDV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIDV.Location = new System.Drawing.Point(17, 99);
            this.txtIDV.Name = "txtIDV";
            this.txtIDV.Size = new System.Drawing.Size(200, 20);
            this.txtIDV.TabIndex = 9;
            this.txtIDV.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtIDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDV_KeyPress);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(12, 74);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(32, 25);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "ID";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(12, 148);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(98, 25);
            this.lblProducto.TabIndex = 11;
            this.lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(12, 228);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(98, 25);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.Click += new System.EventHandler(this.lblCantidad_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtProducto.Location = new System.Drawing.Point(17, 176);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(200, 20);
            this.txtProducto.TabIndex = 13;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCantidad.Location = new System.Drawing.Point(17, 256);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(200, 20);
            this.txtCantidad.TabIndex = 14;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // cmdCargarV
            // 
            this.cmdCargarV.Location = new System.Drawing.Point(17, 307);
            this.cmdCargarV.Name = "cmdCargarV";
            this.cmdCargarV.Size = new System.Drawing.Size(75, 23);
            this.cmdCargarV.TabIndex = 15;
            this.cmdCargarV.Text = "Cargar";
            this.cmdCargarV.UseVisualStyleBackColor = true;
            this.cmdCargarV.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdConsultaV
            // 
            this.cmdConsultaV.Location = new System.Drawing.Point(142, 307);
            this.cmdConsultaV.Name = "cmdConsultaV";
            this.cmdConsultaV.Size = new System.Drawing.Size(75, 23);
            this.cmdConsultaV.TabIndex = 16;
            this.cmdConsultaV.Text = "Consultar";
            this.cmdConsultaV.UseVisualStyleBackColor = true;
            this.cmdConsultaV.Click += new System.EventHandler(this.cmdConsultaV_Click);
            // 
            // frmCargaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 342);
            this.Controls.Add(this.cmdConsultaV);
            this.Controls.Add(this.cmdCargarV);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtIDV);
            this.Controls.Add(this.dtpFechaVenta);
            this.Controls.Add(this.lblFV);
            this.Name = "frmCargaVentas";
            this.Text = "frmCargaVentas";
            this.Load += new System.EventHandler(this.frmCargaVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFV;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.TextBox txtIDV;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button cmdCargarV;
        private System.Windows.Forms.Button cmdConsultaV;
    }
}