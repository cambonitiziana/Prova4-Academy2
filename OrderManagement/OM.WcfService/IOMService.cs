using OM.EntityRepo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OM.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IOMService
    {
        //WCF-> da testo CRUD del solo cliente
        [OperationContract]
        bool CreateClient(Client item);

        [OperationContract]
        bool DeleteClient(Client item);

        [OperationContract]
        bool UpdateClient(Client item);

        [OperationContract]
        Client GetClientByID(int id);


    }

   
   
}
