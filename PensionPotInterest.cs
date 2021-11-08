using System;

public class PensionPotInterest
{
    int total;
    //calculates their current pot, and forecasts it 
    //combined with their yearly contribution by expected interest rate
    public int calculator(int existingAndYearlyContribution, int interestRate, int years)
    {
        for (int i = 1; i <= years; i++)
        {
            total = existingAndYearlyContribution + (existingAndYearlyContribution * interestRate / 100);
        }
    
        return total;
    }
}
