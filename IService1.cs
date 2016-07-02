using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService1.DTO;

namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<DTO.ProductoDTO> ProductosDisponibles();

        [OperationContract]
        List<DTO.CategoriaDTO> Categoriagetall();

        [OperationContract]
        List<DTO.ProductoDTO> ProductosporCategoria(string categoryid);

        [OperationContract]
        List<DTO.ProductoDTO> ProductosporMarca(string marcaid);

        [OperationContract]
        List<DTO.ProductoDTO> Productogetall();

        [OperationContract]
        List<DTO.MarketingDTO> Marketinggetall();

        [OperationContract]
        DTO.ProductoDTO getProductobyID(string productoid);

        [OperationContract]
        List<DTO.ProductoDTO> getProductosFavoritos();

        [OperationContract]
        List<DTO.CategoriaDTO> getCategoriesTipo(string dato);

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
