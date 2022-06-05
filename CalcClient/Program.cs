using CalcInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalcClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<ICalcService> channel = 
                new ChannelFactory<ICalcService>("CalcServiceEndpoint");

            ICalcService proxy = channel.CreateChannel();

            while (true)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.Write("Введіть число в десятковій системі: ");

                var decNum = uint.Parse(Console.ReadLine());
                var binNum = proxy.DecimalToBinary(decNum);

                Console.WriteLine("{0} => {1}", decNum, binNum);
            }
        }
    }
}
