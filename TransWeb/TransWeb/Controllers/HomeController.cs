using System;
using System.Net.Mail;
using System.Web.Mvc;

namespace TransWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Hello";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string name, string email, string message)
        {
            try
            {
                using (var mail = new MailMessage())
                {
                    mail.From = new MailAddress(email);
                    mail.To.Add(new MailAddress("info@transcendentpro.com"));
                    mail.Bcc.Add(new MailAddress("atulsirpal@gmail.com"));
                    mail.Subject = "Enquiry";
                    mail.Body = message;
                    mail.IsBodyHtml = true;

                    try
                    {
                        SmtpClient client = new SmtpClient();
                        client.Send(mail);
                    }
                    finally
                    {
                        //dispose the client
                        mail.Dispose();
                    }
                }
            }
            catch (SmtpFailedRecipientsException ex)
            {
                foreach (SmtpFailedRecipientException t in ex.InnerExceptions)
                {
                    var status = t.StatusCode;
                    if (status == SmtpStatusCode.MailboxBusy ||
                        status == SmtpStatusCode.MailboxUnavailable)
                    {
                        Response.Write("Delivery failed - retrying in 5 seconds.");
                        System.Threading.Thread.Sleep(5000);
                        //resend
                        //SmtpClient client = new SmtpClient();
                        //client.Send(mail);
                    }
                    else
                    {
                    }
                }
            }
            catch (SmtpException Se)
            {
                // handle exception here
                //  Response.Write(Se.ToString());
                ViewBag.Message = Se.ToString();
            }
            catch (Exception ex)
            {
                // Response.Write(ex.ToString());
            }

            ViewBag.Message = "Thank you! We will contact you soon.";

            return View();
        }
    }
}