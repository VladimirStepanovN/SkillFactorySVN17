namespace SkillFactorySVN17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создаём аккаунты с начальным балансом
            RegularAccount regularAccount = new(900);
            SalaryAccount salaryAccount = new(900);

            //Расчёт ставки в соответствии с типом
            Calculator.CalculateInterest(regularAccount);
            Calculator.CalculateInterest(salaryAccount);

            //Выводим данные для обычного аккаунта
            Console.WriteLine(regularAccount.Balance);
            Console.WriteLine(regularAccount.Interest);
            Console.WriteLine();

            //Выводим данные для зарплатного аккаунта
            Console.WriteLine(salaryAccount.Balance);
            Console.WriteLine(salaryAccount.Interest);
        }
    }
}