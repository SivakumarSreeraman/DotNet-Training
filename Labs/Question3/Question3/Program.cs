namespace Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to exchange the first and last character of a given string and create a new string");
            string str1;
            Console.WriteLine("Enter input string : ");
            str1 = Console.ReadLine();
            char[] chararray = str1.ToCharArray();
            
            if(str1.Length > 0 )
            {
                char firstchar = chararray[0];
                char lastchar = chararray[str1.Length - 1];
                chararray[0] = lastchar;
                chararray[str1.Length - 1] = firstchar;
                string result = new string (chararray);
                Console.WriteLine("Output String is : "+result);   
            }
            else {
                Console.WriteLine("String is empty");
                  }
        }
    }
}