using System;

namespace BezaoOOP
{
    internal class LearningConstructors
    {
        public LearningConstructors()
        {

        }
    }

    public class User
    {
        public static int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }


        //Parameterized
        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }

        //Copy
        public User(User user)
        {
            if (user == null)
            {
                user = new User("Something inside", "Another Something");
            }

            Name = user?.Name ?? "Default value";
            Password = user?.Password ?? "Null Coalescing";
        }

        //Static 
        static User()
        {
            Id = 34;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Password: {Password}");
        }
    }

    class Laptop
    {
        private static Laptop laptop;
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        private Laptop()
        {
            laptop = new Laptop();
        }

        public static Laptop GetLaptop
        {
            get
            {

                laptop = laptop == null ? new Laptop() : laptop;
                laptop ??= new Laptop();
                return laptop;
            }
        }

    }

    public class PlayGround
    {
        public static void Run()
        {
            Console.WriteLine("\nOne");
            User user = new User("Amara", "Looking Down");
            user.Display();

            Console.WriteLine("\nTwo");
            User userTwo = new User(user);
            userTwo.Display();

            Console.WriteLine("\nThree");
            User userThree = new User(null);
            userThree.Display();


        }
    }
}
