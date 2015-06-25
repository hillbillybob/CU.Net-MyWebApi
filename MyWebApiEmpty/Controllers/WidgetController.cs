using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using MyWebApiData;
using System.Text;

namespace MyWebApiEmpty.Controllers
{
    public class WidgetController : ApiController
    {
        List<Widget> Widgets = new Widget().InitWidgets();

        public IEnumerable<Widget> GetAllWidgets()
        {
            return Widgets;
        }

        public IHttpActionResult GetWidget(int id)
        {
            var Widget = Widgets.FirstOrDefault((w) => w.Id == id);
            if (Widget == null)
            {
                return NotFound();
            }
            return Ok(Widget);
        }

        [HttpPost]
        public void Post() { }

        [HttpGet]
        public HttpResponseMessage CustomHeader()
        {
            //Return a 200
            HttpResponseMessage responseMessage = Request.CreateResponse(HttpStatusCode.OK, "value");
            //Set some content
            responseMessage.Content = new StringContent("Hello World", Encoding.Unicode);
            //Add the custom header
            responseMessage.Headers.Add("Custom", "BobsYourUncle");
            //Return the custom response
            return responseMessage;
        }
    }
}
