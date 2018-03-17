using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class SecretChatState : Structure
    {

        public class SecretChatStateClosed : SecretChatState
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "secretChatStateClosed";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}