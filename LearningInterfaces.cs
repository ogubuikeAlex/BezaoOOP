using System;

namespace BezaoOOP
{
    internal class LearningInterfaces
    {
        //Class with three methods
        //Interface
        //Classes that implements the interface
        public void OnWrite(IPerson person, string message)
        {
            person.Write(message);
        }

        public void OnBreak(IPerson person, string message)
        {
            person.GoForBreak(message);
        }

        public void OnStudy(IPerson person, string message)
        {
            person.Study(message);
        }
    }

    public interface IPerson
    {
        void Write (string message);
        void GoForBreak(string message);
        void Study (string message);
    }

    public class Teacher : IPerson
    {
        public void GoForBreak(string message)
        {
            Console.WriteLine("In Teacher");
            Console.WriteLine(message);
        }

        public void Study(string message)
        {
            Console.WriteLine("In Teacher");
            Console.WriteLine(message);
        }

        public void Write(string message)
        {
            Console.WriteLine("In Teacher");
            Console.WriteLine(message);
        }
    }

    public class Student : IPerson
    {
        public void GoForBreak(string message)
        {
            Console.WriteLine("In Student");
            Console.WriteLine(message);
        }

        public void Study(string message)
        {
            Console.WriteLine("In Student");
            Console.WriteLine(message);
        }

        public void Write(string message)
        {
            Console.WriteLine("In Student");
            Console.WriteLine(message);
        }
    }

    public class Admin : IPerson
    {
        public void GoForBreak(string message)
        {
            Console.WriteLine("In Admin");
            Console.WriteLine(message);
        }

        public void Study(string message)
        {
            Console.WriteLine("In Admin");
            Console.WriteLine(message);
        }

        public void Write(string message)
        {
            Console.WriteLine("In Admin");
            Console.WriteLine(message);
        }
    }

}
