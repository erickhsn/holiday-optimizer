using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Holiday_Optimizer.APP.Models
{
    [DataContract]
    public class CountryReponse
    {
        [DataMember(Name = "commonName")]
        public string CommonName { get; set; }

        [DataMember(Name = "officialName")]
        public string OfficialName { get; set; }

        [DataMember(Name = "countryCode")]
        public string CountryCode { get; set; }

        [DataMember(Name = "region")]
        public string Region { get; set; }
    }
}
