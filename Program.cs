using System;

namespace myApp
{
    class PensionCalculator
    {
      
        public static void Main(string[] args)
        {
            //get age
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            //get salary
            Console.WriteLine("Enter your salary per year");
            int salary = Convert.ToInt32(Console.ReadLine());

            //get total contributions
            Console.WriteLine("What are your total contributions (as a percent)?");
            int contributions = Convert.ToInt32(Console.ReadLine());
            int contributionsAsDecimal = contributions / 100;

            //What is your life expentancy?
            Console.WriteLine("What is your life expectancy? (avg UK is 82 years)");
            int lifeExpectancy = Convert.ToInt32(Console.ReadLine());

            //choose your retirement age
            Console.WriteLine("Enter your retirement age: ");
            int retirementAge = Convert.ToInt32(Console.ReadLine());
            int yearsOfPensionReq = lifeExpectancy - retirementAge;


            //read input for existing pension pot
            Console.WriteLine("What is your existing pension pot?");
            int existingPensionPot = Convert.ToInt32(Console.ReadLine());

            //desired income for your retirement
            Console.WriteLine("What is desired income per year for your retirement?");
            int desiredIncome = Convert.ToInt32(Console.ReadLine());
            int totalDesiredPot = desiredIncome * yearsOfPensionReq;

            //What do you expect the interest to be on your pension pot?
            Console.WriteLine("What is the interest rate on your pension pot?");
            int interestRate = Convert.ToInt32(Console.ReadLine());

            int pensionContributionPerYear = salary * contributionsAsDecimal;

            var calc1 = new PensionPotInterest();
            int result = calc1.calculator((pensionContributionPerYear + existingPensionPot), interestRate, (retirementAge - age));
            
            System.Console.WriteLine("Your forecast pension per year will be:" + (result/yearsOfPensionReq));
            System.Console.WriteLine("Your desired pension per year: " + desiredIncome );










    
    
    
    
            
            
        }
    }
}
    




