namespace QuestionSet1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float basic_salary, HRA, DA, Gross_salary;
            Console.WriteLine("Enter Basic Salary : ");
            basic_salary=Convert.ToSingle(Console.ReadLine());
            if (basic_salary <= 10000)
            {
                HRA = (float)(basic_salary * 0.2);
                DA = (float)(basic_salary * 0.8);
                Gross_salary = basic_salary + HRA + DA;
                Console.WriteLine("Gross Salary is : "+Gross_salary.ToString());
            }
            else if (basic_salary <= 20000)
            {
                HRA = (float)(basic_salary * 0.25);
                DA = (float)(basic_salary * 0.9);
                Gross_salary = basic_salary + HRA + DA;
                Console.WriteLine("Gross Salary is : "+Gross_salary.ToString());
            }
            else if (basic_salary > 20000)
            {
                HRA = (float)(basic_salary * 0.3);
                DA = (float)(basic_salary * 0.95);
                Gross_salary = basic_salary + HRA + DA;
                Console.WriteLine("Gross Salary is : " + Gross_salary.ToString());
            }
        }
    }
}