using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OM.EntityRepo.BusinessLayer;
using OM.EntityRepo.Entity;
using OM.EntityRepo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OM.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderManagementBL OM;
        private readonly IOrderRepository OR;


        //public OrderController(IOrderManagementBL OM)
        //{
        //    this.OM = OM;
        //}



        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetOrder()
        {
            return Ok(OR.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult GetOrderById(int id)
        {
            return Ok(OR.GetById(id));
        }

        [HttpPost]
        public ActionResult CreateOrder([FromBody] Order order)
        {
            if (order == null)
            {
                return BadRequest();
            }
            var result= OR.Create(order);

            if (result)
            {
                return Ok();
            }
            else
            { return BadRequest(); }
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int id)
        {
            var order = OR.GetAll().FirstOrDefault(x => x.Id == id);
            if (order == null)
            {
                return NotFound();

            }
            var result = OR.Delete(order);
            if (!result)
            {
                return BadRequest();
            }
            return NoContent();
        }
    }
}
