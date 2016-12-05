using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                SimpleWcfService.MathClient mathClient = new SimpleWcfService.MathClient();
                var input = new SimpleWcfService.MathInput { FirstNumber = 10, SecondNumber = 2 };
                var output1 = mathClient.Add(input);
                var output2 = mathClient.Div(input);
                var output3 = mathClient.Sub(input);
                var output4 = mathClient.Add(input);
                Console.WriteLine("WCF responded: " + output1.Result);
                Console.WriteLine("WCF responded: " + output2.Result);
                Console.WriteLine("WCF responded: " + output3.Result);
                Console.WriteLine("WCF responded: " + output4.Result);
            }
            catch
            {
                Console.WriteLine("Service is not available");
            }
        }
    }
}
