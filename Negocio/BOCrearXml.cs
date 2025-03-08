using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Datos;

namespace Negocio
{
    public class BOCrearXml
    {
        XmlDocument doc;
        string rutaXml;

        public void CrearXML(string ruta, string nodoRaiz)
        {
            doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", "no");

            XmlNode nodo = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, nodo);

            XmlNode elemento = doc.CreateElement(nodoRaiz);
            doc.AppendChild(elemento);

            new DAOGeneral().guardarDatos(doc, ruta);

        }

        public void LeerXML(string ruta)
        {
            doc = new XmlDocument();
            doc.Load(ruta);
        }


    }
}
