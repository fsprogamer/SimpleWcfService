using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SimpleWcfService.Models;

namespace SimpleWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Math" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Math.svc or Math.svc.cs at the Solution Explorer and start debugging.
    public class Math : IMath
    {
        public MathOutput Add(MathInput input)
        {
            return new MathOutput
            {
                Result = input.FirstNumber + input.SecondNumber
            };
        }

        public MathOutput Div(MathInput input)
        {
            return new MathOutput
            {
                Result = input.FirstNumber - input.SecondNumber
            };
        }        

        public MathOutput Mul(MathInput input)
        {
            return new MathOutput
            {
                Result = input.FirstNumber * input.SecondNumber
            };
        }

        public MathOutput Sub(MathInput input)
        {
            return new MathOutput
            {
                Result = input.FirstNumber / input.SecondNumber
            };
        }
    }
}
