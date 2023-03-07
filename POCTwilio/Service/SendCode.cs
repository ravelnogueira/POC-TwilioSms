using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Rest.Verify.V2.Service;
using Twilio;
using POCTwilio.Auth;

namespace SMS_Twilio.Service
{
    public class Send
    {
        public static void Execute(string number)
        {
 
            TwilioClient.Init(Auth.AccountSid, Auth.AuthToken);

            var verification = VerificationResource.Create(
                to: number,
                channel: "sms",
                pathServiceSid: Auth.pathServiceSid
        );

        }
    }
}
