using System;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace SpiderTrapWebApplication.Controllers
{
    public class SpiderController : Controller
    {
        [Route("Spider/{id}")]
        [Route("Spider")]
        public IActionResult Index(string id = "test")
        {
            var newId = Guid.NewGuid().ToString();
            var html = new StringBuilder();
            html.Append("<html><head></head><body>");
            html.Append($"<a href='/spider/{newId}'>{newId}</a>");
            html.Append("</body></html>");
            return Content(html.ToString(), "text/html");
        }
    }
}
