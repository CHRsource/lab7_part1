using cs_lab7;

class WorkerFix : Person
{
    private double salary;
    private double prize_percent;
    public double Salary { get { return salary; } }
    public double PrizePercent { get { return prize_percent; } }
    public WorkerFix(string surname, string name, DateTime birthday, char sex, double salary, double prize_percent) : 
        base(surname, name, birthday, sex)
    {
        this.salary = salary;
        this.prize_percent = prize_percent;
    }
    public WorkerFix() : base()
    {
        salary = 0;
        prize_percent = 0;
    }
    public override void PrintAll()
    {
        base.PrintAll();
        Console.Write("Зарплата: ");
        Print(salary);
        Console.Write("Премия (в процентах): ");
        Print(prize_percent);
    }
    public override void InputAll()
    {
        base.InputAll();
        InputSalary();
        InputPrizePercent();
    }
    public void InputSalary()
    {
        Console.Write("Введите зарплату: ");
        salary = Convert.ToDouble(Console.ReadLine());
    }
    public void InputPrizePercent()
    {
        Console.Write("Введите премию в процентах: ");
        prize_percent = Convert.ToDouble(Console.ReadLine());
    }
    public virtual double SalaryWithPrize() { return Math.Round(salary + salary * prize_percent / 100, 2); }
    public double Tax() { return Math.Round(SalaryWithPrize() * 0.13, 2); }
    public double Income() { return SalaryWithPrize() - Tax(); }
}

