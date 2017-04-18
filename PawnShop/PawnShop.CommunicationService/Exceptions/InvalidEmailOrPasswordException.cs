using System;

namespace PawnShop.CommunicationService.Exceptions
{
    public class InvalidEmailOrPasswordException : Exception
    {
        public InvalidEmailOrPasswordException(string message) :
            base(message)
        {

        }
    }
}
