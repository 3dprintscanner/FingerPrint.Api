using Microsoft.AspNetCore.Mvc;
using System;

namespace FingerPrint.Api.Controllers
{
    public class TaxRegistrationController : Controller
    {
        [HttpPost("taxregister")]
        public IActionResult Post([FromBody] TaxRegistrationRequest request)
        {
            return Ok();
        }
    }


    public class ChangeAddressController : Controller
    {
        [HttpPost("changeaddress")]
        public IActionResult Post([FromBody] TaxRegistrationRequest request)
        {
            return Ok();
        }
    }

    public class ChangeAddressRequest
    {
        public string UserId { get; set; }
        public string Fingerprint { get; set; }
        public string NewAddress { get; set; }
        public DateTime ChangeDate { get; set; }
    }



    public class CitizenshipController : Controller
    {
        [HttpPost("citizenship")]
        public IActionResult Post([FromBody] CitizenshipRequest request)
        {
            return Ok();
        }
    }


    public class CitizenshipRequest
    {
        public string UserId { get; set; }
        public string CitizenshipCountry { get; set; }

        public string Fingerprint { get; set; }
    }

    public class DeathController : Controller
    {
        [HttpPost("death")]
        public IActionResult Post([FromBody] DeathRequest request)
        {
            return Ok();
        }
    }

    public class DeathRequest
    {
        public string UserId { get; set; }
        public string FingerPrint { get; set; }
        public string DeathPlace { get; set; }
        public string DeathReason { get; set; }
        public string DeathAge { get; set; }
        public DateTime DeathDate { get; set; }
    }
}