using System;
using Newtonsoft.Json;

namespace ConektaNet.Models
{
    public class PaymentSource
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("obj")]
        public string Obj { get; set; }
        
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("created_at")]
        public TimeSpan CreatedAt { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("exp_month")]
        public string ExpirationMonth { get; set; }

        [JsonProperty("exp_year")]
        public string ExpirationYear { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("parent_id")]
        public string ParentID { get; set; }
    }
}
