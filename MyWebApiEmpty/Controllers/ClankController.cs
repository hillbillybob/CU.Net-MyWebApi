using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using MyWebApiData;

namespace MyWebApiEmpty.Controllers
{
    public class ClankController : ApiController
    {
        List<Clank> Clanks = new Clank().InitClanks();

        public IEnumerable<Clank> GetAllClanks()
        {
            return Clanks;
        }

        public IHttpActionResult GetClank(int id)
        {
            var Clank = Clanks.FirstOrDefault((c) => c.Id == id);
            if (Clank == null)
                return NotFound();
            return Ok(Clank);
        }
    }
}
