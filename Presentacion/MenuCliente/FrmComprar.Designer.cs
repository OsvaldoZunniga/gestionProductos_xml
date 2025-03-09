namespace Presentacion.Menu
{
    partial class FrmComprar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComprar));
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_CerrarSesion = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Calorias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Admin = new System.Windows.Forms.Panel();
            this.btn_AdminZone = new System.Windows.Forms.Button();
            this.pnl_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_Admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Titulo.BackgroundImage")));
            this.pnl_Titulo.Controls.Add(this.label1);
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Size = new System.Drawing.Size(685, 48);
            this.pnl_Titulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compra de Productos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CerrarSesion
            // 
            this.lbl_CerrarSesion.AutoSize = true;
            this.lbl_CerrarSesion.Location = new System.Drawing.Point(557, 351);
            this.lbl_CerrarSesion.Name = "lbl_CerrarSesion";
            this.lbl_CerrarSesion.Size = new System.Drawing.Size(116, 13);
            this.lbl_CerrarSesion.TabIndex = 12;
            this.lbl_CerrarSesion.TabStop = true;
            this.lbl_CerrarSesion.Text = "¿Desea Cerrar Sesión?";
            this.lbl_CerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_CerrarSesion_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_Producto,
            this.txt_Precio,
            this.txt_Descripcion,
            this.txt_Calorias,
            this.txt_Stock,
            this.txt_Categoria});
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(646, 236);
            this.dataGridView1.TabIndex = 13;
            // 
            // txt_Producto
            // 
            this.txt_Producto.HeaderText = "Producto";
            this.txt_Producto.Name = "txt_Producto";
            this.txt_Producto.ReadOnly = true;
            // 
            // txt_Precio
            // 
            this.txt_Precio.HeaderText = "Precio";
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.ReadOnly = true;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.HeaderText = "Descripcion";
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.ReadOnly = true;
            // 
            // txt_Calorias
            // 
            this.txt_Calorias.HeaderText = "Calorias";
            this.txt_Calorias.Name = "txt_Calorias";
            this.txt_Calorias.ReadOnly = true;
            // 
            // txt_Stock
            // 
            this.txt_Stock.HeaderText = "Cantidad";
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.ReadOnly = true;
            // 
            // txt_Categoria
            // 
            this.txt_Categoria.HeaderText = "Categoria";
            this.txt_Categoria.Name = "txt_Categoria";
            this.txt_Categoria.ReadOnly = true;
            // 
            // pnl_Admin
            // 
            this.pnl_Admin.BackColor = System.Drawing.Color.Red;
            this.pnl_Admin.Controls.Add(this.btn_AdminZone);
            this.pnl_Admin.Location = new System.Drawing.Point(12, 316);
            this.pnl_Admin.Name = "pnl_Admin";
            this.pnl_Admin.Size = new System.Drawing.Size(141, 45);
            this.pnl_Admin.TabIndex = 14;
            this.pnl_Admin.Visible = false;
            // 
            // btn_AdminZone
            // 
            this.btn_AdminZone.Location = new System.Drawing.Point(29, 11);
            this.btn_AdminZone.Name = "btn_AdminZone";
            this.btn_AdminZone.Size = new System.Drawing.Size(75, 23);
            this.btn_AdminZone.TabIndex = 0;
            this.btn_AdminZone.Text = "Zona Admin";
            this.btn_AdminZone.UseVisualStyleBackColor = true;
            this.btn_AdminZone.Click += new System.EventHandler(this.btn_AdminZone_Click);
            // 
            // FrmComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 373);
            this.Controls.Add(this.pnl_Admin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_CerrarSesion);
            this.Controls.Add(this.pnl_Titulo);
            this.Name = "FrmComprar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprar Productos";
            this.pnl_Titulo.ResumeLayout(false);
            this.pnl_Titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_Admin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbl_CerrarSesion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Calorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Categoria;
        private System.Windows.Forms.Panel pnl_Admin;
        private System.Windows.Forms.Button btn_AdminZone;
    }
}