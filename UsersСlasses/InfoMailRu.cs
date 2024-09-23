using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.UsersClasses;

namespace WindowsFormsApp1.UsersClasses
{
    internal class InfoMailRu : InfoEmail
    {
        public InfoMailRu(StringPair emailAdressTo, string subject, string body) :
                   base(emailAdressTo, subject, body)
        {
            SmtpClientAdress = "smtp.mail.ru";
            EmailAdressFrom = new StringPair("nastya.12v@mail.ru", "Vlasova");
            EmailPassword = "RRfMn3b8NRmBVq1XQp1G";
            Port = -1;
        }
    }
}
