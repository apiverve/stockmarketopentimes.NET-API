using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("timezone")]
    public string timezone { get; set; }

    [JsonProperty("exchange")]
    public string exchange { get; set; }

    [JsonProperty("fullName")]
    public string fullName { get; set; }

    [JsonProperty("isOpen")]
    public bool isOpen { get; set; }

    [JsonProperty("openingTime")]
    public string openingTime { get; set; }

    [JsonProperty("closingTime")]
    public string closingTime { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
