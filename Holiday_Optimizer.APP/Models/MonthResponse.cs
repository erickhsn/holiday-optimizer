using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Holiday_Optimizer.APP.Models
{
    [DataContract]
    public class MonthResponse
    {
        [DataMember(Name = "month")]
        public string Month { get; set; }
    }
}
