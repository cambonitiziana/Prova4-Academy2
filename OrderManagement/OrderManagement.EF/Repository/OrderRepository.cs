using OM.EntityRepo.Entity;
using OM.EntityRepo.Repository;
using OrderManagement.EF.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.EF.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OMContext ctx;

        public OrderRepository() : this(new OMContext()) { }

        public OrderRepository(OMContext ctx)
        {
            this.ctx = ctx;
        }


        //CRUD
        public bool Create(Order item)
        {
            if (item == null)
            {
                return false;
            }

            ctx.Orders.Add(item);
            ctx.SaveChanges();
            return true;
        }

        public bool Delete(Order item)
        {
            try
            {
                var loan = ctx.Orders.Find(item.Id);
                if (item != null)
                {
                    ctx.Orders.Remove(item);
                }
                ctx.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;

            }
        }

        public Order GetById(int id)
        {
            try
            {
                return ctx.Orders.Find(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool Update(Order item)
        {
            try
            {
                ctx.Orders.Update(item);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public IEnumerable<Order> GetAll()
        {
            return ctx.Orders;
        }

    }
}
