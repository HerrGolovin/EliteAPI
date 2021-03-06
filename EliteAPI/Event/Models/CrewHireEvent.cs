using EliteAPI.Event.Models.Abstractions;
using Newtonsoft.Json;

namespace EliteAPI.Event.Models
{
    public class CrewHireEvent : EventBase
    {
        internal CrewHireEvent() { }

        public static CrewHireEvent FromJson(string json) => JsonConvert.DeserializeObject<CrewHireEvent>(json);


        [JsonProperty("Name")]
        public string Name { get; internal set; }

        [JsonProperty("CrewID")]
        public long CrewId { get; internal set; }

        [JsonProperty("Faction")]
        public string Faction { get; internal set; }

        [JsonProperty("Cost")]
        public long Cost { get; internal set; }

        [JsonProperty("CombatRank")]
        public long CombatRank { get; internal set; }

        
    }
}