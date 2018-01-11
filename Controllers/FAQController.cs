using RambollProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RambollProject.Controllers
{
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public class FAQController : ApiController
        {
            private static readonly List<FAQDTO> faqs = new List<FAQDTO>{
            new FAQDTO(0, "How long is a canvas?",
                "A canvas is 27 meters long."),
            new FAQDTO(1, "Why do the computers use Wondows 10?",
                "The touch screen can register more touches with Windows 10."),
            new FAQDTO(2, "Why can I not access the Span Wall software from my computer?",
                "The Span Wall software only functions on your PC, if you use your PC's Chrome or Safari browser​.")

        };

            [HttpGet]
            public IHttpActionResult GetAllFAQs()
            {
                return Json(faqs);
            }

            [HttpGet]
            public IHttpActionResult getFAQ(int id)
            {
                return Json(faqs[id]);
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