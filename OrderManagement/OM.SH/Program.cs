using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OM.SH
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(OM.WcfService.OMService)))
            {
                host.Open();
                Console.WriteLine("Host riuscito");
                Console.ReadLine();

            }
        }
    }
}
