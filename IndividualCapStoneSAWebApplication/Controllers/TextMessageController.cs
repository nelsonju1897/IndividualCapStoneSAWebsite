using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio.AspNet.Common;
using Twilio.AspNet.Mvc;
using Twilio.TwiML;
using System.Configuration;
using Twilio.Rest.Api.V2010.Account;
using Microsoft.AspNet.Identity;
using IndividualCapStoneSAWebApplication.Models;

namespace IndividualCapStoneSAWebApplication.Controllers
{
    public class TextMessageController : TwilioController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: TextMessage
        public ActionResult SendSms()
        {
            var userId = User.Identity.GetUserId();
            Survivor survivor = db.Survivor.FirstOrDefault(s => s.ApplicationId == userId);

            var accountSid = "AC9e820c12c7a044f14cbb16c10f4222f2";
            var authToken = "0af6a3d4bad4f3e2a3a80de3094a2bc0";
            Twilio.TwilioClient.Init(accountSid, authToken);

            var to = new Twilio.Types.PhoneNumber(survivor.EmergencyContactNumber);
            var from = new Twilio.Types.PhoneNumber("+12015089005");

            var message = MessageResource.Create(
                to: to,
                from: from,
                body: survivor.FirstName + " has recently experienced a sexual assault. They are letting you know through an application that they need your support. Please contact this person as soon as possible." + survivor.FirstName + " needs you to be emotionally supportive and not ask questions." + survivor.FirstName + " will open up when they are ready."
                );
            return RedirectToAction("Index","Survivor");
        }
    }
}