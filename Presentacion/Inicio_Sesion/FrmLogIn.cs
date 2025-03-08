using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Presentacion.MenuAdmin;
using Presentacion.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Presentacion
{
    public partial class FrmLogIn : Form
    {
        BOUsuarios boUsuarios = new BOUsuarios();
        public BOCrearXml boCrearXml;
        string ruta = "Datos.xml";

        public FrmLogIn()
        {
            InitializeComponent();
            boCrearXml = new BOCrearXml();
            CrearXML();
        }

        private void txt_Usuario_Click(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "Usuario") 
            {
                txt_Usuario.Text = "";
                txt_Usuario.ForeColor = Color.Black;
            }
        }

        private void lbl_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSignUp frmSignUp = new FrmSignUp();
            frmSignUp.Show();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            //new Menu.FrmComprar().Show();
            new FrmMenuAdmin().Show();
            this.Hide();
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
    }
}
