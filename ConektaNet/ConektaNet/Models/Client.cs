using Newtonsoft.Json;

namespace ConektaNet.Models
{
    public class Client
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("plan_id")]
        public string PlanId { get; set; }

        [JsonProperty("payment_source")]
        public PaymentSource[] PaymentSource { get; set; }

        [JsonProperty("corporate")]
        public bool Corporate { get; set; }

        [JsonProperty("shipping_contacts")]
        public ShippingInfo ShippingContacts { get; set; }

        [JsonProperty("subscriptions")]
        public Subscription Subscriptions { get; set; }
    }
}
