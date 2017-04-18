using System;

namespace PawnShop.CommunicationService.Exceptions
{
    public class PasswordsDontMatchException : Exception
    {
        public PasswordsDontMatchException(string text)
            : base(text)
        {
        }
    }
}
