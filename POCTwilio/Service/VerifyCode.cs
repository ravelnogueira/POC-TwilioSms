using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Rest.Verify.V2.Service;
using Twilio;
using System.Linq.Expressions;

namespace SMS_Twilio.Service
{
    public class Validity
    {
        public static string ValidarSms(string code, string Number)
        {

            string accountSid = "AC0de5bade55a7b53999fe2b341cd06861";
            string authToken = "edea67f5e756b4c7b80af765ad8359de";

            TwilioClient.Init(accountSid, authToken);

            var verificationCheck = VerificationCheckResource.Create(
                to: Number,
                code: code,
                pathServiceSid: "VAe82fd5f22de70bfe86aa8732b009eb3a"
            );

            switch (verificationCheck.Status)
            {
                case "approved":
                    return ("O Codigo esta correto");
                
                case "canceled":
                    return ("O Código está cancelado");
                    
                case "pending":
                    return "O código não foi verificado";
           
                default:
                    return "Null";
            }

        }

    }
}