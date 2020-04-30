namespace ClasedeProgramacion
{
    partial class BusquedaProductos
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.grdBusquedaProductos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.btnseleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(471, 11);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(77, 31);
            this.btncancelar.TabIndex = 20;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // grdBusquedaProductos
            // 
            this.grdBusquedaProductos.AllowUserToAddRows = false;
            this.grdBusquedaProductos.AllowUserToDeleteRows = false;
            this.grdBusquedaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.categoria,
            this.codigo,
            this.nombre,
            this.marca,
            this.presentacion});
            this.grdBusquedaProductos.Location = new System.Drawing.Point(5, 52);
            this.grdBusquedaProductos.Margin = new System.Windows.Forms.Padding(1);
            this.grdBusquedaProductos.Name = "grdBusquedaProductos";
            this.grdBusquedaProductos.ReadOnly = true;
            this.grdBusquedaProductos.RowHeadersWidth = 102;
            this.grdBusquedaProductos.RowTemplate.Height = 40;
            this.grdBusquedaProductos.Size = new System.Drawing.Size(789, 346);
            this.grdBusquedaProductos.TabIndex = 19;
            // 
            // idProducto
            // 
            this.idProducto.DataPropertyName = "idProducto";
            this.idProducto.HeaderText = "ID";
            this.idProducto.MinimumWidth = 12;
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            this.idProducto.Width = 250;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            this.categoria.HeaderText = "CATEGORIA";
            this.categoria.MinimumWidth = 12;
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 250;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.MinimumWidth = 12;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 50;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.MinimumWidth = 12;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "MARCA";
            this.marca.MinimumWidth = 12;
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            this.marca.Width = 250;
            // 
            // presentacion
            // 
            this.presentacion.DataPropertyName = "presentacion";
            this.presentacion.HeaderText = "PRESENTACION";
            this.presentacion.MinimumWidth = 12;
            this.presentacion.Name = "presentacion";
            this.presentacion.ReadOnly = true;
            this.presentacion.Width = 250;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(69, 21);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(1);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(295, 20);
            this.txtbuscar.TabIndex = 18;
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.ForeColor = System.Drawing.Color.White;
            this.lblbuscar.Location = new System.Drawing.Point(14, 24);
            this.lblbuscar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(54, 13);
            this.lblbuscar.TabIndex = 17;
            this.lblbuscar.Text = "BUSCAR:";
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.Location = new System.Drawing.Point(375, 11);
            this.btnseleccionar.Margin = new System.Windows.Forms.Padding(1);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(94, 31);
            this.btnseleccionar.TabIndex = 16;
            this.btnseleccionar.Text = "SELECCIONAR";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            // 
            // BusquedaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(804, 406);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.grdBusquedaProductos);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.btnseleccionar);
            this.Name = "BusquedaProductos";
            this.Text = "Busqueda de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DataGridView grdBusquedaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentacion;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.Button btnseleccionar;
    }
}