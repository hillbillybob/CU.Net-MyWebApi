using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApiData
{
    public class Location
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String Region { get; set; }
        public Boolean SellsClanks { get; set; }
        public Boolean SellsWidgets { get; set; }

        public Location() { }

        public List<Location> InitLocations()
        {
            var ReturnData = new List<Location>();
            ReturnData.Add(new Location() { Id = 1, Name = "Boston", Region = "New England", SellsClanks = true, SellsWidgets = true });
            ReturnData.Add(new Location() { Id = 2, Name = "Austin", Region = "Southwest", SellsClanks = false, SellsWidgets = true });
            ReturnData.Add(new Location() { Id = 3, Name = "Redmond", Region = "Pacific Northwest", SellsClanks = false, SellsWidgets = false });
            return ReturnData;
        }
    }
}