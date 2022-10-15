namespace UC_1_Employee
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject tcs = new EmpWageBuilderObject("TCS",40,5,15);
            EmpWageBuilderObject Tech = new EmpWageBuilderObject("TechMahindra",50,4,25);
            tcs.computeEmpWage();
            Console.WriteLine(tcs.toString());
            Tech.computeEmpWage();
            Console.WriteLine(Tech.toString());
        }
    }
}