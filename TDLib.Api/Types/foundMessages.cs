using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class FoundMessages : Structure
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "foundMessages";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("messages")]
        public Message[] Messages { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("next_from_search_id")]
        public string NextFromSearchId { get; set; }

    }

}