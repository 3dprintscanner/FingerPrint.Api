using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fingerprint.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SourceAFIS.Extraction.Minutiae;
using SourceAFIS.Simple;

namespace FingerPrint.Api.Controllers
{
    [ExceptionFilter]
    public class FingerPrintController : Controller
    {

        [HttpPost("fingerprint")]
        public async Task<ActionResult<string>> Post(IFormFile file)
        {
            var impl = new FingerPrintImpl();
            var chain = new BlockchainClient();
            var content = file.OpenReadStream();

            var signature  = impl.DoFingerPrint(content);
            await chain.CreateToken(signature);
            return signature;
        }
    }

    public class ActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {

            Console.WriteLine(context);
        }
    }

    public class ExceptionFilter : ExceptionFilterAttribute
    {
        
        public override void OnException(ExceptionContext context)
        {
            Console.WriteLine(context.Exception);
        }

        public override Task OnExceptionAsync(ExceptionContext context)
        {
            Console.WriteLine(context.Exception);
            return Task.CompletedTask;
        }
        
    }
}