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


        public void Registrar(OBJUsuario user, string rutaXml)
        {
            XmlNode usuario = CrearUsuario(user);

            XmlNode nodo = doc.DocumentElement;
            nodo.InsertAfter(usuario, nodo.LastChild);

            new DAOGeneral().guardarDatos(doc, rutaXml);

        }
        public XmlNode CrearUsuario(OBJUsuario user)
        {
            XmlNode usuario = doc.CreateElement("usuario");

            XmlElement xIdUsuario = doc.CreateElement("IdUsuario");
            xIdUsuario.InnerText = user.IdUsuario.ToString();
            usuario.AppendChild(xIdUsuario);

            XmlElement xNombre = doc.CreateElement("Nombre");
            xNombre.InnerText = user.Nombre;
            usuario.AppendChild(xNombre);

            XmlElement xGenero = doc.CreateElement("Genero");
            xGenero.InnerText = user.Genero;
            usuario.AppendChild(xGenero);


            return usuario;
        }


        public List<string> ObtenerCedulas(string rutaXml)
        {
            List<string> cedulas = new List<string>();
            XmlDocument doc = new XmlDocument();
            doc.Load(rutaXml);

            XmlNodeList usuarios = doc.SelectNodes("//usuario");
            foreach (XmlNode usuario in usuarios)
            {
                string cedula = usuario.SelectSingleNode("IdUsuario")?.InnerText;
                if (!string.IsNullOrEmpty(cedula))
                {
                    cedulas.Add(cedula);
                }
            }

            return cedulas;
        }




    }
}
