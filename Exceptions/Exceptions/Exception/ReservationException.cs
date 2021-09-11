using System;


namespace Exceptions.Exceptions
{
    class ReservationException : ApplicationException
    {
        public ReservationException(string message) : base(message)
        {

        }
    }
}
