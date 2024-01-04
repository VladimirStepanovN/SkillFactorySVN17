namespace SkillFactorySVN17;

public class SalaryAccount : IAccount
{
    public string Type { get; set; }
    public double Balance { get; set; }
    public double Interest { get; set; }

    public SalaryAccount(double balance)
    {
        Type = "Зарплатный";
        Balance = balance;
    }
}
