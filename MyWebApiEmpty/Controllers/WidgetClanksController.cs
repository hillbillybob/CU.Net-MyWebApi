using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using MyWebApiData;

namespace MyWebApiEmpty.Controllers
{
    public class WidgetClanksController : ApiController
    {
        List<Clank> Clanks = new Clank().InitClanks();

        public IHttpActionResult GetClankByWidgetId(int id)
        {
            var Clank = Clanks.FirstOrDefault((c) => c.Widget.Id == id);
            if (Clank == null)
                return NotFound();
            return Ok(Clank);
        }
    }
}