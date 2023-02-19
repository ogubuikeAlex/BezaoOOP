using System;

namespace BezaoOOP
{
    internal class LearningInheritance
    {

    }

    public class ParentClass
    {
        private string _name;
        public string Address { get; set; }
        /*public ParentClass()
        {
            System.Console.WriteLine("Parent Class");
        }*/

        public ParentClass(string name, string address)
        {
            Console.WriteLine($"{name},\n{address}");
        }


      


        protected string GetName()
        {
            return _name;
        }
    }


    public class ChildClass : ParentClass
    {
        public ChildClass() : base("Stephen", "Amos")
        {
            Console.WriteLine("Child class two");
        }
        public ChildClass(string name, string address) : base(name, address)
        {
            Console.WriteLine("Child Class");
        }
        public int Id { get; set; }
        public void Run()
        {
            //_name = "Alex";
            //Name = "Alex";
            GetName();

            //Question: ParentClass parentClass = new ChildClass();

        }
    }

    public class UncleClass : ChildClass
    {
        public UncleClass()
        {
            Console.WriteLine("Uncle Class");
        }
    }
    public class AuntyClass : UncleClass
    {
        public AuntyClass()
        {
            Console.WriteLine("Aunty Class");
        }
    }

    public class PlayGroundThree
    {
        public static void Run()
        {
            //AuntyClass auntyClass = new AuntyClass();
            ChildClass childClass = new ChildClass();
        }
    }




}
