using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
//using WcfServiceLibrary;

namespace WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //IService1 serviceProxy = new ChannelFactory<IService1>("ServiceConfiguration").CreateChannel();
            ServiceReference1.IService1 serviceProxy = new ChannelFactory<ServiceReference1.IService1>("BasicHttpBinding_IService1").CreateChannel();
            Console.WriteLine(serviceProxy.GetData(1));

            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
            String s = proxy.GetData(0);
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
