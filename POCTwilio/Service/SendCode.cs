using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Rest.Verify.V2.Service;
using Twilio;
using POCTwilio.Models;

namespace SMS_Twilio.Service
{
    public class Send
    {
        public static void Execute(string number)
        {
            string accountSid = Auth.accountSid;
            string authToken = Auth.authToken;

            TwilioClient.Init(accountSid, authToken);

            var verification = VerificationResource.Create(
                to: number,
                channel: "sms",
                pathServiceSid: Auth.pathServiceSid
        );

        }
    }
}
