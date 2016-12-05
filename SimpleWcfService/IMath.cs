using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SimpleWcfService.Models;

namespace SimpleWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMath" in both code and config file together.
    [ServiceContract]
    public interface IMath
    {
        [OperationContract]
        MathOutput Add(MathInput input);

        [OperationContract]
        MathOutput Div(MathInput input);

        [OperationContract]
        MathOutput Mul(MathInput input);

        [OperationContract]
        MathOutput Sub(MathInput input);
    }
}
