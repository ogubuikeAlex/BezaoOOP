using System;

namespace BezaoOOP.AuthenticationApplication
{
    public class InconsistentPasswordException : Exception
    {
        public override string Message => "Password mismatch!";

        DateTime CreatedAt { get; }

        public InconsistentPasswordException(DateTime createdAt)
        {
            CreatedAt = createdAt;
        }

    }
}
    

