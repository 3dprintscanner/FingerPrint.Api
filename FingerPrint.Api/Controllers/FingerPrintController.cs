using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fingerprint.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SourceAFIS.Extraction.Minutiae;
using SourceAFIS.Simple;

namespace FingerPrint.Api.Controllers
{
    public class FingerPrintController : Controller
    {

        [HttpPost("fingerprint")]
        public ActionResult<string> Post(IFormFile file)
        {
            var impl = new FingerPrintImpl();

            var content = file.OpenReadStream();

            var signature  = impl.DoFingerPrint(content);

            return signature;
        }
    }
}