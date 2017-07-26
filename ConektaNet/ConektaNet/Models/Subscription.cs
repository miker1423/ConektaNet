using System;
using Newtonsoft.Json;

namespace ConektaNet.Models
{
    public class Subscription
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("canceled_at")]
        public string CanceledAt { get; set; }

        [JsonProperty("paused_at")]
        public string PausedAt { get; set; }

        [JsonProperty("billing_cycle_start")]
        public TimeSpan BillingCycleStart { get; set; }

        [JsonProperty("billing_cycle_end")]
        public TimeSpan BillingCycleEnd { get; set; }

        [JsonProperty("trial_start")]
        public TimeSpan TrialStart { get; set; }

        [JsonProperty("trial_end")]
        public TimeSpan TrialEnd { get; set; }

        [JsonProperty("plan_id")]
        public string PlanID { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
