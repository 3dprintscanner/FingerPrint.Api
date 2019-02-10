using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FingerPrint.Api.Controllers
{
    public class BirthController : Controller
    {
        [HttpPost("birth")]
        public IActionResult Post([FromBody] BirthRequest request)
        {
            return Ok();
        }
    }


    public class BirthRequest
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthTown { get; set; }
        public DateTime BirthDate { get; set; }
        public string FatherId { get; set; }
        public string MotherId { get; set; }
        public BloodGroup BloodGroup { get; set; }
        public string FingerprintSignature { get; set; }
    }


    public enum BloodGroup
    {
        APlus,
        ANegative,
        BPlus,
        BNegative,
        OPositive,
        ONegative,
        ABPositive,
        ABNegative,
    }
}