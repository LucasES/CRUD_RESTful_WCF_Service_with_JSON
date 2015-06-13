using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CRUD_WCF_REST_JSON
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceAlimento" in both code and config file together.
    [ServiceContract]
    public interface IServiceAlimento
    {
        [OperationContract]
        [WebInvoke(Method="GET", UriTemplate="findall", ResponseFormat=WebMessageFormat.Json)]
        List<Alimento> findall();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "find/{id}", ResponseFormat = WebMessageFormat.Json)]
        Alimento find(int id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "create", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool create(Alimento alimento);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool edit(Alimento alimento);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool delete(Alimento alimento);
    }
}
