using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class CreatePrivateChat : Function<Chat>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "createPrivateChat";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public int UserId { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("force")]
            public bool Force { get; set; }
        }
    }
}