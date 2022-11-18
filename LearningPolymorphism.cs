namespace BezaoOOP
{
    internal class LearningPolymorphism
    {
        public int Add()
        {
            return 5 + 6;
        }
      
        public int Add( string number, int num)
        {
            return num + 6;
        }

        public int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public virtual int Subtract (int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }
    }

    class Mathematics : LearningPolymorphism
    {
        public override int  Subtract(int numberOne, int numberTwo)
        {
            return numberTwo - numberOne;
        }
    }
}
