using Newtonsoft.Json;
using RambollProject.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Script.Serialization;

namespace RambollProject.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class GuidesController : ApiController
    {
        private static readonly string testImgUrl = "https://i.vimeocdn.com/portrait/58832_300x300"; 
        private static readonly List<GuideDTO> guides = new List<GuideDTO>{
            new GuideDTO(0, "Touch Screen", 
                "The touch screen is a 7 m. long interactive screen, where you can have collaborative and creative meetings e.g. view models, use digital post-it notes, pencil sketches, templates etc.",
                testImgUrl),
            new GuideDTO(1, "Span Wall Software",
                "Span Wall software can be used on the touch screen in Virtual Solutions Lab or on your PC/tablet. It gives you access to a digital workshop kit consisting of digital post-it notes, flip charts etc.",
                testImgUrl),
            new GuideDTO(2, "Cardboards & VR",
                "Cardboards and VR glasses are used together with a smartphone. They make it possible to view 3D models, images, videos etc.",
                testImgUrl)

        };
        
        [HttpGet]
        public IHttpActionResult GetAllGuides()
        {
            return Json(guides);
        }

        [HttpGet]
        public IHttpActionResult GetGuide(int id) {
            return Json(guides[id]);
        }

        public HttpResponseMessage Post()
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent("POST: Test message")
            };
        }

        public HttpResponseMessage Put()
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent("PUT: Test message")
            };
        }
    }
}