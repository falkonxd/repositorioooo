using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService1.DTO;
using AutoMapper;
using Dominio;

namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public List<CategoriaDTO> Categoriagetall()
        {
            Categoria categoriaDominio = new Categoria();
            var categorias = categoriaDominio.TraerTodo();

            var coleccion = Mapper.Map<List<DTO.CategoriaDTO>>(categorias);

            return coleccion;
        }

        public List<CategoriaDTO> getCategoriesTipo(string dato)
        {
            Categoria categoria = new Categoria();
            var categorias = categoria.Buscar(c => c.Tipo == dato);

            var coleccion = Mapper.Map<List<DTO.CategoriaDTO>>(categorias);

            return coleccion;
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public ProductoDTO getProductobyID(string productoid)
        {
            Producto producto = new Producto();
            var productos = producto.TraerTodoPorID(productoid);

            var objeto = Mapper.Map<DTO.ProductoDTO>(productos);
            return objeto;
        }

        public List<ProductoDTO> getProductosFavoritos()
        {
            Producto producto = new Producto();
            var productos = producto.Buscar(p => p.IsFavorite == true);
            var coleccion = Mapper.Map<List<DTO.ProductoDTO>>(productos);

            return coleccion;
        }

        public List<MarketingDTO> Marketinggetall()
        {
            Marketing marketingDominio = new Marketing();
            var marketings = marketingDominio.TraerTodo();

            var coleccion = Mapper.Map<List<DTO.MarketingDTO>>(marketings);
            return coleccion;
        }

        public List<ProductoDTO> Productogetall()
        {
            Producto productoDominio = new Producto();
            var productos = productoDominio.TraerTodo();

            var coleccion = Mapper.Map<List<DTO.ProductoDTO>>(productos);
            return coleccion;
        }

        public List<ProductoDTO> ProductosDisponibles()
        {
            Producto producto = new Producto();
            var productos = producto.Buscar(p => p.UnidadesStock > 0);
            var coleccion = Mapper.Map<List<DTO.ProductoDTO>>(productos);

            return coleccion;
        }

        public List<ProductoDTO> ProductosporCategoria(string categoryid)
        {
            Producto producto = new Producto();
            var productos = producto.Buscar(p => p.Categoria == categoryid);
            var coleccion = Mapper.Map<List<DTO.ProductoDTO>>(productos);

            return coleccion;
        }

        public List<ProductoDTO> ProductosporMarca(string marcaid)
        {
            Producto producto = new Producto();
            var productos = producto.Buscar(p => p.Marca == marcaid);
            var coleccion = Mapper.Map<List<DTO.ProductoDTO>>(productos);

            return coleccion;
        }
    }
}
