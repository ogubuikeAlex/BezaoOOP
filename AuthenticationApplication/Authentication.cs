using System;

namespace BezaoOOP.AuthenticationApplication
{
    internal class Authentication
    {
        User _user = null;
        public void Register (Register register)
        {
            try
            {
                if (!PasswordValidator(register.Password, register.ConfirmPassword))
                {
                    InconsistentPasswordException inconsistentPassword = new InconsistentPasswordException(DateTime.Now);

                    throw inconsistentPassword;
                }
            } 
            catch (InconsistentPasswordException ex)
            {
                var _register = RegisterOperation.CollectUserInfo();

                Authentication auth = new Authentication();
                auth.Register(_register);
            }
            
            //Create a new User
            User user = new User()
            {
                Age = register.Age,
                Email = register.Email,
                FullName = $"{register.FirstName} {register.LastName}",
                Gender = register.Gender ?? Gender.Others,
                Level = register.Level,
                Password = register.Password,
            };

            _user = user;
            
        }

        void Login(string email, string password)
        {

        }

        public static bool PasswordValidator(string password, string confirmPassword) => password.Equals(confirmPassword);
        
    }
}
