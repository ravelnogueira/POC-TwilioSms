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
            string authToken = "9d8444b8073fb9ac8de7147073fddd97";

            TwilioClient.Init(accountSid, authToken);

            var verification = VerificationResource.Create(
                to: number,
                channel: "sms",
                pathServiceSid: "VAeff2402e33809f06a193c4fb03cd3b6f"
        );

        }
    }
}
