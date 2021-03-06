using System.Collections.Generic;
using EliteAPI.Event.Models.Abstractions;
using Newtonsoft.Json;

namespace EliteAPI.Event.Models.Startup
{
    /// <summary>
    /// This event is written when the game has started.
    /// </summary>
    public class MaterialsEvent : EventBase
    {
        internal MaterialsEvent() { }

        public static MaterialsEvent FromJson(string json) => JsonConvert.DeserializeObject<MaterialsEvent>(json);



        /// <summary>
        /// A list of raw materials, grouped by name.
        /// </summary>
        /// <see cref="MaterialsMaterial"/>
        [JsonProperty("Raw")]
        public IReadOnlyList<MaterialsMaterial> Raw { get; internal set; }

        /// <summary>
        /// A list of manufactured materials, grouped by name.
        /// </summary>
        /// <see cref="MaterialsMaterial"/>
        [JsonProperty("Manufactured")]
        public IReadOnlyList<MaterialsMaterial> Manufactured { get; internal set; }

        /// <summary>
        /// A list of encoded materials, grouped by name.
        /// </summary>
        /// <see cref="MaterialsMaterial"/>
        [JsonProperty("Encoded")]
        public IReadOnlyList<MaterialsMaterial> Encoded { get; internal set; }

        
    }
}