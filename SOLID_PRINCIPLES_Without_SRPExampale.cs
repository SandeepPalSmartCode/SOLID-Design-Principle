using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES_Without_SRP_Exampale
{
    
    public class Invoice
    {
        public long InvoiceCost { get; set; }
        public DateTime InvoiceDate { get; set; }
        public void AddInvoice()
        {
            try
            {
                // Here we need to write the Code for adding invoice
                // Once the Invoice has been added, then send the  mail
                MailMessage mailMessage = new MailMessage("From", "To", "Subject", "Body");
                this.SendInvoiceEmail(mailMessage);
                //SRP voilation here
            }
            catch (Exception ex)
            {
                //Error Logging
                System.IO.File.WriteAllText(@"D:\ErrorLog.txt", ex.ToString());
                //SRP voilation here
            }
        }
        public void DeleteInvoice()
        {
            try
            {
                //Here we need to write the Code for Deleting the already generated invoice
            }
            catch (Exception ex)
            {
                //Error Logging
                System.IO.File.WriteAllText(@"D:\ErrorLog.txt", ex.ToString());
            }
        }
        public void SendInvoiceEmail(MailMessage mailMessage)
        {
            try
            {
                // Send email Logic
            }
            catch (Exception ex)
            {
                //Error Logging
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }
    }
}
