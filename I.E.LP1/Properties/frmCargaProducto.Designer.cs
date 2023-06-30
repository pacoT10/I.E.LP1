namespace I.E.LP1.Properties
{
    partial class frmCargaProducto
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
            this.lblid = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFR = new System.Windows.Forms.Label();
            this.cmdCosulta = new System.Windows.Forms.Button();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(12, 82);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(38, 25);
            this.lblid.TabIndex = 0;
            this.lblid.Text = " ID";
            this.lblid.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(12, 158);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(87, 25);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre";
            this.lblnombre.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.Location = new System.Drawing.Point(17, 46);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Location = new System.Drawing.Point(17, 198);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblFR
            // 
            this.lblFR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFR.AutoSize = true;
            this.lblFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFR.Location = new System.Drawing.Point(12, 9);
            this.lblFR.Name = "lblFR";
            this.lblFR.Size = new System.Drawing.Size(180, 25);
            this.lblFR.TabIndex = 5;
            this.lblFR.Text = "Fecha de registro";
            // 
            // cmdCosulta
            // 
            this.cmdCosulta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdCosulta.Location = new System.Drawing.Point(55, 272);
            this.cmdCosulta.Name = "cmdCosulta";
            this.cmdCosulta.Size = new System.Drawing.Size(117, 23);
            this.cmdCosulta.TabIndex = 6;
            this.cmdCosulta.Text = "Consultar productos";
            this.cmdCosulta.UseVisualStyleBackColor = true;
            this.cmdCosulta.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdCargar.Location = new System.Drawing.Point(55, 233);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(117, 23);
            this.cmdCargar.TabIndex = 7;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.Location = new System.Drawing.Point(17, 125);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 20);
            this.txtID.TabIndex = 8;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // frmCargaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 307);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.cmdCosulta);
            this.Controls.Add(this.lblFR);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblid);
            this.Name = "frmCargaProducto";
            this.Text = "frmCargaProducto";
            this.Load += new System.EventHandler(this.frmCargaProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFR;
        private System.Windows.Forms.Button cmdCosulta;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.TextBox txtID;
    }
}