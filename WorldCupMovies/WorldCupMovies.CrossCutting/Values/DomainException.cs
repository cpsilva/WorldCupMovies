using System;

namespace WorldCupMovies.CrossCutting.Values
{
    public class DomainException : Exception
    {
        public DomainException(string message) : base(message)    
        {

        }
    }
}
