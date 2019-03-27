using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MVC_EF_Start.Models
{
    public class App_Models
    {
        public class Price
        {
            [Key]
            public int PriceId { get; set; }
            public string date { get; set; }
            public float open { get; set; }
            public float high { get; set; }
            public string low { get; set; }
            public float close { get; set; }
            public int volume { get; set; }
            public int unadjustedVolume { get; set; }
            public float change { get; set; }
            public float changePercent { get; set; }
            public float vwap { get; set; }
            public string label { get; set; }
            public float changeOverTime { get; set; }
        }




    }
}
