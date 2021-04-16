using OM.EntityRepo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OM.EntityRepo.BusinessLayer
{
    public interface IOrderManagementBL
    {   
        //Client
        bool CreateClient(Client item);
        bool DeleteClient(Client item);
        bool UpdateClient(Client item);
        Client GetClientByID(int id);
        IEnumerable<Client> GetAllClients();

        //Order
        bool CreateOrder(Order item);
        bool DeleteOrder(Order item);
        bool UpdateOrder(Order item);
        Order GetOrderByID(int id);
        IEnumerable<Order> GetAllOrders();


    }
}
