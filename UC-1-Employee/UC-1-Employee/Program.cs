namespace UC_1_Employee
{
    internal class Program
    {

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
 
        public static int computeEmpWage(string company,int empRatePerHour,int numOfWorkingDays,int maxHoursPerMonth)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        empHrs = 4;
                        break;
                    case 2:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day: "+totalWorkingDays + "Emp Hrs : "+ empHrs);

            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Employee Wage" + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            computeEmpWage("TCS",20,2,10);
            computeEmpWage("TechMahindra", 30, 8, 15);
        }
    }
}