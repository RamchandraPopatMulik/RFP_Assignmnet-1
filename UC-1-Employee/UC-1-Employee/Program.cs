namespace UC_1_Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IS_FULLTIME = 1;
            int EMP_RATE_PER_HR = 20;
            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULLTIME)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;
            }
            empwage = emphrs * EMP_RATE_PER_HR;
            Console.WriteLine("Employee Wage: " + empwage);
        }
    }
}