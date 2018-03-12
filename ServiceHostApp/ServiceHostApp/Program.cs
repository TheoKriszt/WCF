using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary;

namespace ServiceHostApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (ServiceHost serviceHost = new ServiceHost(typeof(Service1)))
            {
                try
                {
                    // Open the  ServiceHost  to  start  listening  for  messages .
                    serviceHost.Open();
                    // The  service  can now be  accessed .
                    Console.WriteLine("The service is ready");
                    Console.WriteLine("Press ENTER to terminate the service");
                    Console.ReadLine();
                    //  Close  the  ServiceHost .
                    serviceHost.Close();
                }
                catch (TimeoutException timeProblem)
                {
                    Console.WriteLine(timeProblem.Message);
                    Console.ReadLine();
                }
                catch (CommunicationException commProblem)
                {
                    Console.WriteLine(commProblem.Message);
                    Console.ReadLine();
                }
            }

        }
    }
}
