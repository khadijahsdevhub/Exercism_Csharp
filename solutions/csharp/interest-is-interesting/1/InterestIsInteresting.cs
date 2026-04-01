static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        float rate = 0.0f;
        if (balance < 0)
    {
        return 3.213f;
    }
    else if (balance < 1000)
    {
        return 0.5f;
    }
    else if (balance < 5000)
    {
        return 1.621f;
    }
    else
    {
        return 2.475f;
    }
        throw new NotImplementedException("Please implement the (static) SavingsAccount.InterestRate() method");
    }

    public static decimal Interest(decimal balance)
    {
        
        decimal rate = (decimal)InterestRate(balance);
    return (balance * rate) / 100.0m;
        
        throw new NotImplementedException("Please implement the (static) SavingsAccount.Interest() method");
        
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
         decimal rate = (decimal)InterestRate(balance);
        decimal interest = (balance * rate) / 100.0m;
        return balance + interest;

        
        throw new NotImplementedException("Please implement the (static) SavingsAccount.AnnualBalanceUpdate() method");
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
         int years = 0;

    while (balance < targetBalance)
    {
        balance += Interest(balance);
        years++;
    }

    return years;

        
        throw new NotImplementedException("Please implement the (static) SavingsAccount.YearsBeforeDesiredBalance() method");
    }
}
