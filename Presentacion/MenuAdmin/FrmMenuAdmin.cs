using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.MenuAdmin
{
    public partial class FrmMenuAdmin : Form
    {
        public FrmMenuAdmin()
        {
            InitializeComponent();
        }


        public void MostrarFormulario(Form formulario)
        {
            // Limpiar el panel antes de agregar un nuevo formulario
            pnl_ContenedorAdmin.Controls.Clear();

            // Configurar el formulario hijo
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Agregar el formulario al panel y mostrarlo
            pnl_ContenedorAdmin.Controls.Add(formulario);
            formulario.Show();
        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new SubMenus.FrmSubMenuProductos());
        }

        private void btn_Categorias_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new SubMenus.FrmSubMenuCategorias());
        }

        private void btn_AddProducto_Click(object sender, EventArgs e)
        {
            //MostrarFormulario(new SubMenus.FrmSubMenuProductos());
        }
    }
}
