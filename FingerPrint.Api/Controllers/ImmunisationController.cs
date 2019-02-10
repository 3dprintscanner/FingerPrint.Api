using Microsoft.AspNetCore.Mvc;
using System;

namespace FingerPrint.Api.Controllers
{
    public class ImmunisationController : Controller
    {
        [HttpPost("immunisation")]
        public IActionResult Post([FromBody] ImmunisationRequest request)
        {
            return Ok();
        }
    }


    public class ImmunisationRequest
    {
        public string UserId { get; set; }
        public string ImmunisationType { get; set; }
        public DateTime ImminisationDate { get; set; }
        public DateTime ImmunityRenewalDate { get; set; }
        public string Administerer { get; set; }
        public string Fingerprint { get; set; }

    }
}