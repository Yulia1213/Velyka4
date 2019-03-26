using System;
using System.Runtime.Serialization;

namespace Jornal
{
    public class MailExeption : ArgumentException
    {
        public MailExeption(string message)
            : base(message)
        {

        }
    }
}