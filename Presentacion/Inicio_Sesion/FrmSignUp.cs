using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Objetos;

namespace Presentacion
{
    public partial class FrmSignUp : Form
    {
        BOUsuarios boUsuarios = new BOUsuarios();
        public BOCrearXml boCrearXml;
        string ruta = "Datos.xml";
        public FrmSignUp()
        {
            InitializeComponent();
            boCrearXml = new BOCrearXml();
            CrearXML();
            
        }

        private void lbl_LogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FrmLogIn().Show();
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            

            //Crear usuario en xml
            OBJUsuario user = new OBJUsuario 
            {
                IdUsuario = Convert.ToInt32(txt_newUser_Id.Text),
                Nombre = txt_newUser_Nombre.Text,
                Genero = cmb_NewUser_Genero.Text


            };
            boUsuarios.Registrar(user, ruta);
            LimpiarCampos();

            MessageBox.Show("Usuario creado con exito");
            this.Close();

        }




        private void txt_newUser_Id_Click(object sender, EventArgs e)
        {
            if (txt_newUser_Id.Text == "Ingresa tu ID:")
            {
                txt_newUser_Id.Text = "";
                txt_newUser_Id.ForeColor = Color.Black;
            }
        }

        private void txt_Nombre_Click(object sender, EventArgs e)
        {
            if (txt_newUser_Nombre.Text == "Ingresa tu nombre:")
            {
                txt_newUser_Nombre.Text = "";
                txt_newUser_Nombre.ForeColor = Color.Black;
            }
        }

        public void CrearXML()
        {
            if (!File.Exists(ruta))
            {
                boCrearXml.CrearXML(ruta, "Usuarios");
            }
            else
            {
                boCrearXml.LeerXML(ruta);
            }
        }

        public void LimpiarCampos()
        {
            txt_newUser_Id.Text = "Ingresa tu ID:";
            txt_newUser_Nombre.Text = "Ingresa tu nombre:";
            cmb_NewUser_Genero.Text = "";
        }

        private void CrearUsuario()
        {
            //Crear usuario en xml
        }

    }
}
