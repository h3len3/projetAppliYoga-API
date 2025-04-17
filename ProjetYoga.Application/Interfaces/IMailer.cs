using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Application.Interfaces
{
    public interface IMailer
    {
        void Send(string dest, string subject, string body, params Attachment[] attachments);
    }
}
