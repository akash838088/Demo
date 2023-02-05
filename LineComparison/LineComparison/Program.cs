namespace LineComparison
{

    public class Program
    {

        static void Main(string[]args)
         {
            CalculateLength length_One = new CalculateLength(1,2,3,4);
            double length = length_One.Calculate();

            CalculateLength length_Two = new CalculateLength(8,3,8,0);
            double length_ = length_Two.Calculate();
            

            //UC2
            if (length.Equals(length_))
                Console.WriteLine("Both line are equal");
            else
                Console.WriteLine("Both lines are not equal");

            //UC3
            if (length.CompareTo(length_) == 0)
                Console.WriteLine("Equals");
            else if (length.CompareTo(length_) > 0)
                Console.WriteLine("Line One is Greater");
            else
                Console.WriteLine("Line Two is Greater");
            Console.ReadLine();
            
        }
    }
}