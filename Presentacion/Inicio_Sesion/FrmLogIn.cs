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
using System.Xml;

namespace Presentacion
{
    public partial class FrmLogIn : Form
    {
        BOUsuarios boUsuarios = new BOUsuarios();

        private string ruta = "Datos.xml";

        public FrmLogIn()
        {
            InitializeComponent();
            
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

            ValidarUsuario(txt_Usuario.Text);   
        }



        public void ValidarUsuario(string usuario)
        {
            List<string> cedulas = boUsuarios.ObtenerCedulas(ruta);
            if (cedulas.Contains(usuario))
            {
                //new Menu.FrmComprar().Show();
                FrmComprar frmComprar = new FrmComprar();
                frmComprar.Show();
                frmComprar.ValidarUsuario(usuario);

                //this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
        }

        

        
    }
}
