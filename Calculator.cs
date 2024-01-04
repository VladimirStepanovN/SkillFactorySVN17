namespace SkillFactorySVN17;

public static class Calculator
{
    public static void CalculateInterest(IAccount account)
    {
        if (account.Type == "Обычный")
        {
            // Расчет процентной ставки обычного аккаунта по правилам банка
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance >= 1000)
                account.Interest -= account.Balance * 0.4;
        }
        else if (account.Type == "Зарплатный")
        {
            // Расчет процентной ставки зарплатного аккаунта по правилам банка
            account.Interest = account.Balance * 0.5;
        }
    }
}
