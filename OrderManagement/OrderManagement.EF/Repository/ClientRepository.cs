using OM.EntityRepo.Entity;
using OM.EntityRepo.Repository;
using OrderManagement.EF.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.EF.Repository
{
   public  class ClientRepository : IClientRepository
    {
        private readonly OMContext ctx;

        public ClientRepository() : this(new OMContext()) { }

        public ClientRepository(OMContext ctx)
        {
            this.ctx = ctx;
        }


        //CRUD
        public bool Create(Client item)
        {
            if (item == null)
            {
                return false;
            }

            ctx.Clients.Add(item);
            ctx.SaveChanges();
            return true;
        }

        public bool Delete(Client item)
        {
            try
            {
                var loan = ctx.Clients.Find(item.Id);
                if (item != null)
                {
                    ctx.Clients.Remove(item);
                }
                ctx.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;

            }
        }

        public Client GetById(int id)
        {
            try
            {
                return ctx.Clients.Find(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool Update(Client item)
        {
            try
            {
                ctx.Clients.Update(item);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

       public  IEnumerable<Client> GetAll()
        {
            return ctx.Clients;
        }

     
    }
}
