using System;

namespace ExerciseException.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) {
        
        }
    }
}
