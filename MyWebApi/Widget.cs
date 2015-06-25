using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApiData
{
    public class Widget
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public Double Price { get; set; }
        public Boolean IsDiscounted { get; set; }

        public Widget() { }

        public List<Widget> InitWidgets()
        {
            var ReturnData = new List<Widget>();
            ReturnData.Add(new Widget() { Id = 1, Name = "Whatchamacallit", Price = 3.12, IsDiscounted = false });
            ReturnData.Add(new Widget() { Id = 2, Name = "Thingamajig", Price = 2.75, IsDiscounted = true });
            ReturnData.Add(new Widget() { Id = 3, Name = "Whoseits", Price = 4.50, IsDiscounted = false });
            return ReturnData;
        }
    }
}