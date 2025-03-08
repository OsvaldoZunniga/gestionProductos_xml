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
    public class BOProductos
    {
        XmlDocument doc;
        string rutaXml;




        public void CrearXML(string ruta, string nodoRaiz)
        {
            //doc = new XmlDocument();
            //XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", "no");

            //XmlNode nodo = doc.DocumentElement;
            //doc.InsertBefore(xmlDeclaration, nodo);

            //XmlNode elemento = doc.CreateElement(nodoRaiz);
            //doc.AppendChild(elemento);

            //new DAOProductos().guardarDatos(doc, ruta);

        }

        public void LeerXML(string ruta)
        {
            doc = new XmlDocument();
            doc.Load(ruta);
        }

        public void Registrar(OBJProducto product, string rutaXml)
        {
            XmlNode producto = CrearProducto(product);

            XmlNode nodo = doc.DocumentElement;
            nodo.InsertAfter(producto, nodo.LastChild);

            new DAOGeneral().guardarDatos(doc, rutaXml);

        }

        public XmlNode CrearProducto(OBJProducto est)
        {
            XmlNode producto = doc.CreateElement("Producto");
            XmlElement xIdProducto = doc.CreateElement("IdProducto");
            xIdProducto.InnerText = est.IdProducto.ToString();
            producto.AppendChild(xIdProducto);

            XmlElement xNombre = doc.CreateElement("Nombre");
            xNombre.InnerText = est.Nombre;
            producto.AppendChild(xNombre);

            XmlElement xPrecio = doc.CreateElement("Precio");
            xPrecio.InnerText = est.Precio.ToString();
            producto.AppendChild(xPrecio);

            XmlElement xDescripcion = doc.CreateElement("Descripcion");
            xDescripcion.InnerText = est.Descripcion;
            producto.AppendChild(xDescripcion);

            XmlElement xCalorias = doc.CreateElement("Calorias");
            xCalorias.InnerText = est.Calorias.ToString();
            producto.AppendChild(xCalorias);

            XmlElement xStock = doc.CreateElement("Stock");
            xStock.InnerText = est.Stock.ToString();
            producto.AppendChild(xStock);

            XmlElement xCategoria = doc.CreateElement("Categoria");
            xCategoria.InnerText = est.Categoria;
            producto.AppendChild(xCategoria);

            return producto;
        }

        public void Modificar(OBJProducto product, string rutaXml)
        {
            doc = new XmlDocument();
            doc.Load(rutaXml);

            XmlNodeList listaProductos = doc.SelectNodes("Productos/Producto");

            foreach (XmlNode item in listaProductos)
            {
                if (Convert.ToInt32(item.SelectSingleNode("IdProducto").InnerText) == product.IdProducto)
                {
                    item.SelectSingleNode("Nombre").InnerText = product.Nombre;
                    item.SelectSingleNode("Precio").InnerText = product.Precio.ToString();
                    item.SelectSingleNode("Descripcion").InnerText = product.Descripcion;
                    item.SelectSingleNode("Calorias").InnerText = product.Calorias.ToString();
                    item.SelectSingleNode("Stock").InnerText = product.Stock.ToString();
                    item.SelectSingleNode("Categoria").InnerText = product.Categoria;
                }
            }
            new DAOGeneral().guardarDatos(doc, rutaXml);
        }




    }
}
