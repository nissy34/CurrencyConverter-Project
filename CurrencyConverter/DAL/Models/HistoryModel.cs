﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyLayerDotNet.Models
{
    public class HistoryModel :BaseModel
    {
        
        [JsonProperty("historical")]
        public bool Historical { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        //[JsonProperty("timestamp")]
        //public int Timestamp { get; set; }

        [JsonProperty("quotes")]
        public Dictionary<string, string> quotes { get; set; } 
    }
}
