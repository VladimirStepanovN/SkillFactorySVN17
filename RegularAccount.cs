namespace SkillFactorySVN17;

public class RegularAccount : IAccount
{
    public string Type { get; set; }
    public double Balance { get; set; }
    public double Interest { get; set; }

    public RegularAccount(double balance)
    {
        Type = "Обычный";
        Balance = balance;
    }
}
