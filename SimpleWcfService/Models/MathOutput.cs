using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWcfService.Models
{
    [DataContract]
    public class MathOutput
    {
        [DataMember]
        public int Result { get; set; }
    }
}
