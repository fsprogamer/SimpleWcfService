using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWcfService.Models
{
    [DataContract]
    public class MathInput
    {
        [DataMember]
        public int FirstNumber { get; set; }
        [DataMember]
        public int SecondNumber { get; set; }
    }
}
