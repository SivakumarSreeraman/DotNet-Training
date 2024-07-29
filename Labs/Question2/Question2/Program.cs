namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add the first character of a string at the front and back");
            string str1;
            Console.WriteLine("Enter input string : ");
            str1 = Console.ReadLine();
            
            if (str1.Length > 0)
            {
                string str2 = str1.Substring(0, 1);
                Console.WriteLine(str2);
                Console.WriteLine("Output String is : "+str2+str1+str2);
            }
            else
            {
                Console.WriteLine("String is empty");
            }

        }
    }
}