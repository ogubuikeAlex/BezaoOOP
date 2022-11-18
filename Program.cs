using BezaoOOP;

public class Program
{
    public static void Main()
    {
        /*StoreItem storeItem = new StoreItem();
        storeItem.DisplayStoreItem();*/

        //Application.Run();
        //PlayGround.Run();

        //PlayGroundThree.Run();

      /*  StoreItem storeItemTwo = new StoreItem(5000, "Laptop", "WriteAnything");
        System.Console.WriteLine("\nParameterized Sample:");
        storeItemTwo.DisplayStoreItem();*/




        LearningInterfaces learningInterfaces = new LearningInterfaces();

        IPerson student = new Student();
        IPerson teacher = new Teacher();
        IPerson admin = new Admin();

        learningInterfaces.OnStudy(student, "I dont like to read!!!!");
        learningInterfaces.OnBreak(student, "I love to play");
        learningInterfaces.OnWrite(student, "Na God go understand this handwriting");

        learningInterfaces.OnStudy(teacher, "Hmmmmmmmm!!!!");
        learningInterfaces.OnBreak(teacher, "I need to study more");
        learningInterfaces.OnWrite(teacher, "What a handwriting🙂");

        learningInterfaces.OnStudy(admin, "I don pass this level");
        learningInterfaces.OnBreak(admin, "Jaiye jaiye");
        learningInterfaces.OnWrite(admin, "Query to Nneka!!");


    }
}
