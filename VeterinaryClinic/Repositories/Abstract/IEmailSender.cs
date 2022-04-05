using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinaryClinic.Models;

namespace VeterinaryClinic.Repositories.Abstract
{
    public interface IEmailSender
    {
        public void SendMessage(EmailViewModel model);
    }
}
