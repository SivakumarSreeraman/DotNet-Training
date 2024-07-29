namespace Day3
{
    internal class Program
    {
        public static void Swap(ref int a,ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            int b = int.Parse(Console.ReadLine());
            Swap(ref a,ref b);
            Console.WriteLine("Swap output is : " +"a="+ a +"& "+"b="+ b );
        }
    }
}