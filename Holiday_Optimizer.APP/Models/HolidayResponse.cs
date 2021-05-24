using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Holiday_Optimizer.APP.Models
{
    [DataContract]
    public class HolidayResponse
    {
        [DataMember(Name = "date")]
        public DateTime Date { get; set; }

        [DataMember(Name = "localName")]
        public string LocalName { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "countryCode")]
        public string CountryCode { get; set; }

        [DataMember(Name = "fixed")]
        public bool Fixed { get; set; }

        [DataMember(Name = "global")]
        public bool Global { get; set; }

        [DataMember(Name = "counties")]
        public List<string> Counties { get; set; }

        [DataMember(Name = "launchYear")]
        public int? LaunchYear { get; set; }

        [DataMember(Name = "types")]
        public List<string> Types { get; set; }
    }
}
