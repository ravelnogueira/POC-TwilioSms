using Microsoft.AspNetCore.Mvc;
using POCTwilio.Models;
using SMS_Twilio.Service;

namespace POCTwilio.Controllers
{
    [ApiController]
    [Route("Sms")]

    public class SmsController : ControllerBase
    {
        [HttpGet]
        public void SendCode(string Number)
        {
            Send.Execute(Number);

        }

        [HttpPost]
        public string ValidaCode(string Code, string Number) 
        {
            return Validity.ValidarSms(Code, Number);
        }
               
    }
}