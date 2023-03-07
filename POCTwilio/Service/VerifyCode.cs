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


            TwilioClient.Init(Auth.AccountSid, Auth.AuthToken);

            var verificationCheck = VerificationCheckResource.Create(
                to: Number,
                code: code,
                pathServiceSid: Auth.pathServiceSid
            );


            var status = verificationCheck.Status switch
            {
                "approved" => "correct code",
                "canceled" => "canceled code",
                "pending" => "incorrect code",
                "Null" => "Null",
                _ => "Error"

            };

            return status;



    }

    }
}