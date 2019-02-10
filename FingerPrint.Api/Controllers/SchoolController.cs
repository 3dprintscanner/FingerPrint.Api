using Microsoft.AspNetCore.Mvc;
using System;

namespace FingerPrint.Api.Controllers
{
    public class SchoolController : Controller
    {
        [HttpPost("school")]
        public IActionResult Post([FromBody] EnrolmentRequest request)
        {
            return Ok();
        }


        public class EnrolmentRequest
        {
            public string UserId { get; set; }
            public string SchoolName { get; set; }
            public string Year { get; set; }
            public string TeacherName { get; set; }
            public string SchoolAddress { get; set; }
            public DateTime EnrolmentDate { get; set; }
        }
    }

    public class MarriageController : Controller
    {
        [HttpPost("marriage")]
        public IActionResult Post([FromBody] MarriageRequest request)
        {
            return Ok();
        }
    }

    public class MarriageRequest
    {
        public string UserId { get; set; }
        public string Fingerprint { get; set; }

        public string SpouseUserId { get; set; }

        public string SpouseFingerprint { get; set; }

        public DateTime MarriageDate { get; set; }

        public string MarriageWitness { get; set; }
        public string MarriageLocation { get; set; }
    }

    public class BirthOfChildController : Controller
    {
        [HttpPost("birthofchild")]
        public IActionResult Post([FromBody] BirthOfChildRequest request)
        {
            return Ok();
        }
    }

    public class BirthOfChildRequest
    {
        public string UserId { get; set; }

        public string Fingerprint { get; set; }

        public string ChildID { get; set; }

        public string BirthPlace { get; set; }

        public DateTime BirthDate { get; set; }
    }

}