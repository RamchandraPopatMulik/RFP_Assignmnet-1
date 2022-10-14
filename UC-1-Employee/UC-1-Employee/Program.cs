namespace UC_1_Employee
{
    internal class Program
    {
        public const int IS_FullTime = 2;
        public const int IS_PartTime = 1;
        public const int EMP_RATE_PERHR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        static void Main(string[] args)
        {
            int emphr = 0;
            int empWage = 0;
            int totalempWage = 0;
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        emphr = 4;
                        break;
                    case 2:
                        emphr = 8;
                        break;
                    default:
                        emphr = 0;
                        break;
                }
                empWage = emphr * EMP_RATE_PERHR;
                totalempWage = totalempWage + empWage;
                Console.WriteLine("Emp Wage :" + empWage);
            }
            Console.WriteLine("Total EmpWage :" + totalempWage);
        }
    }
}