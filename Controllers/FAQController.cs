using RambollProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Threading.Tasks;
using RambollProject.EFRepos;

namespace RambollProject.Controllers
{
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public class FAQController : ApiController
        {
            static EFFAQRepository _repo = new EFFAQRepository();

            [HttpGet]
            public async Task<IHttpActionResult> GetAllFAQs()
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);
                var faqs = await _repo.getAllFAQs();
                if (faqs == null) return NotFound();
                return Json(faqs);
            }

            [HttpGet]
            public async Task<IHttpActionResult> GetFAQ(int id)
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);
                var faq = await _repo.getFAQ(id);
                if (faq == null) return NotFound();
                return Json(faq);
            }

            [HttpPost]
            public async Task<IHttpActionResult> PostFAQ([FromBody]FAQDTO faq)
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);
                var success = await _repo.postFAQ(faq);
                if (!success) return BadRequest(ModelState);
                // On succesful post, return posted item.
                return Json(faq);
            }

            [HttpDelete]
            public async Task<IHttpActionResult> DeleteFAQ(int id)
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);
                var success = await _repo.deleteFAQ(id);
                if (!success) return BadRequest(ModelState);
                // On succesful delete, return deleted id.
                return Ok(id);
            }
    }
    
}