using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Rest.Verify.V2.Service;
using Twilio;

namespace SMS_Twilio.Service
{
    public class Validity
    {
        public static string ValidarSms(string code, string Number)
        {
            string accountSid = "AC0de5bade55a7b53999fe2b341cd06861";
            string authToken = "83e519b80e44ee534a3c382fd4c66fc0";

            TwilioClient.Init(accountSid, authToken);

            var verificationCheck = VerificationCheckResource.Create(
                to: Number,
                code: code,
                pathServiceSid: "VAd4a16d1c16453fed5a97a700039de210"
            );


            if (verificationCheck.Status != null)
            {
                if (verificationCheck.Status == "approved")
                {
                    return ("O Codigo esta correto");
                }

                if (verificationCheck.Status == "canceled")
                {
                    return ("O Código está cancelado");
                }

                if (verificationCheck.Status == "pending")
                {
                    return "O código não foi verificado";
                }

                else
                {
                    return ("Falha");
                }
            }
            else
            {
                return "Null";
            }

        }

    }
}