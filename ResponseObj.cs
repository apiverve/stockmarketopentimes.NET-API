using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("isOpen")]
        public bool IsOpen { get; set; }

        [JsonProperty("openingTime")]
        public string OpeningTime { get; set; }

        [JsonProperty("closingTime")]
        public string ClosingTime { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
