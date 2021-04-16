using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace OM.EntityRepo.Entity
{
    [DataContract]
    public class Client: IEntity
    {
        public int Id { get; set; }

        [DataMember]
        public string ClientCode { get; set; }

        [DataMember]
        public string Firstname { get; set; }

        [DataMember]
        public string Lastname { get; set; }


        public ICollection<Order> Orders{ get; set; }
       }
}
