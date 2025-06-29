using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code
{
    public interface IMailSender
    {
        bool SendMail(string toAddress, string message);
    }
}
