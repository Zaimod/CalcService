using CalcInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalcServer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class CalcService : ICalcService
    {
        public string DecimalToBinary(uint decimalNumber)
        {
            var binaryNumber = string.Empty;
            while (decimalNumber > 0)
            {
                binaryNumber = (decimalNumber % 2) + binaryNumber;
                decimalNumber /= 2;
            }

            return binaryNumber;
        }
    }
}
