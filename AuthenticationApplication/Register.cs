namespace BezaoOOP.AuthenticationApplication
{
    internal class Register
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public Gender? Gender { get; set; }   
        public int Level { get; set; }
    }    
}
