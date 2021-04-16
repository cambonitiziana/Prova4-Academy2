using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace OM.EntityRepo.Entity
{
    [DataContract]
    public class Order : IEntity
    {
        public int Id { get; set ; }
        [DataMember]
        public DateTime OrderDate { get; set; } = DateTime.Now;

        [DataMember]
        public string  OrderCode { get; set; }

        [DataMember]
        public string ProductCode { get; set; }

        [DataMember]
        public decimal Amount { get; set; }


        public Client Client { get; set; }


    }
}
