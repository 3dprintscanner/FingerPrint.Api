namespace FingerPrint.Api.Controllers
{
    public class TaxRegistrationRequest
    {
        public string UserId { get; set; }
        public long Earnings { get; set; }
        public string TaxBracket { get; set; }
    }
}