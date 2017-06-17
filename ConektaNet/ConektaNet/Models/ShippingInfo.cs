using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConektaNet.Models
{
    public class ShippingInfo
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("receiver")]
        public string Receiver { get; set; }

        [JsonProperty("between_streets")]
        public string BetweenStreets { get; set; }

        [JsonProperty("address")]
        public Dictionary<string, string> Address { get; set; }
    }
}
