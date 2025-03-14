namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salary calculator");
            Console.WriteLine("Kirjuta brutopalk: ");
            double brutoSalary = Convert.ToDouble(Console.ReadLine());
            double netIncome = 0;
            //kasutada if ja else
            //kutsuda esile meetod Salary classist if ja else sees
            //if ja else kontrollivad palga suurust

            if (brutoSalary <= 1200)
            {
                netIncome = Salary.SalaryCalculationLess1200(brutoSalary, netIncome);
            }
            else if (brutoSalary >= 1200.01 && brutoSalary <= 2100)
            {
                 Salary.SalaryCalculationFrom1200To2100(brutoSalary);
            }
            else if (brutoSalary >= 2100.01)
            {
                Salary.SalaryCalculationIsAbove2100(brutoSalary);
            }
            else
            {
                Console.WriteLine("ERROR");
            }

            Console.WriteLine("Sinu neto sissetulek on " + netIncome);
        }
    }

    public static class Salary
    {
        public static double SalaryCalculationLess1200(double brutoIncome, double netIncome)
        {
            double incomeTax = 0.22;
            double taxFreeIncome = 654;

            double pensionFond = brutoIncome * 0.02;
            double unEmpTax = brutoIncome * 0.016;

            double incomeTaxSum = incomeTax * (brutoIncome -
                (taxFreeIncome + pensionFond + unEmpTax));
            netIncome = brutoIncome - (pensionFond + unEmpTax + incomeTaxSum);

            return netIncome;
        }

        public static double SalaryCalculationFrom1200To2100(double netIncome)
        {


            return netIncome;
        }

        public static double SalaryCalculationIsAbove2100(double netIncome)
        {


            return netIncome;
        }
    }
}
