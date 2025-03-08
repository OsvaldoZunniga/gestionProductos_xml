using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Datos
{
    public class DAOGeneral
    {

        public void guardarDatos(XmlDocument doc, string ruta)
        {
            doc.Save(ruta);
        }
    }
}
