using Microsoft.AspNetCore.Mvc;
using System;

namespace FingerPrint.Api.Controllers
{
    public class BenefitsController : Controller
    {
        [HttpPost("benefits")]
        public IActionResult Post([FromBody] TaxRegistrationRequest request)
        {
            return Ok();
        }
    }

    public class BenefitsRequest
    {
        public string UserId { get; set; }
        public string Fingerprint { get; set; }
        public string BenefitRequested { get; set; }
        public DateTime RequestDate { get; set; }
    }

}