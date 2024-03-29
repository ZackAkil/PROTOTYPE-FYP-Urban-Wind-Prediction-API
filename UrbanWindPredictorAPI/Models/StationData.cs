//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UrbanWindPredictorAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StationData
    {
        public int stationDataID { get; set; }
        public int apiKeyID { get; set; }
        public int zoneID { get; set; }
        public System.DateTime dataTimeCollected { get; set; }
        public decimal windSpeed { get; set; }
        public decimal windDirection { get; set; }
    
        public virtual ApiKey ApiKey { get; set; }
        public virtual Zone Zone { get; set; }
    }
}
