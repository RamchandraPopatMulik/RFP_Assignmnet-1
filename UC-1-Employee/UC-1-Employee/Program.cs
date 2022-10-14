namespace UC_1_Employee
{
    internal class Program
    {
        public const int IS_PARTTIME = 1;
        public const int IS_FULLTIME = 2;
        public const int EMP_RATE_PERHR = 20;
        static void Main(string[] args)
        {
            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case 1:
                    emphrs = 4;
                    break;
                case 2:
                    emphrs = 8;
                    break;
                default:
                    emphrs = 0;
                    break;
            }
            empwage = emphrs * EMP_RATE_PERHR;
            Console.WriteLine("Employee Wage " + empwage);
        }
    }
}