using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodApi.Models
{
    public class Tweet
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("stamp")]
        public DateTime Stamp { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}