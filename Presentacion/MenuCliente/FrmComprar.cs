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

namespace Presentacion.Menu
{
    public partial class FrmComprar : Form
    {
        public BOProductos boProduct = new BOProductos();
        string ruta = "Datos.xml";

        public FrmComprar()
        {
            InitializeComponent();
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
    }
}
