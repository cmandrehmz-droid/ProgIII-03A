namespace Proyecto_Individual_MZ
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnLP = new System.Windows.Forms.TableLayoutPanel();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnEntregas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.BtnLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 500);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "“El sabor que une momentos”";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Individual_MZ.Properties.Resources.imagen_2026_05_03_195404526_351x108;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(369, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // BtnLP
            // 
            this.BtnLP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnLP.ColumnCount = 2;
            this.BtnLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BtnLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BtnLP.Controls.Add(this.btnInformes, 1, 1);
            this.BtnLP.Controls.Add(this.btnProductos, 0, 0);
            this.BtnLP.Controls.Add(this.btnPedidos, 1, 0);
            this.BtnLP.Controls.Add(this.btnEntregas, 0, 1);
            this.BtnLP.Location = new System.Drawing.Point(1, 118);
            this.BtnLP.Name = "BtnLP";
            this.BtnLP.RowCount = 2;
            this.BtnLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BtnLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BtnLP.Size = new System.Drawing.Size(428, 379);
            this.BtnLP.TabIndex = 2;
            // 
            // btnInformes
            // 
            this.btnInformes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnInformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.Image = global::Proyecto_Individual_MZ.Properties.Resources.descarga__2__120x120;
            this.btnInformes.Location = new System.Drawing.Point(217, 192);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(201, 184);
            this.btnInformes.TabIndex = 5;
            this.btnInformes.Text = "Informes";
            this.btnInformes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Image = global::Proyecto_Individual_MZ.Properties.Resources.descarga__3__160x128;
            this.btnProductos.Location = new System.Drawing.Point(3, 3);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(203, 183);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPedidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.Color.Black;
            this.btnPedidos.Image = global::Proyecto_Individual_MZ.Properties.Resources.descarga__1__120x120;
            this.btnPedidos.Location = new System.Drawing.Point(217, 3);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(198, 183);
            this.btnPedidos.TabIndex = 1;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnEntregas
            // 
            this.btnEntregas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEntregas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEntregas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEntregas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntregas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntregas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEntregas.Image = global::Proyecto_Individual_MZ.Properties.Resources.imagen_2026_05_03_193024469_removebg_preview_160x105;
            this.btnEntregas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntregas.Location = new System.Drawing.Point(3, 192);
            this.btnEntregas.Name = "btnEntregas";
            this.btnEntregas.Size = new System.Drawing.Size(203, 184);
            this.btnEntregas.TabIndex = 4;
            this.btnEntregas.Text = "Entregas";
            this.btnEntregas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEntregas.UseVisualStyleBackColor = true;
            this.btnEntregas.Click += new System.EventHandler(this.btnEntregas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Individual_MZ.Properties.Resources._360x200_encabezado_490x310;
            this.pictureBox1.Location = new System.Drawing.Point(425, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1049, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLP);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Interfaz de Frisby - Form Principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.BtnLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel BtnLP;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnEntregas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Label label1;
    }
}

