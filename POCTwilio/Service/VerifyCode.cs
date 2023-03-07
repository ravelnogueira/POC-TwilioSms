using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Rest.Verify.V2.Service;
using Twilio;
using POCTwilio.Auth;
using System.Linq.Expressions;

namespace SMS_Twilio.Service
{
    public class Validity
    {
        public static string ValidarSms(string code, string Number)
        {

            string accountSid = "AC0de5bade55a7b53999fe2b341cd06861";
            string authToken = "9d8444b8073fb9ac8de7147073fddd97";

            TwilioClient.Init(Auth.AccountSid, Auth.uthToken);

            var verificationCheck = VerificationCheckResource.Create(
                to: Number,
                code: code,
                pathServiceSid: "VAeff2402e33809f06a193c4fb03cd3b6f"
            );


            var status = verificationCheck.Status switch
            {
                "approved" => "correct code",
                "canceled" => "canceled code",
                "pending" => "unchecked code",
                "Null" => "Null",
                _ => "Error"

            };

            return status;



    }

    }
}