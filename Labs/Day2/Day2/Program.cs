namespace Day2
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            int num1 = 15;
            Type typeofVariable = num1.GetType();
            Console.WriteLine(num1);
            //implicit
            double num2 = num1;  //Increment
            Console.WriteLine(num2);
            int num3 = (int)num2; //Decrement
            Console.WriteLine(num3);
            //Explicit
            int num4 = Convert.ToInt32(num3);
            Console.WriteLine(num4);
        }
    }
}