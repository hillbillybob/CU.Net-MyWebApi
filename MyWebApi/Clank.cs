using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApiData
{
    public class Clank
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public Boolean IsAvailable { get; set; }
        public Widget Widget { get; set; }

        public Clank() { }

        public List<Clank> InitClanks()
        {
            var Widgets = new Widget().InitWidgets();
            var ReturnData = new List<Clank>();
            ReturnData.Add(new Clank() { Id = 1, Name = "Flubbish", IsAvailable = true, Widget = Widgets[0] });
            ReturnData.Add(new Clank() { Id = 2, Name = "Rubbish", IsAvailable = false, Widget = Widgets[1] });
            ReturnData.Add(new Clank() { Id = 3, Name = "Grubbish", IsAvailable = true, Widget = Widgets[2] });
            return ReturnData;
        }
    }
}