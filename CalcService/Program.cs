using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalcServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CalcService)))
            {
                host.Open();
                Console.WriteLine("Server was started\nPress <Enter> to close!!!");

                Console.ReadLine();
            }
        }
    }
}
