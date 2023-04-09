using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Rest.Verify.V2.Service;
using Twilio;
using System.Linq.Expressions;
using POCTwilio.Models;

namespace SMS_Twilio.Service
{
    public class Validity
    {
        public static string ValidarSms(string code, string Number)
        {

            string accountSid = Auth.accountSid;
            string authToken = Auth.authToken;

            TwilioClient.Init(accountSid, authToken);

            var verificationCheck = VerificationCheckResource.Create(
                to: Number,
                code: code,
                pathServiceSid: Auth.pathServiceSid
            );


            var status = verificationCheck.Status switch
            {
                "approved" => "O Codigo esta correto",
                "canceled" => "O Código está cancelado",
                "pending" => "O código não foi verificado",
                "Null" => "Null"
            };

            return status;



    }

    }
}