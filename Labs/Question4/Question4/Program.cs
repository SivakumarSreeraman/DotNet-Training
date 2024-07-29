namespace Question4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1,str2;
            Console.WriteLine("Enter a string : ");
            str1 = Console.ReadLine();
            if(str1.Length>=3)
            {
                str2 = str1.Substring(0,3);
                Console.WriteLine("First 3 characters are : "+str2);
                Console.WriteLine("Output String is : " + str2 + str1 + str2);
            }
            else if(str1.Length>0) 
            {
                str2 = str1;
                Console.WriteLine("Output String is : " + str2 + str1 + str2);
            }
            else
            {
                Console.WriteLine("String is empty");
            }
        }
    }
}