using OM.EntityRepo.BusinessLayer;
using OM.EntityRepo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OM.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class OMService : IOMService
    {
        private readonly IOrderManagementBL OM;

        
       
        public bool CreateClient(Client item)
        {
            return OM.CreateClient(item);
        }

        public bool DeleteClient(Client item)
        {
            return OM.DeleteClient(item);
        }

        public Client GetClientByID(int id)
        {
            return OM.GetClientByID(id);
        }

        public bool UpdateClient(Client item)
        {
           return OM.UpdateClient(item);
        }
    }
}
