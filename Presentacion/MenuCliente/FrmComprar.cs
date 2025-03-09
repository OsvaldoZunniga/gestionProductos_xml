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
using Presentacion.MenuAdmin;

namespace Presentacion.Menu
{
    public partial class FrmComprar : Form
    {
        public BOProductos boProduct = new BOProductos();
        string ruta = "Datos.xml";

        private int idUser;

        public FrmComprar()
        {
            InitializeComponent();
            

        }

        public void ValidarUsuario(string _IdUser)
        {
            if (_IdUser != "20870")
            {
                return;
            }

            pnl_Admin.Visible = true;
            
        }

        public void CrearXML()
        {
            if (!File.Exists(ruta))
            {
                boProduct.CrearXML(ruta, "Productos");
            }
            else
            {
                boProduct.LeerXML(ruta);
            }
        }

        private void lbl_CerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            
        }

        private void btn_AdminZone_Click(object sender, EventArgs e)
        {
            new FrmMenuAdmin().Show();
        }
    }
}
