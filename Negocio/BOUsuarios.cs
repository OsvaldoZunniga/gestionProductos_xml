using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Datos;
using Objetos;

namespace Negocio
{
    public class BOUsuarios
    {
        XmlDocument doc;
        string rutaXml;

        public XmlNode CrearUsuario(OBJUsuario user)
        {
            XmlNode usuario = doc.CreateElement("Usuario");

            XmlElement xIdUsuario = doc.CreateElement("IdUsuario");
            xIdUsuario.InnerText = user.IdUsuario.ToString();
            usuario.AppendChild(xIdUsuario);

            XmlElement xNombre = doc.CreateElement("Nombre");
            xNombre.InnerText = user.Nombre;
            usuario.AppendChild(xNombre);

            XmlElement xGenero = doc.CreateElement("Genero");
            xGenero.InnerText = user.Genero;
            usuario.AppendChild(xNombre);


            return usuario;
        }

        public void LeerXML(string ruta)
        {
            doc = new XmlDocument();
            doc.Load(ruta);
        }

        public void Registrar(OBJUsuario user, string rutaXml)
        {
            XmlNode usuario = CrearUsuario(user);

            XmlNode nodo = doc.DocumentElement;
            nodo.InsertAfter(usuario, nodo.LastChild);

            new DAOGeneral().guardarDatos(doc, rutaXml);

        }

    }
}
