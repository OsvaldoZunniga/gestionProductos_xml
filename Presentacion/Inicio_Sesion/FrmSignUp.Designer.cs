namespace Presentacion
{
    partial class FrmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignUp));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_LogIn = new System.Windows.Forms.LinkLabel();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.txt_newUser_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_newUser_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_NewUser_Genero = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(672, 410);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cmb_NewUser_Genero);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_newUser_Nombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lbl_LogIn);
            this.panel1.Controls.Add(this.btn_Aceptar);
            this.panel1.Controls.Add(this.txt_newUser_Id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(40, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 232);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_LogIn
            // 
            this.lbl_LogIn.AutoSize = true;
            this.lbl_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LogIn.Location = new System.Drawing.Point(64, 196);
            this.lbl_LogIn.Name = "lbl_LogIn";
            this.lbl_LogIn.Size = new System.Drawing.Size(154, 15);
            this.lbl_LogIn.TabIndex = 3;
            this.lbl_LogIn.TabStop = true;
            this.lbl_LogIn.Text = "¿Ya tienes un usuario?";
            this.lbl_LogIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_LogIn_LinkClicked);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(92, 170);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 2;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // txt_newUser_Id
            // 
            this.txt_newUser_Id.ForeColor = System.Drawing.Color.Gray;
            this.txt_newUser_Id.Location = new System.Drawing.Point(49, 36);
            this.txt_newUser_Id.Name = "txt_newUser_Id";
            this.txt_newUser_Id.Size = new System.Drawing.Size(169, 20);
            this.txt_newUser_Id.TabIndex = 1;
            this.txt_newUser_Id.Text = "Ingresa tu ID:";
            this.txt_newUser_Id.Click += new System.EventHandler(this.txt_newUser_Id_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txt_newUser_Nombre
            // 
            this.txt_newUser_Nombre.ForeColor = System.Drawing.Color.Gray;
            this.txt_newUser_Nombre.Location = new System.Drawing.Point(49, 80);
            this.txt_newUser_Nombre.Name = "txt_newUser_Nombre";
            this.txt_newUser_Nombre.Size = new System.Drawing.Size(169, 20);
            this.txt_newUser_Nombre.TabIndex = 6;
            this.txt_newUser_Nombre.Text = "Ingresa tu nombre:";
            this.txt_newUser_Nombre.Click += new System.EventHandler(this.txt_Nombre_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Genero:";
            // 
            // cmb_NewUser_Genero
            // 
            this.cmb_NewUser_Genero.FormattingEnabled = true;
            this.cmb_NewUser_Genero.Items.AddRange(new object[] {
            "-Elige Genero-",
            "Masculino",
            "Femenino"});
            this.cmb_NewUser_Genero.Location = new System.Drawing.Point(49, 126);
            this.cmb_NewUser_Genero.Name = "cmb_NewUser_Genero";
            this.cmb_NewUser_Genero.Size = new System.Drawing.Size(169, 21);
            this.cmb_NewUser_Genero.TabIndex = 8;
            // 
            // FrmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrarse";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.TextBox txt_newUser_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel lbl_LogIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_newUser_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_NewUser_Genero;
    }
}