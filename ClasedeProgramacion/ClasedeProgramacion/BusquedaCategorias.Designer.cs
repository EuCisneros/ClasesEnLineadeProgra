namespace ClasedeProgramacion
{
    partial class BusquedaCategorias
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
            this.components = new System.ComponentModel.Container();
            this.btncancelar = new System.Windows.Forms.Button();
            this.grdBusquedaCategorias = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.dataSet_sistema_peliculas = new ClasedeProgramacion.DataSet_sistema_peliculas();
            this.alquilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alquilerTableAdapter = new ClasedeProgramacion.DataSet_sistema_peliculasTableAdapters.alquilerTableAdapter();
            this.idAlquilerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPeliculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaprestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechadevolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_sistema_peliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(288, 397);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(77, 31);
            this.btncancelar.TabIndex = 20;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // grdBusquedaCategorias
            // 
            this.grdBusquedaCategorias.AllowUserToAddRows = false;
            this.grdBusquedaCategorias.AllowUserToDeleteRows = false;
            this.grdBusquedaCategorias.AutoGenerateColumns = false;
            this.grdBusquedaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlquilerDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.idPeliculaDataGridViewTextBoxColumn,
            this.fechaprestamoDataGridViewTextBoxColumn,
            this.fechadevolucionDataGridViewTextBoxColumn});
            this.grdBusquedaCategorias.DataSource = this.alquilerBindingSource;
            this.grdBusquedaCategorias.Location = new System.Drawing.Point(8, 49);
            this.grdBusquedaCategorias.Margin = new System.Windows.Forms.Padding(1);
            this.grdBusquedaCategorias.Name = "grdBusquedaCategorias";
            this.grdBusquedaCategorias.ReadOnly = true;
            this.grdBusquedaCategorias.RowHeadersWidth = 102;
            this.grdBusquedaCategorias.RowTemplate.Height = 40;
            this.grdBusquedaCategorias.Size = new System.Drawing.Size(538, 346);
            this.grdBusquedaCategorias.TabIndex = 19;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(66, 11);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(1);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(295, 20);
            this.txtbuscar.TabIndex = 18;
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.ForeColor = System.Drawing.Color.White;
            this.lblbuscar.Location = new System.Drawing.Point(10, 14);
            this.lblbuscar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(54, 13);
            this.lblbuscar.TabIndex = 17;
            this.lblbuscar.Text = "BUSCAR:";
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.Location = new System.Drawing.Point(192, 397);
            this.btnseleccionar.Margin = new System.Windows.Forms.Padding(1);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(94, 31);
            this.btnseleccionar.TabIndex = 16;
            this.btnseleccionar.Text = "SELECCIONAR";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            // 
            // dataSet_sistema_peliculas
            // 
            this.dataSet_sistema_peliculas.DataSetName = "DataSet_sistema_peliculas";
            this.dataSet_sistema_peliculas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alquilerBindingSource
            // 
            this.alquilerBindingSource.DataMember = "alquiler";
            this.alquilerBindingSource.DataSource = this.dataSet_sistema_peliculas;
            // 
            // alquilerTableAdapter
            // 
            this.alquilerTableAdapter.ClearBeforeFill = true;
            // 
            // idAlquilerDataGridViewTextBoxColumn
            // 
            this.idAlquilerDataGridViewTextBoxColumn.DataPropertyName = "IdAlquiler";
            this.idAlquilerDataGridViewTextBoxColumn.HeaderText = "IdAlquiler";
            this.idAlquilerDataGridViewTextBoxColumn.Name = "idAlquilerDataGridViewTextBoxColumn";
            this.idAlquilerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAlquilerDataGridViewTextBoxColumn.Visible = false;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPeliculaDataGridViewTextBoxColumn
            // 
            this.idPeliculaDataGridViewTextBoxColumn.DataPropertyName = "IdPelicula";
            this.idPeliculaDataGridViewTextBoxColumn.HeaderText = "Pelicula";
            this.idPeliculaDataGridViewTextBoxColumn.Name = "idPeliculaDataGridViewTextBoxColumn";
            this.idPeliculaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaprestamoDataGridViewTextBoxColumn
            // 
            this.fechaprestamoDataGridViewTextBoxColumn.DataPropertyName = "fecha_prestamo";
            this.fechaprestamoDataGridViewTextBoxColumn.HeaderText = "Fecha de Prestamo";
            this.fechaprestamoDataGridViewTextBoxColumn.Name = "fechaprestamoDataGridViewTextBoxColumn";
            this.fechaprestamoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechadevolucionDataGridViewTextBoxColumn
            // 
            this.fechadevolucionDataGridViewTextBoxColumn.DataPropertyName = "fecha_devolucion";
            this.fechadevolucionDataGridViewTextBoxColumn.HeaderText = "Fecha de Devolucion";
            this.fechadevolucionDataGridViewTextBoxColumn.Name = "fechadevolucionDataGridViewTextBoxColumn";
            this.fechadevolucionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BusquedaCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(606, 442);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.grdBusquedaCategorias);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.btnseleccionar);
            this.Name = "BusquedaCategorias";
            this.Text = "Busqueda de Alquiler";
            this.Load += new System.EventHandler(this.BusquedaCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_sistema_peliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DataGridView grdBusquedaCategorias;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.Button btnseleccionar;
        private DataSet_sistema_peliculas dataSet_sistema_peliculas;
        private System.Windows.Forms.BindingSource alquilerBindingSource;
        private DataSet_sistema_peliculasTableAdapters.alquilerTableAdapter alquilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlquilerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPeliculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaprestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechadevolucionDataGridViewTextBoxColumn;
    }
}