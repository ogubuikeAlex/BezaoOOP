using System;

namespace BezaoOOP.AuthenticationApplication
{
    internal static class RegisterOperation
    {
        public static Register CollectUserInfo()
        {
            Register register = new Register();
            int gender = 0;
            try
            {
                Console.WriteLine("Enter your first name");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter your last name");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter your age");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Work experience in years");
                int experience = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your email");
                string email = Console.ReadLine();

                Console.WriteLine("Enter your Gender\n1: Male\n2: Female\n3: Others");
                gender = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your password");
                string password = Console.ReadLine();

                Console.WriteLine("Enter retype your password");
                string confirmPassword = Console.ReadLine();

                if (!Authentication.PasswordValidator(password, confirmPassword))
                {
                    InconsistentPasswordException inconsistentPassword = new InconsistentPasswordException(DateTime.Now)
                    {
                        HelpLink = "www.google.com",
                        Data =
                        {
                            {"gender", gender}
                        }
                    };


                    throw inconsistentPassword;
                }



               

                register.FirstName = firstName;
                register.LastName = lastName;
                register.Age = age;
                register.Email = email;
                register.Password = password;
                register.ConfirmPassword = confirmPassword;
                register.Gender = GetGender(gender);
                register.Level = age / experience;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("\nMake sure you send apriopiate integer values");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("\nWe cannot divide an integer by zero");
            }
            catch (InconsistentPasswordException ex) when (gender == 1) 
            {
                Console.WriteLine("Hey Guy! Shey you dey whine me ni");
            }
            catch (InconsistentPasswordException ex) when (gender == 2)
            {
                Console.WriteLine("Hey Girl! Shey you dey alright?");
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"TargetSite: {ex.TargetSite}");
                Console.WriteLine($"Declaring Type: {ex.TargetSite.DeclaringType}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }

            return register;
        }

        public static Gender? GetGender(int gender)
        {
            switch (gender)
            {
                case 1:
                    return Gender.Male;
                case 2:
                    return Gender.Female;
                case 3:
                    return Gender.Others;
                default:
                    return null;

            }
        }
    }
}
