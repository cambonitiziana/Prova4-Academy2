using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientServiceSh.OMServiceClient proxy = new ClientServiceSh.OMServiceClient("BasicHttpBinding_IOMService");

            Console.WriteLine("Client WCF");
            Console.ReadLine();
        }
    }
}
