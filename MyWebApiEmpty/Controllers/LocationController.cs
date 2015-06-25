using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using MyWebApiData;

namespace MyWebApiEmpty.Controllers
{
    public class LocationController : ApiController
    {
        List<Location> Locations = new Location().InitLocations();

        public IEnumerable<Location> GetAllLocations()
        {
            return Locations;
        }

        public IHttpActionResult GetLocation(int id)
        {
            var Location = Locations.FirstOrDefault((l) => l.Id == id);
            if (Location == null)
                return NotFound();
            return Ok(Location);
        }
    }
}
