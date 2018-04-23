using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);
        [OperationContract]
        void Additems(string productname, string productcategory, string productcompany, string productprice);

        [OperationContract]
        void Addcustomer(string name, string password, string phone, string address);
        [OperationContract]
        void Addadmin(string name, string password, string phone, string address);
        [OperationContract]
        void Addmakeupartist(string name, string password, string phone, string address);
        [OperationContract]
        bool isvalidcust(string username, string password);
        [OperationContract]
        bool isvalidadmin(string username, string password);
        [OperationContract]
        bool isvalidmake(string username, string password);
        [OperationContract]
        List<Product> copyproducts();
        [OperationContract]
        int calculatediscount(int dis);

        [OperationContract]
        
        CompositeType GetDataUsingDataContract(CompositeType composite);
        [OperationContract]
        List<Product> get_products();
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
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
