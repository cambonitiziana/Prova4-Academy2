using OM.EntityRepo.Entity;
using OM.EntityRepo.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace OM.EntityRepo.BusinessLayer
{
    public class OrderManagementBL : IOrderManagementBL
    {
        private readonly IClientRepository clientRepository;
        private readonly IOrderRepository orderRepository;

        public OrderManagementBL(IOrderRepository orderRepo,  IClientRepository clientRepo)                          
        {
            this.clientRepository = clientRepo;
            this.orderRepository = orderRepo;
            
        }



        public bool CreateClient(Client item)
        {
           return clientRepository.Create(item);
        }

        public bool CreateOrder(Order item)
        {
            return orderRepository.Create(item);
        }


        public bool DeleteClient(Client item)
        {
            return clientRepository.Delete(item);
        }

        public bool DeleteOrder(Order item)
        {
           return orderRepository.Delete(item);
        }

        public IEnumerable<Client> GetAllClients()
        {
            return clientRepository.GetAll();
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return orderRepository.GetAll();
        }

        public Client GetClientByID(int id)
        {
           return clientRepository.GetById(id);
        }

        

        public Order GetOrderByID(int id)
        {
            return orderRepository.GetById(id);
        }

        public bool UpdateClient(Client item)
        {
            return clientRepository.Update(item);
        }

        public bool UpdateOrder(Order item)
        {
            return orderRepository.Update(item);
        }
    }
}
