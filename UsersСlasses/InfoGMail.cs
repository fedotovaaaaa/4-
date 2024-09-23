using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.UsersClasses;

namespace WindowsFormsApp1.UsersClasses
{
    internal class InfoGMail : InfoEmail
    {
        public InfoGMail(StringPair emailAdressTo, string subject, string body) :
           base(emailAdressTo, subject, body)
        {
            SmtpClientAdress = "smtp.gmail.com";
            EmailAdressFrom = new StringPair("is25vlasovaas@artcollege.ru", "Vlasova");
            EmailPassword = "erdanvkekciftobo";
            Port = 587;
        }
    }
}
