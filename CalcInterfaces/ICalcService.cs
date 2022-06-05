using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalcInterfaces
{
    [ServiceContract]
    public interface ICalcService
    {
        [OperationContract]
        string DecimalToBinary(uint decimalNumber);
    }
}
