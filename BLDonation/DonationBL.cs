using DalDonation;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BLDonation
{
    public class DonationBL : IDonationBL
    {
        IDalDonation IDalDonate;
        public DonationBL(IDalDonation IDalDonate)
        {
            this.IDalDonate = IDalDonate;
        }
        public async Task<List<Donation>> getAllDonation()
        {
            return await IDalDonate.getAllDonate(); 
        }

        public async Task<bool> insertDonation(Donation donationElement)
        {
            try
            {
                var result = IDalDonate.insertDonation(donationElement);
                if (donationElement.CountDonation > 10000)
                {
                    sendMail();
                }
                return await result;
            }
            catch (Exception ex)
            {

                return false;
            }
          
        }
            private void sendMail()
        {
            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("job20456@gmail.com");
                mail.To.Add("itigut@gmail.com");
                mail.Bcc.Add("itigut@gmail.com");
                mail.Subject = "תרומה";
                mail.Body = "תודה על תרומתך הנכבדה";


                mail.IsBodyHtml = true;
                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential("job20456@gmail.com", "203845375Itigut");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

            }
            catch (Exception e)
            {
                throw e;
            }

            }

            public async Task<bool> updateDonation(Donation donationElement)
        {
            try
            {
                if (donationElement.CountDonation > 10000)
                {
                    sendMail();
                }
                var result = IDalDonate.updateDonation(donationElement);
                return await result;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public async Task<bool> deleteDonation(Donation donationElement)
        {
            try
            {
                var result = IDalDonate.deleteDonation(donationElement);
                return await result;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
