namespace Segundo_Parcial
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelBarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlquiler = new System.Windows.Forms.Button();
            this.btnPeliculas = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.PanelContenedorPrincipal = new System.Windows.Forms.Panel();
            this.PanelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.BackColor = System.Drawing.Color.Firebrick;
            this.PanelBarraTitulo.Controls.Add(this.pictureBox1);
            this.PanelBarraTitulo.Controls.Add(this.label1);
            this.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelBarraTitulo.Name = "PanelBarraTitulo";
            this.PanelBarraTitulo.Size = new System.Drawing.Size(1081, 62);
            this.PanelBarraTitulo.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alquiler de Películas";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Goldenrod;
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.btnAlquiler);
            this.panelMenu.Controls.Add(this.btnPeliculas);
            this.panelMenu.Controls.Add(this.btnCliente);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 62);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(170, 406);
            this.panelMenu.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Alquiler";
            // 
            // btnAlquiler
            // 
            this.btnAlquiler.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAlquiler.FlatAppearance.BorderSize = 0;
            this.btnAlquiler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnAlquiler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlquiler.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlquiler.ForeColor = System.Drawing.Color.Black;
            this.btnAlquiler.Image = ((System.Drawing.Image)(resources.GetObject("btnAlquiler.Image")));
            this.btnAlquiler.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAlquiler.Location = new System.Drawing.Point(3, 143);
            this.btnAlquiler.Name = "btnAlquiler";
            this.btnAlquiler.Size = new System.Drawing.Size(176, 42);
            this.btnAlquiler.TabIndex = 19;
            this.btnAlquiler.Text = "  Alquiler";
            this.btnAlquiler.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAlquiler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlquiler.UseVisualStyleBackColor = true;
            this.btnAlquiler.Click += new System.EventHandler(this.btnAlquiler_Click);
            // 
            // btnPeliculas
            // 
            this.btnPeliculas.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPeliculas.FlatAppearance.BorderSize = 0;
            this.btnPeliculas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnPeliculas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeliculas.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeliculas.ForeColor = System.Drawing.Color.Black;
            this.btnPeliculas.Image = ((System.Drawing.Image)(resources.GetObject("btnPeliculas.Image")));
            this.btnPeliculas.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnPeliculas.Location = new System.Drawing.Point(3, 95);
            this.btnPeliculas.Name = "btnPeliculas";
            this.btnPeliculas.Size = new System.Drawing.Size(176, 42);
            this.btnPeliculas.TabIndex = 17;
            this.btnPeliculas.Text = "  Películas";
            this.btnPeliculas.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnPeliculas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPeliculas.UseVisualStyleBackColor = true;
            this.btnPeliculas.Click += new System.EventHandler(this.btnPeliculas_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.Black;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCliente.Location = new System.Drawing.Point(3, 47);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(176, 42);
            this.btnCliente.TabIndex = 15;
            this.btnCliente.Text = "  Clientes";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // PanelContenedorPrincipal
            // 
            this.PanelContenedorPrincipal.BackColor = System.Drawing.Color.Peru;
            this.PanelContenedorPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelContenedorPrincipal.BackgroundImage")));
            this.PanelContenedorPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedorPrincipal.Location = new System.Drawing.Point(170, 62);
            this.PanelContenedorPrincipal.Name = "PanelContenedorPrincipal";
            this.PanelContenedorPrincipal.Size = new System.Drawing.Size(911, 406);
            this.PanelContenedorPrincipal.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 468);
            this.Controls.Add(this.PanelContenedorPrincipal);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.PanelBarraTitulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alquiler de Peliculas";
            this.PanelBarraTitulo.ResumeLayout(false);
            this.PanelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBarraTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAlquiler;
        private System.Windows.Forms.Button btnPeliculas;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel PanelContenedorPrincipal;
    }
}

