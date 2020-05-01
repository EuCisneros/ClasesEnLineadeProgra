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
            this.components = new System.ComponentModel.Container();
            this.btncancelar = new System.Windows.Forms.Button();
            this.grdBusquedaPeliculas = new System.Windows.Forms.DataGridView();
            this.peliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_sistema_peliculas = new ClasedeProgramacion.DataSet_sistema_peliculas();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.peliculas1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peliculas1TableAdapter = new ClasedeProgramacion.DataSet_sistema_peliculasTableAdapters.peliculas1TableAdapter();
            this.peliculas1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idPeliculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAlquilerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinopsisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_sistema_peliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculas1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculas1BindingSource1)).BeginInit();
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
            // grdBusquedaPeliculas
            // 
            this.grdBusquedaPeliculas.AllowUserToAddRows = false;
            this.grdBusquedaPeliculas.AllowUserToDeleteRows = false;
            this.grdBusquedaPeliculas.AutoGenerateColumns = false;
            this.grdBusquedaPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPeliculaDataGridViewTextBoxColumn,
            this.idAlquilerDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.sinopsisDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.duracionDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn});
            this.grdBusquedaPeliculas.DataSource = this.peliculas1BindingSource1;
            this.grdBusquedaPeliculas.Location = new System.Drawing.Point(5, 52);
            this.grdBusquedaPeliculas.Margin = new System.Windows.Forms.Padding(1);
            this.grdBusquedaPeliculas.Name = "grdBusquedaPeliculas";
            this.grdBusquedaPeliculas.ReadOnly = true;
            this.grdBusquedaPeliculas.RowHeadersWidth = 102;
            this.grdBusquedaPeliculas.RowTemplate.Height = 40;
            this.grdBusquedaPeliculas.Size = new System.Drawing.Size(789, 346);
            this.grdBusquedaPeliculas.TabIndex = 19;
            // 
            // peliculasBindingSource
            // 
            this.peliculasBindingSource.DataMember = "peliculas";
            this.peliculasBindingSource.DataSource = this.dataSet_sistema_peliculas;
            // 
            // dataSet_sistema_peliculas
            // 
            this.dataSet_sistema_peliculas.DataSetName = "DataSet_sistema_peliculas";
            this.dataSet_sistema_peliculas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // peliculas1BindingSource
            // 
            this.peliculas1BindingSource.DataMember = "peliculas1";
            this.peliculas1BindingSource.DataSource = this.dataSet_sistema_peliculas;
            // 
            // peliculas1TableAdapter
            // 
            this.peliculas1TableAdapter.ClearBeforeFill = true;
            // 
            // peliculas1BindingSource1
            // 
            this.peliculas1BindingSource1.DataMember = "peliculas1";
            this.peliculas1BindingSource1.DataSource = this.dataSet_sistema_peliculas;
            // 
            // idPeliculaDataGridViewTextBoxColumn
            // 
            this.idPeliculaDataGridViewTextBoxColumn.DataPropertyName = "IdPelicula";
            this.idPeliculaDataGridViewTextBoxColumn.HeaderText = "IdPelicula";
            this.idPeliculaDataGridViewTextBoxColumn.Name = "idPeliculaDataGridViewTextBoxColumn";
            this.idPeliculaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPeliculaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idAlquilerDataGridViewTextBoxColumn
            // 
            this.idAlquilerDataGridViewTextBoxColumn.DataPropertyName = "IdAlquiler";
            this.idAlquilerDataGridViewTextBoxColumn.HeaderText = "Alquiler";
            this.idAlquilerDataGridViewTextBoxColumn.Name = "idAlquilerDataGridViewTextBoxColumn";
            this.idAlquilerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sinopsisDataGridViewTextBoxColumn
            // 
            this.sinopsisDataGridViewTextBoxColumn.DataPropertyName = "sinopsis";
            this.sinopsisDataGridViewTextBoxColumn.HeaderText = "Sinopsis";
            this.sinopsisDataGridViewTextBoxColumn.Name = "sinopsisDataGridViewTextBoxColumn";
            this.sinopsisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            this.generoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duracionDataGridViewTextBoxColumn
            // 
            this.duracionDataGridViewTextBoxColumn.DataPropertyName = "duracion";
            this.duracionDataGridViewTextBoxColumn.HeaderText = "Duracion";
            this.duracionDataGridViewTextBoxColumn.Name = "duracionDataGridViewTextBoxColumn";
            this.duracionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            this.costoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BusquedaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(804, 406);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.grdBusquedaPeliculas);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.btnseleccionar);
            this.Name = "BusquedaProductos";
            this.Text = "Busqueda de Peliculas";
            this.Load += new System.EventHandler(this.BusquedaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_sistema_peliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculas1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculas1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DataGridView grdBusquedaPeliculas;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.Button btnseleccionar;
        private DataSet_sistema_peliculas dataSet_sistema_peliculas;
        private System.Windows.Forms.BindingSource peliculasBindingSource;
        private System.Windows.Forms.BindingSource peliculas1BindingSource;
        private DataSet_sistema_peliculasTableAdapters.peliculas1TableAdapter peliculas1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPeliculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlquilerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinopsisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource peliculas1BindingSource1;
    }
}