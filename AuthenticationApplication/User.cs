using System;

namespace BezaoOOP.AuthenticationApplication
{
    internal class User
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public double Level {get; set;}
    }

    public enum Gender
    {
        Male = 1,
        Female,
        Others
    }
}
