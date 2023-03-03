using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Rest.Verify.V2.Service;
using Twilio;

namespace SMS_Twilio.Service
{
    public class Send
    {
        public static void Execute(string number)
        {
            string accountSid = "AC0de5bade55a7b53999fe2b341cd06861";
            string authToken = "edea67f5e756b4c7b80af765ad8359de";

            TwilioClient.Init(accountSid, authToken);

            var verification = VerificationResource.Create(
                to: number,
                channel: "sms",
                pathServiceSid: "VAe82fd5f22de70bfe86aa8732b009eb3a"
        );

        }
    }
}
